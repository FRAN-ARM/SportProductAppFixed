
namespace SportProductApp.SportFlow.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using SportProductApp.Administration.Entities;
    using SportProductApp.Administration.Repositories;
    using SportProductApp.Modules.Common.UserManagment;
    using SportProductApp.SportFlow.Customers;
    using SportProductApp.SportFlow.Entities;
    using SportProductApp.SportFlow.Forms;
    using System;
    using System.Data;
    using System.Linq;
    using System.Web.Mvc;
    using MyRepository = Repositories.CustomersRepository;
    using MyRow = Entities.CustomersRow;

    [RoutePrefix("Services/SportFlow/Customers"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class CustomersController : ServiceEndpoint
    {
        /*[HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }*/
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<CustomersForm> request)
        {
            var form = request.Entity;

            // Check previo.
            if (string.IsNullOrWhiteSpace(form.UserUsername) ||
                string.IsNullOrWhiteSpace(form.UserDisplayName) ||
                string.IsNullOrWhiteSpace(form.UserEmail) ||
                string.IsNullOrWhiteSpace(form.CreditCard) )
                throw new ArgumentNullException("Required fields are missing.");

            // Validar la cantidad de caracteres correctos para una tarjeta de credito.
            var CreditCardLength = form.CreditCard.Length;
            if ( (CreditCardLength >= 15 && CreditCardLength <= 16) == false)
            {
                throw new ArgumentNullException("Please enter the correct number of digits for the credit card number.");
            };

            // Generar hash.
            string salt = null;
            var hash = UserRepository.GenerateHash(form.UserUsername + "pass6410", ref salt);

            // Crear e insertar Isuario.
            var user = new UserRow
            {
                Username = form.UserUsername.Trim(),
                DisplayName = form.UserDisplayName.Trim(),
                Email = form.UserEmail?.Trim(),
                Source = "custom",
                PasswordHash = hash,
                PasswordSalt = salt,
                InsertDate = DateTime.UtcNow,
                InsertUserId = 1,
                IsActive = 1,
                PublicId = $"USER-{DateTime.UtcNow.Ticks % 100000}-{form.UserUsername.ToUpperInvariant()}"
            };
            var userId = (int)uow.Connection.InsertAndGetID(user);

            // Crear e insertar el cliente.
            var year = DateTime.UtcNow.Year;
            var name = form.UserDisplayName.Replace(" ", "").ToUpperInvariant();
            var count = uow.Connection.Query<int>(
                "SELECT COUNT(*) FROM Customers WHERE PublicId LIKE @pattern",
                new { pattern = $"CUST-{name}-{year}-%" }).FirstOrDefault();
            var publicId = $"CUST-{year}-{name}-{(count + 1):D5}";
            var customer = new CustomersRow
            {
                UserId = userId,
                PublicId = publicId,
                Name = form.UserDisplayName,
                CreditCard = form.CreditCard ?? "",
                DateCreated = DateTime.UtcNow
            };
            uow.Connection.Insert(customer);

            UserRoleAndPermissionHelper.AssignRoleAndPermission(uow.Connection, userId, "Customer", "Customers:General");

            return new SaveResponse { EntityId = userId };
            //return new MyRepository().Create(uow, customer);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            var response = new MyRepository().Update(uow, request);
            var customer = request.Entity;

            // Obtener usuario vinculado y actualizarlo.
            var user = uow.Connection.TryById<UserRow>(customer.UserId ?? 0);
            if (user != null)
            {
                user.DisplayName = customer.Name;
                user.Email = customer.UserEmail;
                user.UpdateDate = DateTime.UtcNow;
                uow.Connection.UpdateById(user);
            }

            return response;
            //return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            var customer = uow.Connection.TryById<CustomersRow>(request.EntityId);

            // No eliminamos al usuario asociado, ya que no es una practica conveniente. Simplemente se desvincula del cliente.
            if (customer != null && customer.UserId != null)
            {
                var user = uow.Connection.TryById<UserRow>(customer.UserId.Value);
                if (user != null)
                {
                    user.IsActive = 0;
                    uow.Connection.UpdateById(user);
                }
            }

            // Ahora si, eliminamos al cliente.
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}

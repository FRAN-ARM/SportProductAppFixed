
namespace SportProductApp.SportFlow.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using SportProductApp.SportFlow.Entities;
    using System;
    using System.Data;
    using System.Linq;
    using System.Web.Mvc;
    using MyRepository = Repositories.ProductsRepository;
    using MyRow = Entities.ProductsRow;

    [RoutePrefix("Services/SportFlow/Products"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class ProductsController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            var form = request.Entity;

            // Check previo.
            if (string.IsNullOrWhiteSpace(form.Name) ||
                string.IsNullOrWhiteSpace(form.Price.ToString()))
                throw new ArgumentNullException("Required fields are missing.");

            // Crear e insertar Producto.
            var form_name = form.Name;

            var name = form_name.Replace(" ", "").ToUpperInvariant();
            var year = DateTime.UtcNow.Year;
            var count = uow.Connection.Query<int>(
                "SELECT COUNT(*) FROM Customers WHERE PublicId LIKE @pattern",
                new { pattern = $"PROD-{year}-{name}-%" }).FirstOrDefault();
            var product = new ProductsRow
            {
                PublicId = $"PROD-{year}-{name}-{(count + 1):D5}",
                Name = form_name,
                Price = form.Price,
            };
            uow.Connection.Insert(product);
            return new SaveResponse {};
            //return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
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

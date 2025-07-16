
namespace SportProductApp.SportFlow.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using Serenity.Services;
    using SportProductApp.Places.Entities;
    using SportProductApp.SportFlow.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using MyRow = Entities.OrdersRow;

    public class OrdersRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> {
            [MasterDetailRelation(foreignKey: "OrderId", IncludeColumns = "ProductId, Quantity, PriceSnapshot")]
            public List<OrderDetailsRow> ItemList => Row.ItemList;
            protected override void BeforeSave()
            {
                base.BeforeSave();

                if (IsCreate)
                {
                    // Para setear la fecha actual al campo read-only DateCreated.
                    if (Row.DateCreated == null)
                    {
                        Row.DateCreated = DateTime.Now;
                    }
                    // Para definir el PublicId de la orden, desde el primer momento.
                    if (Row.PublicId == null || Row.PublicId == "ORD")
                    {
                        var count = Connection.Count<OrdersRow>(
                            new Criteria(OrdersRow.Fields.CustomerId) == Row.CustomerId.Value
                        );
                        var year = DateTime.UtcNow.Year;
                        var sequence = count.ToString("D6");
                        Row.PublicId = $"ORD-{year}-{sequence}";
                    }
                    if (Row.Address == null)
                    {
                        Row.Address = "DIR";
                    }
                }
            }
            protected override void AfterSave()
            {
                base.AfterSave();

                if (Row.CustomerId == null)
                    throw new ValidationError("The client has not been defined.");

                var customer = Connection.TryById<CustomersRow>(Row.CustomerId.Value);
                if (customer == null)
                    throw new ValidationError("Invalid client.");

                // Obtener direccion con la provincia y ciudad.
                string provinceName = "";
                string cityName = "";
                if (Row.ProvinceId != null)
                {
                    var province = Connection.TryById<ProvincesRow>(Row.ProvinceId.Value);
                    provinceName = province?.Name ?? "";
                }
                if (Row.CityId != null)
                {
                    var city = Connection.TryById<CitiesRow>(Row.CityId.Value);
                    cityName = city?.Name ?? "";
                }
                var fullAddress = $"{provinceName}, {cityName}";

                // Hacer la actualización de los campos afectados.
                new SqlUpdate("Orders")
                    .Set(MyRow.Fields.PublicId, Row.PublicId)
                    .Set(MyRow.Fields.Address, fullAddress)
                    .Where(MyRow.Fields.OrderId == Row.OrderId.Value)
                    .Execute(Connection);
            }
        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}
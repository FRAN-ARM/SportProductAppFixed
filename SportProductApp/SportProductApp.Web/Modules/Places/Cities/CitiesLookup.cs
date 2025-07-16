
namespace SportProductApp.Modules.Places.Cities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;
    using SportProductApp.Places.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    [LookupScript("Places.CitiesLookup")]
    public class CitiesLookup : RowLookupScript<CitiesRow>
    {
        public CitiesLookup()
        {
            IdField = CitiesRow.Fields.CityId.PropertyName;
            TextField = CitiesRow.Fields.Name.PropertyName;
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            var f = CitiesRow.Fields;
            query.Select(f.CityId, f.Name, f.ProvinceId);
        }
    }
}
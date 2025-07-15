using FluentMigrator;
using System.Collections.Generic;
namespace SportProductApp.Migrations.DefaultDB
{
    [Migration(20250710000006)]
    public class DefaultDB_20250710_000006_Locations : Migration
    {
        public override void Up()
        {
            Create.Table("Provinces")
                .WithColumn("ProvinceId").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable().Unique();

            Create.Table("Cities")
                .WithColumn("CityId").AsInt32().PrimaryKey().Identity()
                .WithColumn("ProvinceId").AsInt32().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.ForeignKey("FK_City_Province")
                .FromTable("Cities").ForeignColumn("ProvinceId")
                .ToTable("Provinces").PrimaryColumn("ProvinceId");

            // Provincias y sus ciudades
            var locations = new[]
            {
                new { Province = "San Pedro de Macorís", Cities = new[] { "San Pedro de Macorís", "Guayacanes", "Consuelo" } },
                new { Province = "Distrito Nacional", Cities = new[] { "Santo Domingo" } },
                new { Province = "Santo Domingo", Cities = new[] { "Santo Domingo Este", "Santo Domingo Norte", "Santo Domingo Oeste", "Boca Chica", "Los Alcarrizos" } },
                new { Province = "Santiago", Cities = new[] { "Santiago de los Caballeros", "Tamboril", "Puñal", "Licey al Medio", "Villa Bisonó" } },
                new { Province = "La Vega", Cities = new[] { "La Vega", "Jarabacoa", "Constanza", "Jima Abajo" } },
                new { Province = "San Cristóbal", Cities = new[] { "San Cristóbal", "Yaguate", "Haina", "Nigua", "Sabana Grande de Palenque" } },
                new { Province = "Puerto Plata", Cities = new[] { "Puerto Plata", "Sosúa", "Imbert", "Luperón" } },
                new { Province = "Duarte", Cities = new[] { "San Francisco de Macorís", "Pimentel", "Villa Riva" } },
                new { Province = "La Altagracia", Cities = new[] { "Higüey", "Bávaro", "Punta Cana" } },
                new { Province = "Peravia", Cities = new[] { "Baní", "Nizao", "Matanzas" } }
            };

            int currentProvinceId = 1;
            foreach (var loc in locations)
            {
                Insert.IntoTable("Provinces").Row(new {
                    Name = loc.Province
                });
                foreach (var city in loc.Cities)
                {
                    Insert.IntoTable("Cities").Row(new
                    {
                        ProvinceId = currentProvinceId,
                        Name = city
                    });
                }
                currentProvinceId++;
            }
        }

        public override void Down()
        {
            Delete.Table("Cities");
            Delete.Table("Provinces");
        }
    }
}

using Serenity.Navigation;
using SportProductApp.Places.Pages;
using SportProductApp.SportFlow.Pages;
using SportProductApp.SportFlowCustomers.Pages;

[assembly: NavigationLink(1100, "Customers", typeof(CustomersController), icon: "fa-user")]
[assembly: NavigationLink(1200, "Products", typeof(ProductsController), icon: "fa-product-hunt")]
[assembly: NavigationLink(1400, "Orders", typeof(OrdersController), icon: "fa-id-card")]
[assembly: NavigationLink(1500, "Orders-Details", typeof(OrderDetailsController), icon: "fa-file-text")]
[assembly: NavigationLink(1700, "Provinces", typeof(ProvincesController), icon: "fa-globe")]
[assembly: NavigationLink(1800, "Cities", typeof(CitiesController), icon: "fa-globe")]

[assembly: NavigationLink(1900, "My Orders", typeof(CustomersOrdersController), icon: "fa-id-card")]

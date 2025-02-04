var builder = WebApplication.CreateBuilder(args);
//MVC Servisini ekledik.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Varsay�lan Route Tan�mlamam�z� yapt�k.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customers}/{action=Index}/{id?}"

    );
//Varsay�lan olarak HomeController.Index �al��acak �ekilde route tan�mlad�k

app.Run();

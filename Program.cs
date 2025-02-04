var builder = WebApplication.CreateBuilder(args);
//MVC Servisini ekledik.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Varsayýlan Route Tanýmlamamýzý yaptýk.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customers}/{action=Index}/{id?}"

    );
//Varsayýlan olarak HomeController.Index çalýþacak þekilde route tanýmladýk

app.Run();

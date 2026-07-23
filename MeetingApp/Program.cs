var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // mvc

var app = builder.Build();


app.UseStaticFiles(); 

app.UseRouting();

// mvc  <---  for this project
// rest api
// razor pages

// {controller=Home}/{action=Index}/{id?}"
// app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.SlidingExpiration = true;
        options.LoginPath = "/Login/Index";
    });


builder.Services.AddSession(options =>
{
    options.Cookie.Name = "Siemens.Session";
    options.IdleTimeout = TimeSpan.FromHours(10);
    options.Cookie.IsEssential = true;
});


var app = builder.Build();







app.UseRouting();
app.UseStaticFiles();



app.UseAuthentication();
app.UseAuthorization();


app.UseSession();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
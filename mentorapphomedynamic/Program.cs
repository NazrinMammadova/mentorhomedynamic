using mentorapphomedynamic.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(config.GetConnectionString("DefaultString"));
});


var app = builder.Build();



app.MapDefaultControllerRoute();
app.UseStaticFiles();

app.Run();

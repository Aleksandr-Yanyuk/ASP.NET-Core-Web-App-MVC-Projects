using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhlXVpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSn9Td0NnXX9ednJRRw==;Mgo+DSMBPh8sVXJ0S0J+XE9Bd1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdURjWHladHRVQGdVUA==;ORg4AjUWIQA/Gnt2VVhkQlFac15JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZiWX5YdHBVRmZVU0U=;MTMwMDQyM0AzMjMwMmUzNDJlMzBPcEhEVzFWNktDaWhHbzQ5Qm5TbzkrL1N5aVZuc1NvQ3puOVpuUVhDK1ZZPQ==;MTMwMDQyNEAzMjMwMmUzNDJlMzBiMzdJNWVlOXRiNkFjY3l3dE8vL1UrdUlzUDZrL3FxZWNhVHdyamFVdzZVPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFpDVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVgWH9fdnBRRmBbVkR3;MTMwMDQyNkAzMjMwMmUzNDJlMzBJR2g3dEtHVWN3SGYwZm93U09OYzlVdUEzVWpjcGU1QzZUajBqYlYwR3VnPQ==;MTMwMDQyN0AzMjMwMmUzNDJlMzBUV05WMVRHbjl5ZWdyc0ZCOS9lajlxRjNxK3ZaOE5leTB0aTllTTVEYm13PQ==;Mgo+DSMBMAY9C3t2VVhkQlFac15JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZiWX5YdHBVRmhYV0Y=;MTMwMDQyOUAzMjMwMmUzNDJlMzBLbUI2YzlzZEtxTlZMYk9tVU5jMFhhODdtT2toZW9pbzBIQWJ3RzROZCs0PQ==;MTMwMDQzMEAzMjMwMmUzNDJlMzBEY01DeE9EZENxVXVtYTIzTzk4aHdNZE1yVm9INU9TeTAvZzh6bXMzcTJJPQ==;MTMwMDQzMUAzMjMwMmUzNDJlMzBJR2g3dEtHVWN3SGYwZm93U09OYzlVdUEzVWpjcGU1QzZUajBqYlYwR3VnPQ==");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();

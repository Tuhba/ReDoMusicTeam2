var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Brand}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "customer",
    pattern: "{controller=Customer}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "order",
    pattern: "{controller=Order}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "product",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "review",
    pattern: "{controller=Review}/{action=Index}/{id?}");

app.Run();

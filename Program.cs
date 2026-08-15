using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlogMedia.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddIdentity<IdentityUser, IdentityRole>(option =>
{
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireDigit = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireUppercase = false;
    option.Password.RequiredLength = 1;
}).AddEntityFrameworkStores<AppDbContext>();

builder.Services.ConfigureApplicationCookie(option =>
{
    option.LoginPath = "/Auth/Login";
    option.AccessDeniedPath = "/Auth/AccessDenied";
    option.ExpireTimeSpan = TimeSpan.FromHours(1);
    option.SlidingExpiration = true;
});

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var _userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    var _roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    string adminEmail = "admin@gmail.com";
    string adminPassword = "admin";

    var existingAdminRole = await _roleManager.FindByNameAsync("Admin");
    if(existingAdminRole==null)
    {
        await _roleManager.CreateAsync(new IdentityRole("Admin"));
    }
    var existingAdminUser = await _userManager.FindByNameAsync(adminEmail);
    if(existingAdminUser==null)
    {
        var adminUser = new IdentityUser { UserName = adminEmail, Email = adminEmail };
       await _userManager.CreateAsync(adminUser, adminPassword);
       await _userManager.AddToRoleAsync(adminUser, "Admin");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Post}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

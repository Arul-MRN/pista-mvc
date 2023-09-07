using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pista.UI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    //app.UseDirectoryBrowser();
    //var provider = new FileExtensionContentTypeProvider();
    //provider.Mappings[".scss"] = "text/css";
    //app.UseStaticFiles(new StaticFileOptions()
    //{
    //    ContentTypeProvider = provider
    //});

    //var provider = new FileExtensionContentTypeProvider();
    //app.UseStaticFiles(new StaticFileOptions()
    //{
    //    FileProvider = new PhysicalFileProvider(
    //         Path.Combine(Directory.GetCurrentDirectory(), @"SassyStyles")),
    //    RequestPath = new PathString("/SassyStyles"),
    //    ContentTypeProvider = provider
    //});
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
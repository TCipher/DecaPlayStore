using DecaPlayStore.Data;
using DecaPlayStore.Data.IRepository;
using DecaPlayStore.Data.IServices;
using DecaPlayStore.Data.Services;
using DecaPlayStore.Data.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//DbContext configuration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")
           ));
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<IAlbumService, AlbumService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
var applicationBuilder = builder.Build();
//Seed databse
SeedIntializer.SeedData(applicationBuilder);

// Configure the HTTP request pipeline.
if (!applicationBuilder.Environment.IsDevelopment())
{
    applicationBuilder.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    applicationBuilder.UseHsts();
}

applicationBuilder.UseHttpsRedirection();
applicationBuilder.UseStaticFiles();

applicationBuilder.UseRouting();

applicationBuilder.UseAuthorization();

applicationBuilder.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

applicationBuilder.Run();

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HomeAdminDemo.Data;
namespace HomeAdminDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("HomeAdminDemoIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'HomeAdminDemoIdentityContextConnection' not found.");

            builder.Services.AddDbContext<HomeAdminDemoIdentityContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<HomeAdminDemoIdentityContext>();

            // So app can useMvc
            builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
             
            // For routing purposes, or it redirects to wrong links

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "areaRoute",
                  template: "{area}/{controller=Home}/{action=Index}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
            });
            

            app.Run();
        }
    }
}
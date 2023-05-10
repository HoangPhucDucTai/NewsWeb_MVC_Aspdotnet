using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace NewsWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var stringConnectdb = Configuration.GetConnectionString("NewsWeb");
            services.AddDbContext<NewsWebContext>(option => option.UseSqlServer(stringConnectdb));
            services.AddSession();
            services.AddSingleton<HtmlEncoder>(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddMemoryCache();
            services.AddHttpContextAccessor();
            services.AddAuthentication("CookieAuthentication")
                    .AddCookie("CookieAuthentication", config =>
                    {
                        config.Cookie.Name = "UserLoginCookie";
                        config.ExpireTimeSpan = TimeSpan.FromDays(1);
                        config.LoginPath = "/dang-nhap.html";
                        config.LogoutPath = "/dang-xuat.html";
                        config.AccessDeniedPath = "/not-found.html";
                    });
            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.Name = "UserLoginCookie";
                option.Cookie.Expiration = TimeSpan.FromDays(150);
                option.ExpireTimeSpan = TimeSpan.FromDays(150);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

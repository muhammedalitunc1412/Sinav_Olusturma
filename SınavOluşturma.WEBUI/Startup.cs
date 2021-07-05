using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SınavOluşturma.Data.Abstract;
using SınavOluşturma.Data.Concrete.EntityFramework.Contexts;
using SınavOluşturma.Data.Concrete.EntityFramework.Repositories;
using SınavOluşturma.Services.Abstract;
using SınavOluşturma.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavOluşturma.WEBUI
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

            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddControllersWithViews();
            services.AddDbContext<SınavOluşturContext>();

            services.AddScoped<IUserRepository, EfUserRepository>();
            services.AddScoped<ITestRepository, EfTestRepository>();
            services.AddScoped<IQuestionRepository, EfQuestionRepository>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ITestService, TestManager>();
            services.AddScoped<IQuestionService, QuestionManager>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option => {
                option.LoginPath = "/Login/Index";
                option.Cookie.Name = "CredentialCookie";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var client = new SınavOluşturContext())
            {
                client.Database.EnsureCreated();
            }
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
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}

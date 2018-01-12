using CakeShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CakeShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<ICakeRepository, CakeRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddDbContext<CakeShopDbContext>(ctx =>
            {
                ctx.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            //var context = app.ApplicationServices.GetRequiredService<CakeShopDbContext>();

            //DbInitializer.SeedDatabase(context);
        }
    }
}

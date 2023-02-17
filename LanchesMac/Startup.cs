using Microsoft.AspNetCore.Identity;
using System;

namespace LanchesMac;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    //This method gets called by the runtime. Use this method to add services to the conteiner
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
    }

    //This methodgets called by the run time. Use this method to configure...
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The deafault HSTS value is 30 days. You may want to change ...
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
       
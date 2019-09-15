using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuaverCodeChallenge.Servcies;

namespace QuaverCodeChallenge
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<GitHubService>();

            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/GitHub", "/");
                options.Conventions.AddPageRoute("/GitHub", "home");
                options.Conventions.AddPageRoute("/GitHub", "GitHubTopRepos");
                options.Conventions.AddAreaPageRoute("GitHub", "/GitHubTopRepos", "/GitHub/GitHubTopRepos");

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                  //  name: "default",
                   // template: "{controller=GitHub}/{action=GitHubTopRepos}/{id?}");

                routes.MapRoute("GitHub", "GitHub/{*GitHubTopRepos}",
                defaults: new { controller = "GitHubTopRepos", action = "GitHubTopRepos" });

               // routes.MapRoute("default", "{controller=GitHubTopRepos}/{action=GitHubTopRepos}/{id?}");
            });
        }
    }
}

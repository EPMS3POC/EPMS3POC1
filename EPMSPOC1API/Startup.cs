using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EPMS3POC1.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace EPMS3POC1
{
    public class Startup
    {
        //private const string DatabaseConnection = "Server=DESKTOP-H1OJJBC\\SQLEXPRESS;Database=EPMS3POC1;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true;";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOData();
            services.AddTransient<EPMSPOCModelBuilder>();

            //JSON Services for REST
            services.AddMvc().AddJsonOptions(opt =>
            {
                opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("CorsPolicy"));
            });

            //Databse connector
            //services.AddDbContext<EPMSPOCContext>(options => options.UseSqlServer("Data Source=TELLLAP03\\SQLDEV;Database=EPMS3POC1; Integrated Security=False;User ID=sa_admin;Password= emps_sql_admin#123; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultipleActiveResultSets=true; MultiSubnetFailover = False"));
            services.AddDbContext<EPMSPOCContext>(options => options.UseSqlServer("Server=TELLLAP03\\SQLDEV;Database=EPMS3POC1;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true;"));
            //var connection = Configuration.GetConnectionString(DatabaseConnection);
            //services.AddDbContext<EPMSPOCContext>(options => options.UseSqlServer(connection, b => b.UseRowNumberForPaging()));

            //To Allow AJAX Cross Domain calls
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, EPMSPOCModelBuilder modelBuilder)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();        
            //var oDataConventionModelBuilder = new ODataConventionModelBuilder(app.ApplicationServices);

            app.UseMvc(route =>
            {
                //var patientPerson = oDataConventionModelBuilder.Function("PatientPerson");
                //patientPerson.ReturnsCollectionFromEntitySet<PatientPerson>("PatientPerson");

                //oDataConventionModelBuilder.Function("PatientPerson")
                //.ReturnsCollectionFromEntitySet<PatientPerson>("PatientPerson");
                route.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                route.MapODataServiceRoute("ODataRoute", "odata", modelBuilder.GetEdmModel(app.ApplicationServices));
                //route.MapODataServiceRoute("ODataRoute", "odata", oDataConventionModelBuilder.GetEdmModel());
                //route.EnableDependencyInjection();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseExceptionHandler("/Error");
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCors("CorsPolicy");

        }
    }
}

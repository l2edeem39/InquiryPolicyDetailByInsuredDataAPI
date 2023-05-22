using InquiryPolicyDetailByInsuredDataAPI.Authentication;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Context;
using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Repository;
using InquiryPolicyDetailByInsuredDataAPI.Services;
using InquiryPolicyDetailByInsuredDataAPI.Services.Interface;
using InquiryPolicyDetailByInsuredDataAPI.Share.EnvironmentShared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace InquiryPolicyDetailByInsuredDataAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            //add Service
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IInquiryPolicyDetailService, InquiryPolicyDetailService>();
            services.AddTransient<IUserService, UserService>();
            services.AddDbContext<DbContextClass>(ServiceLifetime.Transient);
            services.AddDbContext<DbContextLogin>(ServiceLifetime.Transient);

            #region Configure Swagger  
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InquiryPolicyDetailByInsuredDataAPI", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
            });
            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "InquiryPolicyDetailByInsuredDataAPI");
                c.RoutePrefix = string.Empty;
            });

            EnvironmentShared._configuration = Configuration;
            LogService._configuration = Configuration;
        }
    }
}

using CommunicationApp.Data;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using CommunicationApp.Models;
using CommunicationApp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace CommunicationApp
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
            services.AddMvc(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme).AddCertificate();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                //options.EnableSensitiveDataLogging(true);
            });
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;  //Kräver inte att kontot verifieras via e-post
                options.Password.RequiredLength = 6;             //6 tecken är default för lösenordslängd
                options.Password.RequireLowercase = true;        //gemen krävs i lösenordet
                options.Password.RequireUppercase = true;        //Versal krävs i lösenordet
                options.Password.RequireDigit = false;           //Stänger av så Siffra inte behövs i lösenordet
                options.Password.RequireNonAlphanumeric = false; //Stänger av så Specialtecken (!?= osv..) inte behövs i lösenordet
            });

            services.AddIdentity<Person, IdentityRole>()
                .AddDefaultUI()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Require administrator role", policy => policy.RequireRole("Administratör"));
            });

            services.AddControllersWithViews();

            services.AddRazorPages()
                .AddRazorRuntimeCompilation();

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            // Register repositories to be injected in the controllers
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IMeetingRepository, MeetingRepository>();
            services.AddScoped<IMeetingDateRepository, MeetingDateRepository>();
            services.AddScoped<IBlogPostRepository, BlogPostRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IMailRepository, MailRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
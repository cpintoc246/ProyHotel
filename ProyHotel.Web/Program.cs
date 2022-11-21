using System.Configuration;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();
        void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddResponseCompression();
            services.AddResponseCaching();
            string conn = Configuration.GetConnectionString("connlpl");
            services.AddDbContext<DataContextLPL>(options => options.UseSqlServer(conn));
            //autenticacion Usuar y contraseña
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.AddSingleton<IEmailSender, EmailSender>();
        }
        // Configure the HTTP request pipeline.
        void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }*/
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

            var cultureInfo = new CultureInfo("en-ES");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


            app.UseHttpsRedirection();
            app.UseResponseCompression();
            app.UseResponseCaching();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();



        }
        app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
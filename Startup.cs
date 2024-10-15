using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder; // Ekledim
using Microsoft.AspNetCore.Hosting; // Ekledim
using Lokko.Models;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // Bu metod, servisleri yapılandırır.
    public void ConfigureServices(IServiceCollection services)
    {
        // SMTP ayarlarını yapılandırma
        services.Configure<SmtpSettings>(Configuration.GetSection("SmtpSettings"));

        
        // Diğer servisleri buraya ekleyebilirsiniz
    }

    // Bu metod, HTTP isteğinin işlenme şeklini yapılandırır.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Middleware'leri buraya ekleyebilirsiniz
    }
}

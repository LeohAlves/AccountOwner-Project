
namespace AccountOwnerServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder
                .AllowAnyOrigin()   //WithOrigins("dominio) para restringir acesso
                .AllowAnyMethod()  // métodos (put get etc) - WithMethods("GET", "POST") para restringir a metodos especificos
                .AllowAnyHeader() //WithHeaders("accept,"cont")
                );
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>{
                
            });
        }
    }
}
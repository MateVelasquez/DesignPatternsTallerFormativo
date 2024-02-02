using DesignPatterns.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Infraestructure.DependencyInjection
{
    // Clase para configurar servicios (inyección de dependencias)
    public class ServicesConfiguration
    {
        // Método para configurar servicios
        public void ConfigureServices(IServiceCollection services)
        {
            // Comentario: Puedes elegir usar uno u otro repositorio de vehículos aquí

            // Descomentar la siguiente línea para usar DBVehicleRepository al integrar una base de datos
            // services.AddTransient<IVehicleRepository, DBVehicleRepository>();

            // Utiliza MyVehiclesRepository como repositorio de vehículos (en memoria)
            services.AddTransient<IVehicleRepository, MyVehiclesRepository>();
        }
    }
}

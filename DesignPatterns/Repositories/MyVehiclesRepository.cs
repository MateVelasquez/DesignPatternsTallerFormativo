using DesignPatterns.Infraestructure.Singleton;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    // Implementación de la interfaz IVehicleRepository
    public class MyVehiclesRepository : IVehicleRepository
    {
        // Singleton utilizado para almacenar la colección de vehículos en memoria
        private readonly MemoryColletion _memoryCollection = MemoryColletion.Instance;

        // Constructor de la clase MyVehiclesRepository
        public MyVehiclesRepository()
        {
            // No se necesita instanciar _memoryCollection directamente, ya que el Singleton ya proporciona una instancia única.
            //_memoryCollection = new List<Vehicle>();
        }

        // Método para agregar un vehículo al repositorio
        public void AddVehicle(Vehicle vehicle)
        {
            _memoryCollection.Vehicles.Add(vehicle);
        }

        // Método para encontrar un vehículo por su ID
        public Vehicle Find(string id)
        {
            // Utiliza LINQ para buscar un vehículo por su ID en la colección
            return _memoryCollection.Vehicles.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
        }

        // Método para obtener todos los vehículos en el repositorio
        public ICollection<Vehicle> GetVehicles()
        {
            // Convierte la colección de vehículos a una lista y la devuelve
            return _memoryCollection.Vehicles.ToList();
        }
    }
}

using DesignPatterns.Models;  // Importa el espacio de nombres Models, que contiene la definición de la clase Vehicle.
using System;  // Importa el espacio de nombres System.
using System.Collections;  // Importa el espacio de nombres System.Collections.
using System.Collections.Generic;  // Importa el espacio de nombres System.Collections.Generic, que contiene las interfaces y clases de colecciones genéricas.

namespace DesignPatterns.Infraestructure.Singleton
{
    // Declaración de un espacio de nombres llamado Singleton dentro de Infraestructure dentro del proyecto DesignPatterns.
    public class MemoryColletion
    {
        // Declaración de una clase llamada MemoryColletion.

        private static MemoryColletion _instance;  // Declaración de una variable estática privada llamada _instance de tipo MemoryColletion.

        public ICollection<Vehicle> Vehicles { get; set; }  // Declaración de una propiedad pública llamada Vehicles de tipo ICollection<Vehicle> que representa una colección de objetos Vehicle.

        private MemoryColletion()  // Declaración de un constructor privado llamado MemoryColletion. Este constructor inicializa la propiedad Vehicles con una nueva instancia de List<Vehicle>.
        {
            Vehicles = new List<Vehicle>();
        }

        public static MemoryColletion Instance  // Declaración de una propiedad pública y estática llamada Instance de tipo MemoryColletion. Se implementa el patrón Singleton.
        {
            get
            {
                if (_instance == null)  // Verifica si la variable _instance es nula.
                {
                    _instance = new MemoryColletion();  // Si _instance es nula, crea una nueva instancia de MemoryColletion y la asigna a _instance.
                }
                return _instance;  // Retorna la instancia única de MemoryColletion.
            }
        }
    }
}

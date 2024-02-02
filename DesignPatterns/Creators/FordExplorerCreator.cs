﻿using DesignPatterns.Models;  // Importa el espacio de nombres Models, que contiene la definición de la clase Vehicle.
using DesignPatterns.Models.Builder;  // Importa el espacio de nombres Builder, que contiene la definición de la clase CarModelBuilder.

namespace DesignPatterns.Creators
{
    // Declaración de un espacio de nombres llamado Creators dentro del proyecto DesignPatterns.
    public class FordExplorerCreator : Creator
    {
        // Declaración de una clase concreta llamada FordExplorerCreator que hereda de Creator.

        // Implementación del método abstracto Create de la clase base Creator.
        public override Vehicle Create()
        {
            // Creación de un nuevo objeto CarModelBuilder y configuración de sus propiedades.
            var builder = new CarModelBuilder()
                .SetModel("Escape")
                .SetColor("red");

            // Llamada al método Build para obtener una instancia de Vehicle construida con las configuraciones.
            return builder.Build();
        }
    }
}

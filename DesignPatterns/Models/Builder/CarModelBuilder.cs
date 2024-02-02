using DesignPatterns.Models;  // Importa el espacio de nombres Models, que contiene la definición de la clase Vehicle.
using System;  // Importa el espacio de nombres System.
using System.Collections.Generic;  // Importa el espacio de nombres System.Collections.Generic, que contiene las interfaces y clases de colecciones genéricas.

namespace DesignPatterns.Models.Builder
{
    // Declaración de un espacio de nombres llamado Builder dentro del proyecto Models.
    public class CarModelBuilder
    {
        // Declaración de una clase llamada CarModelBuilder.

        private string _color = "red";  // Declaración de una variable privada de tipo string llamada _color, inicializada con "red".
        private string _brand = "Ford";  // Declaración de una variable privada de tipo string llamada _brand, inicializada con "Ford".
        private string _model = "Mustang";  // Declaración de una variable privada de tipo string llamada _model, inicializada con "Mustang".
        private int _year = DateTime.Now.Year;  // Declaración de una variable privada de tipo int llamada _year, inicializada con el año actual.

        // Método para establecer el color y devolver el propio objeto CarModelBuilder.
        public CarModelBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        // Método para establecer la marca y devolver el propio objeto CarModelBuilder.
        public CarModelBuilder SetBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        // Método para establecer el modelo y devolver el propio objeto CarModelBuilder.
        public CarModelBuilder SetModel(string model)
        {
            _model = model;
            return this;
        }

        // Método para establecer el año y devolver el propio objeto CarModelBuilder.
        public CarModelBuilder SetYear(int year)
        {
            _year = year;
            return this;
        }

        // Método para construir un objeto Vehicle (Car en este caso) con los valores establecidos.
        public Vehicle Build()
        {
            // Aquí deberías ajustar la lógica para que coincida con el constructor de tu clase Vehicle.
            return new Car(_color, _brand, _model, _year);
        }
    }
}

using DesignPatterns.Models;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Models.Builder
{
    public class CarModelBuilder
    {
        private string _color = "red";
        private string _brand = "Ford";
        private string _model = "Mustang";
        private int _year = DateTime.Now.Year;

        public CarModelBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        public CarModelBuilder SetBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        public CarModelBuilder SetModel(string model)
        {
            _model = model;
            return this;
        }

        public CarModelBuilder SetYear(int year)
        {
            _year = year;
            return this;
        }

        public Vehicle Build()
        {
            // Aquí deberías ajustar la lógica para que coincida con el constructor de tu clase Vehicle
            return new Car(_color, _brand, _model, _year);
        }

    }
}

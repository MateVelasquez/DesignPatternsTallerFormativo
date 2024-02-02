using DesignPatterns.Models;  // Importa el espacio de nombres Models, que contiene la definición de la clase Vehicle.

namespace DesignPatterns.Creators
{
    // Declaración de un espacio de nombres llamado Creators dentro del proyecto DesignPatterns.
    public abstract class Creator
    {
        // Declaración de una clase abstracta llamada Creator.

        // Método abstracto que debe ser implementado por las clases derivadas.
        public abstract Vehicle Create();
    }
}

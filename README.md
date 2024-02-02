# Taller Formativo Mejores Prácticas MVC

**Autor: Mateo Velásquez**

**Estudiante del curso ISWZ3101-3076_3077- INGENIERIA WEB**

**Universidad de Las Américas, Quito-Ecuador**

## Objetivo Propuesto

Aplicar los conocimientos adquiridos en la materia de Ingeniería web para identificar patrones de diseño aplicados en soluciones MVC. Partiendo de un análisis correcto de la problemática actual (Código real), diseñar, desarrollar e implementar una solución que permita solventar un problema propuesto.

## Indicaciones

Lea detenidamente el siguiente problema escenario:

Pepito es un Ingeniero de Software Junior en Codificando Con Patrones Cía. Ltda. Se le ha encargado la tarea de completar los requerimientos funcionales del aplicativo de automóviles al que la empresa da soporte.

### Requisitos

1. Implementar los métodos de agregar vehículos (add Mustang y add Explorer) en el Home Page. El programador anterior implementó un patrón repositorio que contiene los métodos CRUD para el repositorio de automóviles; sin embargo, el equipo de QA ha reportado que no funciona como se espera.

2. El equipo de base de datos ha comentado que el esquema de la base de datos no está listo. Por lo que se necesita buscar una forma de probar la funcionalidad sin tener que guardar en la base de datos, de tal forma que después se implemente la funcionalidad de base de datos cuando esté lista.

3. El equipo de negocio ha solicitado agregar el año actual y 20 propiedades más por defecto que se solicitarán en el siguiente sprint. Estas propiedades afectan a vehículo. Implementa un patrón de diseño para agregar propiedades por defecto, y como lo diseñarías para minimizar los cambios para el siguiente sprint.

4. Se planea agregar un nuevo modelo. El Arquitecto de Software prevé que la unidad de negocio planeará la introducción de más modelos por lo cual sugiere la implementación de un Factory Method.
   - Color: Red
   - Marca: Ford
   - Modelo: Escape

## Desarrollo

### Problemas Identificados

1. **Implementación incorrecta del patrón repositorio:**
   - El equipo de QA ha reportado que los métodos CRUD del patrón repositorio no funcionan según lo esperado. Se identifica una posible deficiencia en la implementación de los métodos de agregar vehículos (add Mustang y add Explorer) en el Home Page.

2. **Esquema de la base de datos no listo:**
   - El equipo de base de datos ha comunicado que el esquema de la base de datos no está preparado, lo que dificulta la prueba efectiva de la funcionalidad. La falta de un entorno de base de datos funcional impide la validación completa de la lógica de negocio.

3. **Adición de propiedades por defecto:**
   - El equipo de negocio solicita la inclusión del año actual y 20 propiedades adicionales por defecto que afectan a los vehículos. La falta de un patrón de diseño adecuado para manejar la inclusión de estas propiedades puede resultar en cambios significativos en el código durante el siguiente sprint, afectando la mantenibilidad del sistema.

4. **Incorporación de nuevos modelos sin un enfoque adecuado:**
   - Se planea agregar un nuevo modelo (Escape) y el Arquitecto de Software sugiere la implementación de un Factory Method. Sin embargo, la falta de un diseño modular y escalable para la incorporación de nuevos modelos puede dificultar la expansión futura, especialmente si la unidad de negocio tiene previsto introducir más modelos.

### Restricciones y Limitaciones

- **Tiempo de Entrega:**
  - El proyecto enfrenta restricciones temporales, ya que se deben abordar los problemas identificados y cumplir con los requerimientos dentro de un marco de tiempo definido.

- **Dependencia de la Base de Datos:**
  - La falta de disponibilidad del esquema de la base de datos limita la capacidad para realizar pruebas exhaustivas y afecta la funcionalidad que depende de la persistencia de datos.

- **Cambios Mínimos para el Siguiente Sprint:**
  - La necesidad de agregar 20 propiedades por defecto con mínimos cambios en el código actual impone restricciones en la arquitectura y diseño del sistema para garantizar la flexibilidad y mantenibilidad.

- **Escalabilidad del Sistema:**
  - La falta de un enfoque adecuado para la incorporación de nuevos modelos puede resultar en dificultades a medida que la unidad de negocio planee la introducción de más modelos en el futuro.

### Metodologías integrales para solucionar el problema

#### Patrón Singleton
![image](https://github.com/MateVelasquez/DesignPatternsTallerFormativo/assets/118739432/abf79984-2d6a-438b-bf85-611f51a9e2d7)


El patrón de diseño Singleton pertenece a la categoría de patrones creacionales y tiene como objetivo garantizar que una clase tenga una única instancia y proporcionar un punto global de acceso a esa instancia. En otras palabras, el patrón Singleton asegura que una clase tenga solo una instancia en todo el programa y proporciona un método para acceder a esa instancia desde cualquier punto de la aplicación.

El patrón Singleton en este proyecto se aplicará a través de la clase MemoryColletion, asegurando que solo haya una instancia global de esta clase. Esta instancia es utilizada por el controlador HomeController para realizar operaciones en la colección de vehículos a través del repositorio _vehicleRepository. Esto garantiza consistencia y coherencia en la manipulación de datos en toda la aplicación.

#### Patrón Builder
![image](https://github.com/MateVelasquez/DesignPatternsTallerFormativo/assets/118739432/6faf3f81-5d8a-47c0-b972-154bd1dca6de)


El patrón de diseño Builder pertenece a la categoría de patrones creacionales y se utiliza para construir un objeto complejo paso a paso. Este patrón separa la construcción de un objeto complejo de su representación, permitiendo la creación de diferentes representaciones del mismo proceso de construcción. Proporciona una manera flexible y escalable de construir objetos, permitiendo la variación de las partes individuales del objeto sin modificar la estructura del proceso de construcción.

El patrón Builder se utiliza para construir objetos complejos paso a paso. CarModelBuilder actúa como el Builder, permitiendo la configuración paso a paso de los atributos del vehículo antes de su construcción. El método Build en CarModelBuilder crea y devuelve un objeto Vehicle construido con los valores configurados. Esto permite construir modelos de vehículos específicos de manera más clara y flexible sin la necesidad de tener múltiples constructores en la clase Vehicle. El patrón Builder se emplea para separar la construcción de objetos (Vehicle) de su representación, proporcionando un proceso de construcción más detallado y configurable. En este caso, se utiliza para construir diferentes modelos de vehículos de manera más legible y mantenible.

#### Patrón Factory Method
![image](https://github.com/MateVelasquez/DesignPatternsTallerFormativo/assets/118739432/40cb82d3-ed52-465e-940c-7fd47be24e90)


El patrón Factory Method es un patrón de diseño creacional que proporciona una interfaz para crear objetos en una superclase, pero permite a las subclases alterar el tipo de objetos que se crearán. En otras palabras, define una interfaz para crear un objeto, pero deja la elección de su tipo concreto a las clases que lo implementan, creando así instancias de clases derivadas.

En este proyecto, Creator actúa como la interfaz base con el Factory Method Create, que es implementado por las clases concretas FordMustangCreator y FordExplorerCreator. Cada creador concreto tiene la responsabilidad de crear un tipo específico de Vehicle (Mustang o Explorer) y puede realizar configuraciones adicionales según sea necesario.

En el contexto de un sistema de gestión de vehículos, podríamos tener un Creator abstracto llamado VehicleCreator con un Factory Method llamado CreateVehicle. Las clases concretas como CarCreator implementarían este Factory Method para crear instancias específicas de productos como Car. Esto permite al sistema agregar nuevos tipos de vehículos en el futuro sin cambiar el código existente del Creator.

## Bibliografía

- [Refactoring Guru - Patrón Singleton](https://refactoring.guru/es/design-patterns/singleton)
- [Refactoring Guru - Patrón Builder](https://refactoring.guru/es/design-patterns/builder)
- [Refactoring Guru - Patrón Factory Method](https://refactoring.guru/es/design-patterns/factory-method)

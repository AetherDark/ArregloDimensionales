# Sistema de Administración de Hoteles

## Descripción
Este proyecto es una aplicación de consola desarrollada en C# que permite la gestión de reservas de habitaciones en un hotel mediante un arreglo multidimensional. La aplicación proporciona funcionalidades para inicializar el sistema, realizar reservas, liberar habitaciones, buscar habitaciones, mostrar la ocupación del hotel y realizar cambios de habitación.

El sistema utiliza un arreglo de seis dimensiones para representar habitaciones organizadas por país, estado, ciudad, torre, piso y número de habitación. Cada habitación tiene atributos como estado (ocupada o libre), nombre del huésped, número de huéspedes y duración de la estancia.

Este proyecto fue desarrollado como parte del curso de **Estructura de Datos**, con el objetivo de aplicar conocimientos sobre manipulación de arreglos multidimensionales y estructuración de datos en C#.

## Características
- Permite gestionar la ocupación de un hotel estructurado en **países, estados, ciudades, torres, pisos y habitaciones**.
- Funciones para **reservar**, **liberar**, **buscar** y **mostrar** habitaciones.
- Posibilidad de **cambiar huéspedes** de una habitación a otra disponible.
- Interfaz de consola intuitiva para facilitar la interacción con el usuario.

## Requisitos
Para ejecutar este proyecto, necesitas lo siguiente:
- .NET SDK instalado (versión 6.0 o superior recomendada)
- Un entorno de desarrollo compatible con C# (Visual Studio, Visual Studio Code o JetBrains Rider)
- Consola de comandos o terminal para ejecutar el programa

## Instalación
1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/AetherDark/ArregloDimensionales.git
   ```
   
2. **Acceder al directorio del proyecto**
   ```bash
   cd ArregloDimensionales
   ```
   
3. **Compilar el programa**
   ```bash
   dotnet build
   ```
   
4. **Ejecutar el programa**
   ```bash
   dotnet run
   ```

## Uso
1. Al ejecutar el programa, aparecerá un menú con las siguientes opciones:
   - **1. Limpiar arreglo**: Inicializa todas las habitaciones como disponibles.
   - **2. Altas (Reservar habitación)**: Permite ingresar un huésped a una habitación específica.
   - **3. Bajas (Liberar habitación)**: Elimina la reserva de una habitación.
   - **4. Buscar habitación**: Permite consultar el estado de una habitación.
   - **5. Mostrar ocupación**: Muestra un resumen de habitaciones ocupadas y disponibles.
   - **6. Cambio de habitación**: Permite mover un huésped de una habitación a otra.
   - **7. Créditos**: Muestra la información del autor del proyecto.
   - **8. Salir**: Finaliza el programa.
   
2. Selecciona una opción ingresando el número correspondiente y sigue las instrucciones en pantalla.
3. Para salir del programa, selecciona la opción **8** y confirma tu elección.

## Notas
- Este proyecto es una demostración educativa y no está optimizado para producción.
- No se ha implementado persistencia de datos; la información se pierde al cerrar el programa.
- No se aceptan contribuciones externas en este repositorio.

## Autor
**Jaret Eduardo González Carrasco**

¡Gracias por revisar este proyecto! 😊


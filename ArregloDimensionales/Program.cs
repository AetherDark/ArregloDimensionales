using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDimensionales
{
    internal class Program
    {
        private static bool finalizarPrograma()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("¿Estas seguro de querer finalizar? (s/n): ");
                string respuesta = Console.ReadLine()?.ToLower();

                if (respuesta == "n")
                {
                    return false;
                }
                else if (respuesta == "s")
                {
                    Console.WriteLine("¡Adiós!");
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa 's' para sí o 'n' para no.");
                    Console.ReadKey();
                }
            }
        }

        static void Main(string[] args)
        {
            HotelManager hotel = new HotelManager();

            while (true)
            {
                Console.Clear();

                try
                {
                    bool finalizar = false;

                    Console.WriteLine("=== Sistema de administracion de hoteles ===" +
                                    "\n1. Limpiar arreglo" +
                                    "\n2. Altas (Reservar habitacion)" +
                                    "\n3. Bajas (Liberar habitacion)" +
                                    "\n4. Buscar habitacion" +
                                    "\n5. Mostrar ocupacion" +
                                    "\n6. Cambio de habitacion" +
                                    "\n7. Creditos" +
                                    "\n8. Salir" +
                                    "\nSeleccione una opcion:");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 8)
                    {
                        if (finalizarPrograma() == true) // Aqui pregunta si desea continuar
                        {
                            finalizar = true; // Termina el ciclo
                        }
                    }
                    else if(opcion > 8)
                    {
                        Console.WriteLine("\nIngrese una opcion valida para continuar");
                    }

                    if (finalizar == true)
                    {
                        break;
                    }

                    CapturaDatos captura = new CapturaDatos(opcion, hotel);
                    string mensaje = captura.MetodoSeleccionado();
                    Console.WriteLine(mensaje);

                    Console.WriteLine("Presiona enter para volver al menu... ");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ingrese una opcion valida para continuar");
                    Console.ReadKey();
                }
            }
        }
    }
}

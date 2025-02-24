using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDimensionales
{
    public class CapturaDatos
    {
        public int Opcion;
        private HotelManager hotel;

        public CapturaDatos(int opcion, HotelManager hotel)
        {
            this.Opcion = opcion;
            this.hotel = hotel;
        }

        public string MetodoSeleccionado()
        {
            string resultado = "";
            switch (Opcion)
            {
                case 1:
                    hotel.Inicializar();
                    Console.Clear();
                    resultado = "El arreglo del hotel se ha inicializado correctamente\n";
                    break;

                case 2:
                    resultado = hotel.ReservarHabitacion();
                    break;

                case 3:
                    resultado = hotel.LiberarHabitacion();
                    break;

                case 4:
                    resultado = hotel.Buscar();
                    break;

                case 5:
                    resultado = hotel.Mostrar();
                    break;

                case 6:
                    resultado = hotel.Cambio();
                    break;

                case 7:
                    Console.Clear();
                    return "Materia: Estructura de Datos\nIntegrante: Jaret Eduardo Gonzalez Carrasco\nMatricula: 22170143\n";
            }
            return resultado;
        }
    }
}

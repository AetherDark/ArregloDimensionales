using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDimensionales
{
    public class HotelManager
    {
        public const int PAIS = 2;
        public const int ESTADO = 3;
        public const int CIUDAD = 5;
        public const int TORRE = 3;
        public const int PISO = 12;
        public const int HABITACION = 20;

        public Habitacion[,,,,,] Habitaciones;

        public HotelManager()
        {
            Habitaciones = new Habitacion[PAIS, ESTADO, CIUDAD, TORRE, PISO, HABITACION];
            Inicializar();
        }

        public HotelManager(HotelManager hotel)
        {
            Habitaciones = new Habitacion[PAIS, ESTADO, CIUDAD, TORRE, PISO, HABITACION];
            Inicializar();
        }

        private int LeerEntero(string mensaje, int min, int max)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max)
                {
                    return valor;
                }
                Console.WriteLine($"Error: Ingresa un número entre {min} y {max}");
            }
        }

        public void Inicializar()
        {
            for (int p = 0; p < PAIS; p++)
            {
                for (int e = 0; e < ESTADO; e++)
                {
                    for (int c = 0; c < CIUDAD; c++)
                    {
                        for (int t = 0; t < TORRE; t++)
                        {
                            for (int i = 0; i < PISO; i++)
                            {
                                for (int h = 0; h < HABITACION; h++)
                                {
                                    Habitaciones[p, e, c, t, i, h] = new Habitacion();
                                }
                            }
                        }
                    }
                }
            }
        }

        public string ReservarHabitacion()
        {
            Console.Clear();
            int p = LeerEntero("Ingrese el número de PAIS (0 a 1): ", 0, 1);
            int e = LeerEntero("Ingrese el número de ESTADO (0 a 2): ", 0, 2);
            int c = LeerEntero("Ingrese el número de CIUDAD (0 a 4): ", 0, 4);
            int t = LeerEntero("Ingrese el número de TORRE (0 a 2): ", 0, 2);
            int i = LeerEntero("Ingrese el número de PISO (0 a 11): ", 0, 11);
            int h = LeerEntero("Ingrese el número de HABITACION (0 a 19): ", 0, 19);
            Console.Clear();

            Habitacion cuarto = Habitaciones[p, e, c, t, i, h];

            if (cuarto.Estado == 1)
            {
                return "La habitacion ya esta ocupada, no se puede hacer la reserva\n";
            }

            Console.WriteLine("Ingrese el nombre del ocupante: ");
            string nombre = Console.ReadLine();
            int numHuespedes = LeerEntero("Ingrese el número de huéspedes: ", 1, 12);
            int dias = LeerEntero("Ingrese el número de días: ", 1, 31);

            cuarto.Estado = 1;
            cuarto.Nombre = nombre;
            cuarto.numHuespedes = numHuespedes;
            cuarto.Dias = dias;

            return $"Habitacion reservada en la ubicacion [{p}, {e}, {c}, {t}, {i}, {h}]\n";
        }

        public string LiberarHabitacion()
        {
            Console.Clear();
            int p = LeerEntero("Ingrese el número de PAIS (0 a 1): ", 0, 1);
            int e = LeerEntero("Ingrese el número de ESTADO (0 a 2): ", 0, 2);
            int c = LeerEntero("Ingrese el número de CIUDAD (0 a 4): ", 0, 4);
            int t = LeerEntero("Ingrese el número de TORRE (0 a 2): ", 0, 2);
            int i = LeerEntero("Ingrese el número de PISO (0 a 11): ", 0, 11);
            int h = LeerEntero("Ingrese el número de HABITACION (0 a 19): ", 0, 19);
            Console.Clear();

            Habitacion cuarto = Habitaciones[p, e, c, t, i, h];
            if (cuarto.Estado == 0)
            {
                return "La habitación ya está desocupada.\n";
            }

            cuarto.Estado = 0;
            cuarto.Nombre = "";
            cuarto.numHuespedes = 0;
            cuarto.Dias = 0;

            return $"Habitación liberada en la ubicación [{p}, {e}, {c}, {t}, {i}, {h}].\n";
        }

        public string Buscar()
        {
            Console.Clear();
            int p = LeerEntero("Ingrese el número de PAIS (0 a 1): ", 0, 1);
            int e = LeerEntero("Ingrese el número de ESTADO (0 a 2): ", 0, 2);
            int c = LeerEntero("Ingrese el número de CIUDAD (0 a 4): ", 0, 4);
            int t = LeerEntero("Ingrese el número de TORRE (0 a 2): ", 0, 2);
            int i = LeerEntero("Ingrese el número de PISO (0 a 11): ", 0, 11);
            int h = LeerEntero("Ingrese el número de HABITACION (0 a 19): ", 0, 19);
            Console.Clear();

            Habitacion cuarto = Habitaciones[p, e, c, t, i, h];
            if (cuarto.Estado == 0)
            {
                Console.Clear();
                return "La habitación está desocupada.\n";
            }
            else
            {
                Console.Clear();
                return $"Habitación ocupada:\nNombre: {cuarto.Nombre}\nNúmero de Huéspedes: {cuarto.numHuespedes}\nDías: {cuarto.Dias}\n";
            }
        }

        public string Mostrar()
        {
            Console.Clear();
            int p = LeerEntero("Ingrese el número de País (0 a 1): ", 0, 1);
            int e = LeerEntero("Ingrese el número de Estado (0 a 2): ", 0, 2);
            int c = LeerEntero("Ingrese el número de Ciudad (0 a 4): ", 0, 4);
            Console.Clear();

            StringBuilder sb = new StringBuilder();

            for (int t = 0; t < TORRE; t++)
            {
                sb.AppendLine($"\n--- Torre {t} ---");
                for (int i = 0; i < PISO; i++)
                {
                    sb.Append($"Piso {i}: ");
                    for (int h = 0; h < HABITACION; h++)
                    {
                        sb.Append(Habitaciones[p, e, c, t, i, h].Estado == 1 ? "X " : "O ");
                    }
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        public string Cambio()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los datos de la habitación ORIGEN (ocupada):");
            int pOrigen = LeerEntero("País (0 a 1): ", 0, 1);
            int eOrigen = LeerEntero("Estado (0 a 2): ", 0, 2);
            int cOrigen = LeerEntero("Ciudad (0 a 4): ", 0, 4);
            int tOrigen = LeerEntero("Torre (0 a 2): ", 0, 2);
            int iOrigen = LeerEntero("Piso (0 a 11): ", 0, 11);
            int hOrigen = LeerEntero("Habitación (0 a 19): ", 0, 19);

            Habitacion origen = Habitaciones[pOrigen, eOrigen, cOrigen, tOrigen, iOrigen, hOrigen];
            if (origen.Estado == 0)
            {
                Console.Clear();
                return "La habitación ORIGEN está desocupada. No se puede realizar el cambio.\n";
            }

            Console.Clear();
            Console.WriteLine("Ingrese los datos de la habitación DESTINO (desocupada):");
            int pDestino = LeerEntero("País (0 a 1): ", 0, 1);
            int eDestino = LeerEntero("Estado (0 a 2): ", 0, 2);
            int cDestino = LeerEntero("Ciudad (0 a 4): ", 0, 4);
            int tDestino = LeerEntero("Torre (0 a 2): ", 0, 2);
            int iDestino = LeerEntero("Piso (0 a 11): ", 0, 11);
            int hDestino = LeerEntero("Habitación (0 a 19): ", 0, 19);
            Console.Clear();

            Habitacion destino = Habitaciones[pDestino, eDestino, cDestino, tDestino, iDestino, hDestino];
            if (destino.Estado == 1)
            {
                Console.Clear();
                return "La habitación DESTINO ya está ocupada. No se puede realizar el cambio.\n";
            }

            // Se transfiere la reserva
            destino.Estado = origen.Estado;
            destino.Nombre = origen.Nombre;
            destino.numHuespedes = origen.numHuespedes;
            destino.Dias = origen.Dias;

            // Se libera la habitación origen
            origen.Estado = 0;
            origen.Nombre = "";
            origen.numHuespedes = 0;
            origen.Dias = 0;

            Console.Clear();
            return "Cambio realizado correctamente.\n";
        }
    }
}

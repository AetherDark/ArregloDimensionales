using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDimensionales
{
    public class Habitacion
    {
        public int Estado {  get; set; }
        public string Nombre { get; set; }
        public int numHuespedes { get; set; }
        public int Dias {  get; set; }

        public Habitacion()
        {
            Estado = 0;
            Nombre = "";
            numHuespedes = 0;
            Dias = 0;
        }
    }
}

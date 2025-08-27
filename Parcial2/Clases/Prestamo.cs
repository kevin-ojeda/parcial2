using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Prestamo
    {
        public string Socio { get; set; }
        public DateTime Fecha { get; set; }
        public int DuracionDias { get; set; }

        public Prestamo(string socio, int duracionDias)
        {
            Socio = socio;
            Fecha = DateTime.Now;
            DuracionDias = duracionDias;
        }

        public override string ToString()
        {
            return $"Socio: {Socio}, Fecha: {Fecha.ToShortDateString()}, Duración: {DuracionDias} días";
        }
    }
}

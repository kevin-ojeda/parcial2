using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Digital : Libro
    {
        public Digital(string titulo, string autor, int isbn) : base(titulo, autor, isbn) {}

        public override bool EstaDisponible() => true;

        public override void RegistrarPrestamo(string socio, int duracionDias)
        {
            Prestamos.Add(new Prestamo(socio, duracionDias));
            Console.WriteLine("Préstamo registrado (digital).");
        }

        public override string ToString()
        {
            return base.ToString() + "Tipo: Digital, Disponible: Siempre";
        }
    }
}

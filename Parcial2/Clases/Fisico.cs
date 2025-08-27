using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Fisico : Libro
    {
        public bool Disponible { get; set; } = true;
        public Fisico(string titulo, string autor, int isbn) : base(titulo, autor, isbn) {}

        public override bool EstaDisponible() => Disponible;

        public override void RegistrarPrestamo(string socio, int duracionDias)
        {
            if (!Disponible)
            {
                Console.WriteLine("El libro no está disponible.");
                return;
            }

            Prestamos.Add(new Prestamo(socio, duracionDias));
            Disponible = false;
            Console.WriteLine("Préstamo registrado (físico).");
        }

        public void Devolver()
        {
            Disponible = true;
        }

        public override string ToString()
        {
            return base.ToString() + $"Tipo: Físico, Disponible: {Disponible}";
        }
    }
}


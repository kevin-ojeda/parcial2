using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public static List<Libro> ListaLibros { get; set; } = new List<Libro>();

        protected Libro(string titulo, string autor, int isbn)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
        }

        public abstract bool EstaDisponible();
        public abstract void RegistrarPrestamo(string socio, int duracionDias);

        public int CantidadPrestamos() => Prestamos.Count;

        public override string ToString()
        {
        return $"Titulo: {Titulo}, Autor: {Autor} Préstamos: {CantidadPrestamos()}";
        }

        public static Libro BuscarPorISBN(int isbn)
        {
            return ListaLibros.Find(l => l.ISBN == isbn);
        }


    }
}

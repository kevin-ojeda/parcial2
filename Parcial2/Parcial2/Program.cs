using System.Security.Cryptography.X509Certificates;
using Clases;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //La biblioteca puede tener distintos tipos de libros: físicos y digitales. Todos los libros tienen título,
            //autor e ISBN (único identificador). Los libros deben poder registrar préstamos realizados por los socios.
            //Un préstamo debe guardar información de la fecha, el socio y la duración en días. Un libro físico puede estar disponible o no,
            //dependiendo de si fue prestado. Un libro digital siempre está disponible (no se agota).
            //El sistema debe permitir que cada libro calcule cuántos préstamos tuvo.

            List<Libro> biblioteca = new List<Libro>();
            bool salir = true;
            bool salir2 = true;
            while (salir)
            {
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1 - Registrar libro");
                Console.WriteLine("2 - Registrar préstamo de un libro");
                Console.WriteLine("3 - Mostrar información de un libro");
                Console.WriteLine("4 - Mostrar todos los libros y estadísticas generales");
                Console.WriteLine("5 - Salir");
                Console.Write("Seleccione una opción: ");

                string input = Console.ReadLine();
                int opcion;

                if (int.TryParse(input, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese título: ");
                            string titulo = Console.ReadLine();
                            Console.Write("Ingrese autor: ");
                            string autor = Console.ReadLine();
                            int isbn;
                            while (true)
                            {
                                Console.Write("Ingresa ISBN: ");
                                if (int.TryParse(Console.ReadLine(), out isbn))
                                {
                                    if (Libro.BuscarPorISBN(isbn) != null)
                                    {
                                        Console.WriteLine("Ya existe un libro con ese ISBN. Intenta de nuevo.");
                                        continue;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("ISBN inválido, debe ser un número.");
                                }
                            }

                            Console.Write("¿Es físico (1) o digital (2)? ");
                            string tipo = Console.ReadLine();

                            if (tipo == "1")
                                Libro.ListaLibros.Add(new Fisico(titulo, autor, isbn));
                            else if (tipo == "2")
                                Libro.ListaLibros.Add(new Digital(titulo, autor, isbn));
                            else
                                Console.WriteLine("Opción inválida.");
                            break;
                        case 2:
                            Console.Write("Ingrese ISBN del libro: ");
                            if (!int.TryParse(Console.ReadLine(), out isbn))
                            {
                                Console.WriteLine("ISBN inválido.");
                                break;
                            }
                            Libro libro = Libro.BuscarPorISBN(isbn);
                            if (libro == null)
                            {
                                Console.WriteLine("No existe un libro con ese ISBN.");
                                break;
                            }

                            if (!libro.EstaDisponible())
                            {
                                Console.WriteLine("El libro no está disponible.");
                                break;
                            }

                            Console.Write("Ingrese nombre del socio: ");
                            string socio = Console.ReadLine();

                            Console.Write("Ingrese duración del préstamo en días: ");
                            if (!int.TryParse(Console.ReadLine(), out int dias))
                            {
                                Console.WriteLine("Duración inválida.");
                                break;
                            }

                            libro.RegistrarPrestamo(socio, dias);
                            break;
                        case 3:
                            Console.WriteLine("ingresar ISBN del libro");
                            if (!int.TryParse(Console.ReadLine(), out isbn))
                            {
                                Console.WriteLine("ISBN inválido.");
                                break;
                            }
                            libro = Libro.BuscarPorISBN(isbn);
                            if (libro == null)
                            {
                                Console.WriteLine("No existe un libro con ese ISBN.");
                                break;
                            }
                            Console.WriteLine(libro.ToString());
                            break;
                        case 4:
                            Console.WriteLine("Mostrar todos los libros y estadisticas generales");
                            foreach (var librito in Libro.ListaLibros)
                            {
                                Console.WriteLine($"Título: {librito.Titulo}, Autor: {librito.Autor}, Préstamos: {librito.Prestamos.Count}, ISBN: {librito.ISBN}");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa...");
                            salir = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida, intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                }
                Console.WriteLine();
            }
        }
    }
}

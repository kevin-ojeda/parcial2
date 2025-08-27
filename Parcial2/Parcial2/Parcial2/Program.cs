using Clases;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            bool salir2 = true;
            while (salir)
            {
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1 - Opción 1");
                Console.WriteLine("2 - Opción 2");
                Console.WriteLine("3 - Opción 3");
                Console.WriteLine("4 - Opción 4");
                Console.WriteLine("5 - Opción 5");
                Console.WriteLine("6 - Salir");
                Console.Write("Seleccione una opción: ");

                string input = Console.ReadLine();
                int opcion;

                if (int.TryParse(input, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Elegiste la opción 1");
                            while (salir2)
                            {
                                Console.WriteLine("===== REGISTRO DE PERSONAJES =====");
                                Console.WriteLine("Seleccione el tipo de personaje a registrar:");
                                Console.WriteLine("1 - Guerrero");
                                Console.WriteLine("2 - Mago");
                                Console.WriteLine("3 - Arquero");
                                Console.WriteLine("4 - Volver al menú principal");
                                string tipoPersonaje = Console.ReadLine();
                                if (tipoPersonaje == "4")
                                {
                                    salir2 = false;
                                    break;
                                }
                                Console.Write("Ingrese el nombre del personaje: ");
                                string nombre = Console.ReadLine();
                                Console.Write("Ingrese el nivel del personaje (1-100): ");
                                string nivelInput = Console.ReadLine();
                                int nivel;
                                while (!int.TryParse(nivelInput, out nivel) || nivel < 1 || nivel > 100)
                                {
                                    Console.Write("Nivel inválido. Ingrese un nivel entre 1 y 100: ");
                                    nivelInput = Console.ReadLine();
                                }
                                //Personaje personaje = null;
                                switch (tipoPersonaje)
                                {
                                    case "1":
                                        //personaje = new Guerrero(nombre, nivel);
                                        break;
                                    case "2":
                                        //personaje = new Mago(nombre, nivel);
                                        break;
                                    case "3":
                                        //personaje = new Arquero(nombre, nivel);
                                        break;
                                    default:
                                        Console.WriteLine("Tipo de personaje no válido. Intente nuevamente.");
                                        continue;
                                }
                                //personaje.RegistrarPersonaje(personaje);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Elegiste la opción 2");
                            Console.WriteLine("Opción 2: Ver lista de personajes creados.");
                            /*if (Personaje.ListaPersonajes.Count == 0)
                            {
                                Console.WriteLine("No hay personajes registrados.");
                            }
                            else
                            {
                                Console.WriteLine("Lista de personajes registrados:");
                                foreach (var p in Personaje.ListaPersonajes)
                                {
                                    Console.WriteLine($"Nombre: {p.Nombre}, Nivel: {p.Nivel}, Vida: {p.Vida}, Ataque: {p.Ataque}, Defensa: {p.Defensa}");
                                }
                            }*/
                            break;
                        case 3:
                            Console.WriteLine("Elegiste la opción 3");
                            break;
                        case 4:
                            Console.WriteLine("Elegiste la opción 4");
                            break;
                        case 5:
                            Console.WriteLine("Elegiste la opción 5");
                            break;
                        case 6:
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

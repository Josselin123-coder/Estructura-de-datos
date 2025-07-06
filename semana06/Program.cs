using System;

namespace semana06
{
    /// <summary>
    /// Programa principal que ejecuta las pruebas de todas las clases
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SEMANA 6 - ESTRUCTURAS DE DATOS ===\n");

            // Pruebas de la clase Lista
            Lista miLista = new Lista();
            miLista.PruebasLista();

            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Pruebas de la clase Busqueda
            Busqueda listaBusqueda = new Busqueda();
            listaBusqueda.PruebasBusqueda();



            // Pausa para ver el resultado en consola
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
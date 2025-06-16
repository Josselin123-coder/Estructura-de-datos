using System;

namespace SEMANA_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] telefonos = {"09840271985", "0984027165", "451266666"};
            Estudiante estudiantes = new Estudiante(1, "Josselin", "Villafuerte", "Loma", telefonos);
            estudiantes.MostrarInformacion();
            
            // Pausa para ver el resultado en consola
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
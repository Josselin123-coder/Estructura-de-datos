using System;

namespace SEMANA_13
{
    class CatalogoRevistas    // Creo una clase que contiene toda la lógica del programa.
    {
        static void Main(string[] args)
        {
            // creo un catálogo con al menos 10 títulos de revistas
            string[] revistas = {
                "Ciencia Hoy", "Educación y Sociedad", "Neuroeducación", "Tecnología y Futuro",
                "Revista Pedagógica", "Aprendizaje Activo", "Innovación Docente", "Matemática Real",
                "Lenguaje y Cultura", "Revista Digital"
            };

            bool salir = false; // Declaro una variable booleana para controlar el ciclo del menú.

            // Inicio un ciclo para mostrar el menú hasta que el usuario decida salir
            while (!salir)
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Buscar título");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine() ?? "";
  // Utilizo un switch para ejecutar la acción correspondiente según la opción elegida.
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el título a buscar: ");
                        string tituloBuscado = Console.ReadLine() ?? "";

                        // Llamo al método de búsqueda recursiva
                        bool encontrado = BuscarRecursivo(revistas, tituloBuscado.Trim(), 0);

                        // Muestro el resultado según corresponda
                        Console.WriteLine(encontrado ? "Resultado: Encontrado" : "Resultado: No encontrado");
                        break;

                    case "2":
                        salir = true;
                        Console.WriteLine("Gracias por usar el catálogo.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        // Implemento la búsqueda recursiva
        static bool BuscarRecursivo(string[] catalogo, string titulo, int indice)
        {
            // si llego al final del arreglo sin encontrar el título
            if (indice >= catalogo.Length)
                return false;

            // Comparo el título actual ignorando mayúsculas y minúsculas
            if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;

            // Si no lo encuentro, llamo recursivamente al siguiente índice
            return BuscarRecursivo(catalogo, titulo, indice + 1);
        }
    }
}
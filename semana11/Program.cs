using System; // Importa funcionalidades básicas como entrada/salida por consola
using System.Collections.Generic; 

class Traductor // Define la clase principal del programa
{
    // Diccionario que almacena pares de palabras español-inglés
    static Dictionary<string, string> diccionario = new Dictionary<string, string>();

    static void Main() // Método principal donde inicia la ejecución
    {
        InicializarDiccionario(); // Carga las palabras base al diccionario

        int opcion; // Variable para almacenar la opción del menú

        // Bucle principal del menú interactivo
        do
        {
            MostrarMenu(); // Muestra las opciones disponibles
            Console.Write("Seleccione una opción: "); // Solicita al usuario una opción

            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                continue; // Vuelve al inicio del bucle
            }

            // Ejecuta la acción correspondiente según la opción elegida
            switch (opcion)
            {
                case 1:
                    TraducirFrase(); // Traduce una frase ingresada por el usuario
                    break;
                case 2:
                    AgregarPalabra(); // Permite agregar una nueva palabra al diccionario
                    break;
                case 0:
                    Console.WriteLine("¡Hasta pronto!"); // Finaliza el programa
                    break;
                default:
                    Console.WriteLine("Opción no reconocida."); // Maneja opciones inválidas
                    break;
            }
        } while (opcion != 0); // Repite el menú hasta que el usuario elija salir
    }

    // Método que carga las palabras iniciales al diccionario
    static void InicializarDiccionario()
    {
        diccionario["tiempo"] = "time";
        diccionario["persona"] = "person";
        diccionario["año"] = "year";
        diccionario["camino"] = "way";
        diccionario["forma"] = "way";
        diccionario["día"] = "day";
        diccionario["cosa"] = "thing";
        diccionario["hombre"] = "man";
        diccionario["mundo"] = "world";
        diccionario["vida"] = "life";
        diccionario["mano"] = "hand";
        diccionario["parte"] = "part";
        diccionario["niño"] = "child";
        diccionario["niña"] = "child";
        diccionario["ojo"] = "eye";
        diccionario["mujer"] = "woman";
        diccionario["lugar"] = "place";
        diccionario["trabajo"] = "work";
        diccionario["semana"] = "week";
        diccionario["caso"] = "case";
        diccionario["punto"] = "point";
        diccionario["tema"] = "point";
        diccionario["gobierno"] = "government";
        diccionario["empresa"] = "company";
        diccionario["compañía"] = "company";
    }

    // Muestra el menú principal en pantalla
    static void MostrarMenu()
    {
        Console.WriteLine("\n==================== MENÚ ====================");
        Console.WriteLine("1. Traducir una frase");
        Console.WriteLine("2. Agregar palabras al diccionario");
        Console.WriteLine("0. Salir");
    }

    // Traduce una frase ingresada por el usuario
    static void TraducirFrase()
    {
        Console.Write("Ingrese una frase en español: ");
        string frase = Console.ReadLine().ToLower(); // Convierte la frase a minúsculas

        string[] palabras = frase.Split(' '); // Divide la frase en palabras usando espacios

        Console.Write("Traducción parcial: ");
        foreach (string palabra in palabras) // Recorre cada palabra
        {
            // Elimina signos de puntuación comunes
            string limpia = palabra.Trim(new char[] { '.', ',', ';', ':', '!', '?' });

            // Busca la traducción en el diccionario; si no existe, usa la palabra original
            string traduccion = diccionario.ContainsKey(limpia) ? diccionario[limpia] : palabra;

            Console.Write(traduccion + " "); // Imprime la palabra traducida (o original)
        }
        Console.WriteLine(); // Salto de línea al final
    }

    // Permite al usuario agregar nuevas palabras al diccionario
    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string esp = Console.ReadLine().ToLower(); // Convierte a minúsculas

        Console.Write("Ingrese su traducción al inglés: ");
        string ing = Console.ReadLine().ToLower(); // Convierte a minúsculas

        // Verifica si la palabra ya existe en el diccionario
        if (!diccionario.ContainsKey(esp))
        {
            diccionario[esp] = ing; // Agrega la nueva palabra
            Console.WriteLine("Palabra agregada exitosamente.");
        }
        else
        {
            // Si ya existe, actualiza su traducción
            Console.WriteLine("La palabra ya existe. Se ha actualizado su traducción.");
            diccionario[esp] = ing;
        }
    }
}
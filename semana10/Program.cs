using System;                         
using System.Collections.Generic;      
using System.Linq;                     

namespace VacunacionCovid              // Define un espacio de nombres para organizar el código.
{
    class Program                      // Clase principal del programa.
    {
        static void Main(string[] args)    // Método principal
        {
            // Universo: 500 ciudadanos
            List<Ciudadano> universo = new List<Ciudadano>();         // Crea una lista vacía para almacenar los ciudadanos.
            for (int i = 1; i <= 500; i++)                             // Bucle que se repite 500 veces.
                universo.Add(new Ciudadano { Nombre = $"Ciudadano {i}" });  // Agrega ciudadanos con nombres únicos.

            // Conjunto A: Pfizer (75 aleatorios)
            var pfizer = universo                                     // Selecciona aleatoriamente 75 ciudadanos.
                .OrderBy(x => Guid.NewGuid())                         // Mezcla la lista usando GUIDs aleatorios.
                .Take(75)                                             // Toma los primeros 75 de la lista mezclada.
                .ToList();                                            // Convierte el resultado en una lista.
            foreach (var c in pfizer) c.Pfizer = true;                // Marca que recibieron la vacuna Pfizer.

            // Conjunto B: AstraZeneca (75 aleatorios)
            var astra = universo                                      // Selecciona aleatoriamente otros 75 ciudadanos.
                .OrderBy(x => Guid.NewGuid())                         // Mezcla la lista nuevamente.
                .Take(75)                                             // Toma los primeros 75.
                .ToList();                                            // Convierte el resultado en una lista.
            foreach (var c in astra) c.AstraZeneca = true;            // Marca que recibieron la vacuna AstraZeneca.

            // ¬A ∩ ¬B: No vacunados
            var noVacunados = universo                                // Filtra ciudadanos sin ninguna vacuna.
                .Where(c => !c.Pfizer && !c.AstraZeneca)
                .ToList();

            // A ∩ B: Ambas dosis
            var ambasDosis = universo                                 // Filtra ciudadanos con ambas vacunas.
                .Where(c => c.Pfizer && c.AstraZeneca)
                .ToList();

            // A - B: Solo Pfizer
            var soloPfizer = universo                                 // Filtra ciudadanos solo con Pfizer.
                .Where(c => c.Pfizer && !c.AstraZeneca)
                .ToList();

            // B - A: Solo AstraZeneca
            var soloAstraZeneca = universo                            // Filtra ciudadanos solo con AstraZeneca.
                .Where(c => c.AstraZeneca && !c.Pfizer)
                .ToList();

            // Mostrar resultados
            Mostrar("Ciudadanos NO vacunados", noVacunados);          // Muestra listado de no vacunados.
            Mostrar("Ciudadanos con ambas dosis", ambasDosis);        // Muestra listado de vacunados con ambas dosis.
            Mostrar("Ciudadanos solo con Pfizer", soloPfizer);        // Muestra listado de vacunados solo con Pfizer.
            Mostrar("Ciudadanos solo con AstraZeneca", soloAstraZeneca); // Muestra listado de vacunados solo con AstraZeneca.
        }

        static void Mostrar(string titulo, List<Ciudadano> lista)     // Método auxiliar para mostrar listados.
        {
            Console.WriteLine($"\n{titulo} ({lista.Count}):");        // Imprime el título y la cantidad de ciudadanos.
            foreach (var c in lista)                                  // Recorre cada ciudadano en la lista.
                Console.WriteLine($"- {c.Nombre}");                   // Imprime el nombre del ciudadano.
        }
    }
}
using System;
using System.Collections.Generic;

namespace SEMANA_7
{
    public class TorresHanoi
    {
        // Creamos 3 pilas que representan las 3 torres
        static Stack<int> torreA = new Stack<int>(); // Torre origen (izquierda)
        static Stack<int> torreB = new Stack<int>(); // Torre auxiliar (centro)
        static Stack<int> torreC = new Stack<int>(); // Torre destino (derecha)

        public static void EjecutarTorresHanoi()
        {
            // Limpiar las torres antes de empezar (por si se ejecuta múltiples veces)
            torreA.Clear();
            torreB.Clear();
            torreC.Clear();

            Console.Write("¿Cuántos discos quiere usar? ");
            int numDiscos = int.Parse(Console.ReadLine());

            // Inicializamos la torre A con los discos (el más grande abajo)
            for (int i = numDiscos; i >= 1; i--)
            {
                torreA.Push(i);
            }

            Console.WriteLine("\nEstado inicial:");
            MostrarTorres();

            Console.WriteLine("\nResolviendo Torres de Hanoi...\n");
            Hanoi(numDiscos, torreA, torreC, torreB);

            Console.WriteLine("\n¡Problema resuelto!");
        }

        // Método recursivo que resuelve las Torres de Hanoi
        static void Hanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
        {
            if (n == 1)
            {
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {NombreTorre(origen)} a {NombreTorre(destino)}");
                MostrarTorres();
                Console.WriteLine();
            }
            else
            {
                Hanoi(n - 1, origen, auxiliar, destino);
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {NombreTorre(origen)} a {NombreTorre(destino)}");
                MostrarTorres();
                Console.WriteLine();
                Hanoi(n - 1, auxiliar, destino, origen);
            }
        }

        // Método que devuelve el nombre de la torre
        static string NombreTorre(Stack<int> torre)
        {
            if (torre == torreA) return "Torre A";
            if (torre == torreB) return "Torre B";
            return "Torre C";
        }

        // Método que muestra el estado actual de las 3 torres
        static void MostrarTorres()
        {
            Console.WriteLine("Torre A: " + string.Join(", ", torreA));
            Console.WriteLine("Torre B: " + string.Join(", ", torreB));
            Console.WriteLine("Torre C: " + string.Join(", ", torreC));
        }
    }
}
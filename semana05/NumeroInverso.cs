using System;
using System.Collections.Generic;

namespace SEMANA_5
{
    public class NumeroInverso
    {
        private List<int> numeros;

        public NumeroInverso()
        {
            numeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }
        }

        public void MostrarInverso()
        {
            numeros.Reverse();

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.Write(numeros[i]);
                if (i < numeros.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
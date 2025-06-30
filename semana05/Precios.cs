using System;
using System.Collections.Generic;
using System.Linq;

namespace SEMANA_5
{
    public class Precios
    {
        private List<int> listaPrecios;

        public Precios()
        {
            listaPrecios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
        }

        public void MostrarMayorYMenor()
        {
            int mayor = listaPrecios.Max();
            int menor = listaPrecios.Min();

            Console.WriteLine("El precio mayor es: " + mayor);
            Console.WriteLine("El precio menor es: " + menor);
        }
    }
}
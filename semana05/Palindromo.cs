using System;

namespace SEMANA_5
{
    public class Palindromo
    {
        private string palabra;

        public void PedirPalabra()
        {
            Console.Write("Ingresa una palabra: ");
            palabra = Console.ReadLine();
        }

        public void VerificarPalindromo()
        {
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string invertida = new string(caracteres);

            if (palabra.Equals(invertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Sí, es un palíndromo.");
            }
            else
            {
                Console.WriteLine("No, no es un palíndromo.");
            }
        }
    }
}
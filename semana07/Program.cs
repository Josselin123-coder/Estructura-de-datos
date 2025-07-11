using System;
using System.Collections.Generic;

namespace SEMANA_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Verificador de Paréntesis Balanceados");
            Console.WriteLine("2. Torres de Hanoi");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    Verificador.EjecutarVerificador();
                    break;
                case "2":
                    TorresHanoi.EjecutarTorresHanoi();
                    break;
                case "3":
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            
            Console.ReadKey();
        }
    }
    
    public class Verificador
    {
        public static void EjecutarVerificador() // Cambiamos Main por EjecutarVerificador
        {
            Console.WriteLine("Ingrese una expresión matemática:");
            string expresion = Console.ReadLine();
            
            if (EstaBalanceada(expresion))
            {
                Console.WriteLine("Formula balanceada");
            }
            else
            {
                Console.WriteLine("Formula NO balanceada");
            }
        }
        
        // Método que verifica si los paréntesis están balanceados
        public static bool EstaBalanceada(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            
            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];
                
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0)
                    {
                        return false;
                    }
                    
                    char apertura = pila.Pop();
                    
                    if ((apertura == '(' && c != ')') ||
                        (apertura == '{' && c != '}') ||
                        (apertura == '[' && c != ']'))
                    {
                        return false;
                    }
                }
            }
            
            return pila.Count == 0;
        }
    }
}
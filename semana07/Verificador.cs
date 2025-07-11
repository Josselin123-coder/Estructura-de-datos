using System;
using System.Collections.Generic;

namespace SEMANA_7
{
    public class Verificador
    {
        public static void EjecutarVerificador()
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
using System;

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
}
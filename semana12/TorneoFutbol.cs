using System;
using System.Collections.Generic;

public class TorneoFutbol
{
    // Declaré un diccionario donde cada equipo se asocia a un conjunto de jugadores
    Dictionary<string, HashSet<string>> equipos = new Dictionary<string, HashSet<string>>();

    public void MostrarMenu()
    {
        int opcion;
        do
        {
            // Mostré el menú principal en consola
            Console.WriteLine("\n MENÚ TORNEO DE FÚTBOL");
            Console.WriteLine("1. Registrar equipo");
            Console.WriteLine("2. Registrar jugador");
            Console.WriteLine("3. Mostrar equipos y jugadores");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");

            // Leí la opción del usuario
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Opción inválida. Intenta de nuevo.");
                continue;
            }

            // Ejecuté la acción correspondiente
            switch (opcion)
            {
                case 1:
                    RegistrarEquipo();
                    break;
                case 2:
                    RegistrarJugador();
                    break;
                case 3:
                    MostrarEquiposYJugadores();
                    break;
                case 4:
                    Console.WriteLine(" Gracias por usar el sistema. ¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine(" Opción no válida.");
                    break;
            }

        } while (opcion != 4);
    }

    public void RegistrarEquipo()
    {
        Console.Write(" Ingresa el nombre del equipo: ");
        string nombreEquipo = Console.ReadLine();

        // Verifiqué si el equipo ya existe
        if (!equipos.ContainsKey(nombreEquipo))
        {
            equipos[nombreEquipo] = new HashSet<string>();
            Console.WriteLine($" Registré el equipo '{nombreEquipo}'.");
        }
        else
        {
            Console.WriteLine($" El equipo '{nombreEquipo}' ya está registrado.");
        }
    }

    public void RegistrarJugador()
    {
        Console.Write(" Ingresa el nombre del equipo: ");
        string nombreEquipo = Console.ReadLine();

        // Verifiqué que el equipo exista antes de agregar jugadores
        if (!equipos.ContainsKey(nombreEquipo))
        {
            Console.WriteLine($" El equipo '{nombreEquipo}' no existe. Regístralo primero.");
            return;
        }

        Console.Write("👤 Ingresa el nombre del jugador: ");
        string nombreJugador = Console.ReadLine();

        // Intenté agregar el jugador al conjunto del equipo
        bool agregado = equipos[nombreEquipo].Add(nombreJugador);
        if (agregado)
            Console.WriteLine($" Agregué al jugador '{nombreJugador}' al equipo '{nombreEquipo}'.");
        else
            Console.WriteLine($" El jugador '{nombreJugador}' ya está registrado en ese equipo.");
    }

    public void MostrarEquiposYJugadores()
    {
        Console.WriteLine("\n Equipos y sus jugadores:");
        foreach (var equipo in equipos)
        {
            Console.WriteLine($" Equipo: {equipo.Key}");
            foreach (var jugador in equipo.Value)
            {
                Console.WriteLine($"   - {jugador}");
            }
        }
    }
}
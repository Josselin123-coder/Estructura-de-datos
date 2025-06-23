using System;

public class Program
{
    // Declaro la clase principal Program donde ejecutaré mi programa
    
    public static void Main()
    {
        // Defino el método Main que será el punto de entrada de mi aplicación
        
        AgendaTelefonica agenda = new AgendaTelefonica(100);
        // Instancio mi objeto agenda con capacidad para almacenar 100 contactos
        
        int opcion;
        // Declaro una variable entera para almacenar la opción que elija el usuario
        
        do
        {
            // Inicio un bucle do-while que se ejecutará al menos una vez
            
            Console.WriteLine("\n=== AGENDA TELEFÓNICA ===");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar todos los contactos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            opcion = int.Parse(Console.ReadLine() ?? "0");
            switch (opcion)
            {
                // Evalúo la opción seleccionada usando una estructura switch
                
                case 1:
                   Console.Write("Ingrese el nombre: ");
                    // Le pido al usuario que ingrese el nombre del contacto
                    
                    string nombre = Console.ReadLine() ?? "";
                    // Leo el nombre completo, si es null lo convierto a string vacío
                    
                    Console.Write("Ingrese el teléfono: ");
                    // Le pido al usuario que ingrese el número de teléfono
                    
                    string telefono = Console.ReadLine() ?? "";
                    // Leo el teléfono, si es null lo convierto a string vacío
                    
                    Console.Write("Ingrese el correo: ");
                    // Le pido al usuario que ingrese el correo electrónico
                    
                    string correo = Console.ReadLine() ?? "";
                    // Leo el correo, si es null lo convierto a string vacío
                    
                    if (agenda.AgregarContacto(nombre, telefono, correo))
                    {
                        Console.WriteLine("Contacto agregado exitosamente.");
                        // Si se agregó correctamente, muestro mensaje de éxito
                    }
                    else
                    {
                        Console.WriteLine("No se pudo agregar el contacto. Agenda llena.");
                        // Informo al usuario que la agenda está llena
                    }
                    break;
                    // Salgo del case 1
                    
                case 2:
                    // Si el usuario eligió la opción 2, muestro todos los contactos
                    
                    Console.WriteLine("\n=== LISTA DE CONTACTOS ===");
                    // Muestro el encabezado de la lista de contactos
                    
                    agenda.MostrarContactos();
                    // Llamo al método para mostrar todos los contactos almacenados
                    
                    break;
                    // Salgo del case 2
                    
                case 0:
                    // Si el usuario eligió la opción 0, preparo la salida del programa
                    
                    Console.WriteLine("¡Gracias por usar la Agenda Telefónica!");
                    // Muestro un mensaje de despedida al usuario
                    
                    break;
                    
                default:
                    // Si el usuario ingresó una opción que no existe
                    
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    // Informo que la opción no es válida y puede intentar de nuevo
                    
                    break;
                    // Salgo del default
            }
            
        } while (opcion != 0);
        // Continúo el bucle mientras la opción no sea 0 
        
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}

using System;

public class AgendaTelefonica
{
    // Declaro la clase pública AgendaTelefonica que manejará mi colección de contactos
    
    // Atributos
    
    
    public Contacto [] contactos;
    // Declaro un arreglo público 
    
    public int totalContactos;
    // Declaro una variable pública entera para llevar el conteo de cuántos contactos he agregado
    
    // Constructor
    
    public AgendaTelefonica(int capacidad)
    {
        // Defino el constructor público 
AgendaTelefonica
        
        contactos = new Contacto[capacidad];
        // Inicializo mi arreglo de contactos con el tamaño especificado en el parámetro capacidad
        
        totalContactos = 0;
        // Inicializo el contador de contactos en cero porque aún no he agregado ningún contacto
    }

    
    // Declaro el comentario para identificar la sección del método agregar contactos
    
    public bool AgregarContacto(string nombre, string telefono, string correo)
    {
        
        
        if (totalContactos >= contactos.Length)
        {
            // Verifico si ya alcancé la capacidad máxima de mi agenda
            return false;
            // Si la agenda está llena, retorno false indicando que no pude agregar el contacto
        }
        else
        {
            // Si aún tengo espacio disponible en mi agenda
            
            contactos[totalContactos] = new Contacto(nombre, telefono, correo);
            // Creo un nuevo objeto Contacto
            
            totalContactos = totalContactos + 1;
            // Incremento mi contador en 1 para reflejar que agregué un contacto más
            return true;
            // Retorno true indicando que agregué exitosamente el contacto
        }
        
    }
    
    // Mostrar contactos
    
    
    public void MostrarContactos()
    {
        
        if (totalContactos == 0)
        {
            // Verifico si no tengo ningún contacto registrado en mi agenda
            
            Console.WriteLine("No tienes registros");
            // Si no hay contactos, informo al usuario que la agenda está vacía
        }
        else
        {
            // Si tengo al menos un contacto registrado
            
            for (int i = 0; i < totalContactos; i++)
            {
                // Inicio un bucle for que recorrerá desde 0 hasta el número total de contactos
                
                Contacto c = contactos[i];
                // Obtengo el contacto en la posición i y lo asigno a una variable temporal c

                
                Console.WriteLine("DATOS DEL CONTACTO " + i);
                // Muestro un encabezado indicando el número del contacto que estoy mostrando
                
                Console.WriteLine("Nombre: " + c.Nombre);
                
                Console.WriteLine("Teléfono: " + c.Telefono);
                
                Console.WriteLine("Correo: " + c.Correo);

                
                Console.WriteLine(); // Línea en blanco para separar contactos
            }
        }
    }
    
}

//CLASE 3: Program.cs (CLASE PRINCIPAL) 
using System;

public class Program
{
    // Declaro la clase principal Program donde ejecutaré mi programa
    
    public static void Main(string[] args)
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
            
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                // Evalúo la opción seleccionada usando una estructura switch
                
                case 1:
                    // Si el usuario eligió la opción 1, ejecuto el código para agregar contacto
                    
                    Console.Write("Ingrese el nombre: ");
                    // Le pido al usuario que ingrese el nombre del contacto
                    
                    string nombre = Console.ReadLine();
                    // Leo el nombre completo y lo almaceno en la variable nombre
                    
                    Console.Write("Ingrese el teléfono: ");
                    // Le pido al usuario que ingrese el número de teléfono
                    
                    string telefono = Console.ReadLine();
                    // Leo el teléfono y lo almaceno en la variable telefono
                    
                    Console.Write("Ingrese el correo: ");
                    // Le pido al usuario que ingrese el correo electrónico
                    
                    string correo = Console.ReadLine();
                    // Leo el correo y lo almaceno en la variable correo
                    
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
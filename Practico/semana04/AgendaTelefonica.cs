using System;

public class AgendaTelefonica
{
    // Declaro la clase pública AgendaTelefonica que manejará mi colección de contactos
    
    // Atributos
    public Contacto[] contactos;
    // Declaro un arreglo público 
    
    public int totalContactos;
    // Declaro una variable pública entera para llevar el conteo de cuántos contactos he agregado
    
    // Constructor
    public AgendaTelefonica(int capacidad)
    {
        // Defino el constructor público AgendaTelefonica
        
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
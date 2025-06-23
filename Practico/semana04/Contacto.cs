using System;

public class Contacto
{
    // Propiedades públicas para almacenar la información del contacto
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    
    // Constructor que inicializa un contacto con los datos proporcionados
    public Contacto(string nombre, string telefono, string correo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Correo = correo;
    }
}
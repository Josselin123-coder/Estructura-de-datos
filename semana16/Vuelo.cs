public class Vuelo
{
    // Declaro una propiedad pública llamada 'Destino' que almacenará el lugar al que se dirige el vuelo.
    public string Destino { get; set; }

    // Declaro una propiedad pública llamada 'Precio' que representará el costo del vuelo en formato entero.
    public int Precio { get; set; }

    // Creo un constructor que recibe dos parámetros: el destino y el precio del vuelo.
    public Vuelo(string destino, int precio)
    {
        // Asigno el valor recibido en el parámetro 'destino' a la propiedad 'Destino' de la clase.
        Destino = destino;

        // Asigno el valor recibido en el parámetro 'precio' a la propiedad 'Precio' de la clase.
        Precio = precio;
    }
}
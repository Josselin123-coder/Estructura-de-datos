using System;

// Defino la clase principal del programa, que contiene el punto de entrada 'Main'.
class Program
{
    // Este es el método principal que se ejecuta al iniciar el programa.
    static void Main()
    {
        // Creo una instancia del grafo de vuelos, que me permitirá registrar rutas y buscar caminos.
        var grafo = new GrafoVuelos();

        // Simulo una base de datos ficticia agregando rutas entre ciudades con sus respectivos precios.
        grafo.AgregarRuta("Quito", "Bogotá", 200);           
        grafo.AgregarRuta("Quito", "Lima", 180);            
        grafo.AgregarRuta("Lima", "Santiago", 150);          
        grafo.AgregarRuta("Bogotá", "Santiago", 300);       
        grafo.AgregarRuta("Bogotá", "Buenos Aires", 400);    
        grafo.AgregarRuta("Santiago", "Buenos Aires", 100);  

        // Imprimo un mensaje indicando que voy a buscar la ruta más barata entre Quito y Buenos Aires.
        Console.WriteLine("Buscando vuelo más barato de Quito a Brasil...");

        // Llamo al método que calcula e imprime la ruta más económica entre las dos ciudades.
        grafo.BuscarRutaMasBarata("Quito", "Brasil");
    }
}
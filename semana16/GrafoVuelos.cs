using System;
using System.Collections.Generic;

// Defino la clase principal 
public class GrafoVuelos
{
    // Declaro un diccionario privado llamado 'rutas', donde cada ciudad origen se asocia a una lista de vuelos disponibles.
    private Dictionary<string, List<Vuelo>> rutas = new Dictionary<string, List<Vuelo>>();

    // Este método me permite agregar una nueva ruta de vuelo entre dos ciudades con su respectivo precio.
    public void AgregarRuta(string origen, string destino, int precio)
    {
        // Verifico si la ciudad origen ya tiene rutas registradas y si no, inicializo su lista de vuelos.
        if (!rutas.ContainsKey(origen))
            rutas[origen] = new List<Vuelo>();

        // Agrego un nuevo vuelo desde la ciudad origen hacia el destino con el precio indicado.
        rutas[origen].Add(new Vuelo(destino, precio));
    }

    // Este método busca la ruta más barata entre dos ciudades usando una variante del algoritmo de Dijkstra.
    public void BuscarRutaMasBarata(string origen, string destino)
    {
        // Inicializo un diccionario para guardar el costo mínimo hacia cada ciudad.
        var costos = new Dictionary<string, int>();

        // Creo un conjunto para registrar las ciudades que ya he visitado.
        var visitados = new HashSet<string>();

        // Este diccionario me ayuda a reconstruir el camino más barato al final.
        var anteriores = new Dictionary<string, string>();

        // Utilizo una cola de prioridad para procesar las ciudades en orden de menor costo acumulado.
        var cola = new PriorityQueue<string, int>();

         //  Recolectar todas las ciudades (origen y destino)
        var todasLasCiudades = new HashSet<string>();
        foreach (var origenRuta in rutas.Keys)
        {
            todasLasCiudades.Add(origenRuta);
            foreach (var vuelo in rutas[origenRuta])
                todasLasCiudades.Add(vuelo.Destino);
        }

        // Inicializar costos
        foreach (var ciudad in todasLasCiudades)
            costos[ciudad] = int.MaxValue;

        // Establezco el costo inicial de la ciudad de origen como cero.
        costos[origen] = 0;
        cola.Enqueue(origen, 0);

        // Comienzo a procesar las ciudades en la cola.
        while (cola.Count > 0)
        {
            // Extraigo la ciudad con menor costo acumulado.
            var actual = cola.Dequeue();

            // Si ya la visité, la ignoro.
            if (visitados.Contains(actual)) continue;
            visitados.Add(actual);

            // Si no hay vuelos desde esta ciudad, paso a la siguiente.
            if (!rutas.ContainsKey(actual)) continue;

            // Recorro todos los vuelos disponibles desde la ciudad actual.
            foreach (var vuelo in rutas[actual])
            {
                // Calculo el nuevo costo acumulado para llegar al destino del vuelo.
                int nuevoCosto = costos[actual] + vuelo.Precio;

                // Si el nuevo costo es menor al que tenía registrado, actualizo la información.
                if (nuevoCosto < costos[vuelo.Destino])
                {
                    costos[vuelo.Destino] = nuevoCosto;
                    anteriores[vuelo.Destino] = actual;
                    cola.Enqueue(vuelo.Destino, nuevoCosto);
                }
            }
        }

        // Si no encontré una ruta válida, informo al usuario.
        if (!costos.ContainsKey(destino) || costos[destino] == int.MaxValue)
        {
            Console.WriteLine("No hay ruta disponible.");
            return;
        }

        // Si encontré una ruta, imprimo el costo mínimo y reconstruyo el camino.
        Console.WriteLine($"Costo mínimo de {origen} a {destino}: ${costos[destino]}");
        Console.Write("Ruta: ");
        ImprimirRuta(anteriores, destino);
        Console.WriteLine(destino);
    }

    // Este método imprime la ruta más barata desde el origen hasta el destino, usando recursividad.
    private void ImprimirRuta(Dictionary<string, string> anteriores, string destino)
    {
        // Si tengo registrada una ciudad anterior al destino, imprimo primero esa parte del camino.
        if (anteriores.ContainsKey(destino))
        {
            ImprimirRuta(anteriores, anteriores[destino]);
            Console.Write(anteriores[destino] + " -> ");
        }
    }
}
using System;

namespace semana06
{
    /// <summary>
    /// Clase para implementar una lista enlazada simple con funcionalidad de búsqueda
    /// Versión con Nullable Reference Types habilitados
    /// </summary>
    public class Busqueda
    {
        // Creo una clase interna Nodo para representar cada elemento de la lista
        class Nodo
        {
            public int dato;           // Aquí guardo el valor del nodo
            public Nodo? siguiente;    // Referencia al siguiente nodo (puede ser null)
            
            public Nodo(int dato)
            {
                this.dato = dato;       // Asigno el dato al nodo
                this.siguiente = null;  // Inicializo la referencia al siguiente como nula
            }
        }
        
        private Nodo? cabeza = null; // Inicializo la cabeza de la lista (puede ser null)
        
        // Método para agregar un nuevo dato a la lista
        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato); // Creo un nuevo nodo con el valor ingresado
            if (cabeza == null)
            {
                cabeza = nuevo; // Si la lista está vacía, este nodo será la cabeza
            }
            else
            {
                Nodo actual = cabeza; // Inicio desde la cabeza
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente; // Recorro la lista hasta el último nodo
                }
                actual.siguiente = nuevo; // Conecto el nuevo nodo al final
            }
        }
        
        // Método para buscar cuántas veces aparece un valor en la lista
        public int Buscar(int valor)
        {
            int veces = 0;           // Inicializo el contador de apariciones
            Nodo? actual = cabeza;    // Inicio el recorrido desde la cabeza
            
            while (actual != null)
            {
                if (actual.dato == valor)
                {
                    veces++; // Si el valor coincide, incremento el contador
                }
                actual = actual.siguiente; // Paso al siguiente nodo
            }
            
            if (veces == 0)
            {
                // Si no se encontró el valor, informo al usuario
                Console.WriteLine($"El dato {valor} no fue encontrado en la lista.");
            }
            
            return veces; // Retorno el número de veces que apareció el valor
        }
        
        // Método para probar la clase (sin Main)
        public void PruebasBusqueda()
        {
            Console.WriteLine("=== Pruebas de Búsqueda ===");
            
            // Agrego algunos elementos a la lista
            this.Agregar(3);
            this.Agregar(7);
            this.Agregar(3);
            this.Agregar(5);
            
            // Realizo una búsqueda de un valor presente
            int resultado = this.Buscar(3);
            Console.WriteLine($"El número 3 aparece {resultado} veces en la lista.");
            
            // Realizo una búsqueda de un valor que no está
            this.Buscar(9);
        }
    }
}
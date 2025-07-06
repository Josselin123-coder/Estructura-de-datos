using System;

namespace semana06
{
    /// <summary>
    /// Clase para implementar una lista enlazada simple con funcionalidad de inversión
    /// </summary>
    public class Lista
    {
        // Defino la clase Nodo para representar cada elemento de la lista
        class Nodo
        {
            public int dato;           // Aquí guardo el valor del nodo
            public Nodo? siguiente;    // Referencia al siguiente nodo

            public Nodo(int dato)
            {
                this.dato = dato;       // Inicializo el dato del nodo
                this.siguiente = null;
            }
        }

        private Nodo? cabeza; // Este será el primer nodo de la lista

        // Método para agregar un nuevo nodo al final de la lista
        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato); // Creo el nodo nuevo con el dato dado
            if (cabeza == null)
            {
                cabeza = nuevo; // Si la lista está vacía, el nuevo será la cabeza
            }
            else
            {
                Nodo temp = cabeza; // Comienzo desde la cabeza
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente; // Recorro la lista hasta el último nodo
                }
                temp.siguiente = nuevo; // Conecto el último nodo con el nuevo
            }
        }

        // Método para invertir la lista
        public void Invertir()
        {
            Nodo? anterior = null;      // El nodo anterior empieza como null
            Nodo? actual = cabeza;      // Comienzo desde la cabeza
            Nodo? siguiente = null;     // Nodo para guardar el siguiente temporalmente

            while (actual != null)               // Recorro mientras haya nodos
            {
                siguiente = actual.siguiente;      // Guardo el siguiente nodo
                actual.siguiente = anterior;       // Invierto el enlace del nodo actual
                anterior = actual;                 // Avanzo el nodo anterior
                actual = siguiente;                // Avanzo al siguiente nodo
            }

            cabeza = anterior;
        }

        // Método para mostrar la lista
        public void Mostrar()
        {
            Nodo? temp = cabeza; // Comienzo desde la cabeza
            while (temp != null)
            {
                Console.Write(temp.dato + " -> "); // Muestro cada dato
                temp = temp.siguiente;
            }
            Console.WriteLine("null"); // Indico el fin de la lista
        }

        // Método para probar la clase (sin Main)
        public void PruebasLista()
        {
            Console.WriteLine("=== Pruebas de Lista ===");

            // Agrego elementos
            this.Agregar(10);
            this.Agregar(20);
            this.Agregar(30);
            this.Agregar(40);

            // Muestro la lista original
            Console.WriteLine("Lista original:");
            this.Mostrar();

            // Invierto la lista
            this.Invertir();

            // Muestro la lista invertida
            Console.WriteLine("Lista invertida:");
            this.Mostrar();
        }
    }
}
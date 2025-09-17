using System;

// Primero defino la clase Nodo, que representa cada elemento del árbol.
// Cada nodo tiene un valor entero y dos referencias: una al hijo izquierdo y otra al derecho.

   public class Nodo {
    public int Valor;
    public Nodo? Izquierdo;
    public Nodo? Derecho;

    public Nodo(int valor) {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}


public class ArbolBinario {
    private Nodo? raiz; // Este será el punto de entrada del árbol.

    // Método público para insertar un nuevo valor en el árbol.
    public void Insertar(int valor) {
        raiz = InsertarRecursivo(raiz, valor); // Llamo al método recursivo para ubicar el valor.
    }

    // Inserto el valor respetando la lógica del árbol binario de búsqueda.
    private Nodo InsertarRecursivo(Nodo actual, int valor) {
        if (actual == null) return new Nodo(valor); // Si no hay nodo, creo uno nuevo.
        if (valor < actual.Valor)
            actual.Izquierdo = InsertarRecursivo(actual.Izquierdo, valor); // Si es menor, va a la izquierda.
        else if (valor > actual.Valor)
            actual.Derecho = InsertarRecursivo(actual.Derecho, valor); // Si es mayor, va a la derecha.
        return actual; // Retorno el nodo actualizado.
    }

    // Método para recorrer el árbol en inorden: izquierda → raíz → derecha.
    public void Inorden() {
        Console.Write("Inorden: ");
        InordenRecursivo(raiz);
        Console.WriteLine();
    }

    private void InordenRecursivo(Nodo nodo) {
        if (nodo != null) {
            InordenRecursivo(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            InordenRecursivo(nodo.Derecho);
        }
    }

    // Recorrido preorden: raíz → izquierda → derecha.
    public void Preorden() {
        Console.Write("Preorden: ");
        PreordenRecursivo(raiz);
        Console.WriteLine();
    }

    private void PreordenRecursivo(Nodo nodo) {
        if (nodo != null) {
            Console.Write(nodo.Valor + " ");
            PreordenRecursivo(nodo.Izquierdo);
            PreordenRecursivo(nodo.Derecho);
        }
    }

    // Recorrido postorden: izquierda → derecha → raíz.
    public void Postorden() {
        Console.Write("Postorden: ");
        PostordenRecursivo(raiz);
        Console.WriteLine();
    }

    private void PostordenRecursivo(Nodo nodo) {
        if (nodo != null) {
            PostordenRecursivo(nodo.Izquierdo);
            PostordenRecursivo(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    // Método para buscar un valor en el árbol.
    public bool Buscar(int valor) {
        return BuscarRecursivo(raiz, valor);
    }

    private bool BuscarRecursivo(Nodo nodo, int valor) {
        if (nodo == null) return false; // Si no hay nodo, el valor no está.
        if (valor == nodo.Valor) return true; // Si coincide, lo encontré.
        return valor < nodo.Valor
            ? BuscarRecursivo(nodo.Izquierdo, valor) // Si es menor, busco a la izquierda.
            : BuscarRecursivo(nodo.Derecho, valor); // Si es mayor, busco a la derecha.
    }

    // Método para eliminar un valor del árbol.
    public void Eliminar(int valor) {
        raiz = EliminarRecursivo(raiz, valor); // Llamo al método recursivo.
    }

    private Nodo EliminarRecursivo(Nodo nodo, int valor) {
        if (nodo == null) return null; // Si no hay nodo, no hay nada que eliminar.

        if (valor < nodo.Valor) {
            nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor); // Busco a la izquierda.
        } else if (valor > nodo.Valor) {
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor); // Busco a la derecha.
        } else {
            // Caso 1: sin hijo izquierdo
            if (nodo.Izquierdo == null) return nodo.Derecho;
            // Caso 2: sin hijo derecho
            if (nodo.Derecho == null) return nodo.Izquierdo;

            // Caso 3: con dos hijos, busco el sucesor (mínimo del subárbol derecho)
            Nodo sucesor = EncontrarMinimo(nodo.Derecho);
            nodo.Valor = sucesor.Valor; // Reemplazo el valor del nodo actual.
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, sucesor.Valor); // Elimino el sucesor.
        }
        return nodo; // Retorno el nodo actualizado.
    }

    // Encuentro el valor mínimo en un subárbol (el más a la izquierda).
    private Nodo EncontrarMinimo(Nodo nodo) {
        while (nodo.Izquierdo != null) nodo = nodo.Izquierdo;
        return nodo;
    }
}
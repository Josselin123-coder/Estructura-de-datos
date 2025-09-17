using System;

class Program {
    static void Main(string[] args) {
        // Instancio el árbol binario que definí previamente.
        ArbolBinario arbol = new ArbolBinario();
        int opcion;

        // Utilizo un ciclo do-while para mantener activo el menú hasta que el usuario decida salir.
        do {
            Console.WriteLine("\n--- MENÚ ÁRBOL BINARIO ---");
            Console.WriteLine("1. Insertar nodo");
            Console.WriteLine("2. Recorrido Inorden");
            Console.WriteLine("3. Recorrido Preorden");
            Console.WriteLine("4. Recorrido Postorden");
            Console.WriteLine("5. Buscar elemento");
            Console.WriteLine("6. Eliminar nodo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); // Capturo la opción ingresada por el usuario.

            // Uso un switch para ejecutar la acción correspondiente según la opción seleccionada.
            switch (opcion) {
                case 1:
                    // Inserto un nuevo valor en el árbol.
                    Console.Write("Ingrese valor a insertar: ");
                    int valorInsertar = int.Parse(Console.ReadLine());
                    arbol.Insertar(valorInsertar);
                    break;
                case 2:
                    // Muestro el recorrido inorden: izquierda → raíz → derecha.
                    arbol.Inorden();
                    break;
                case 3:
                    // Muestro el recorrido preorden: raíz → izquierda → derecha.
                    arbol.Preorden();
                    break;
                case 4:
                    // Muestro el recorrido postorden: izquierda → derecha → raíz.
                    arbol.Postorden();
                    break;
                case 5:
                    // Permito buscar un valor en el árbol.
                    Console.Write("Ingrese valor a buscar: ");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valorBuscar)
                        ? "Elemento encontrado."
                        : "Elemento no encontrado.");
                    break;
                case 6:
                    // Elimino un nodo del árbol si existe.
                    Console.Write("Ingrese valor a eliminar: ");
                    int valorEliminar = int.Parse(Console.ReadLine());
                    arbol.Eliminar(valorEliminar);
                    break;
                case 0:
                    // Finalizo el programa.
                    Console.WriteLine("Programa finalizado.");
                    break;
                default:
                    // Manejo opciones inválidas.
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 0); // El ciclo se repite hasta que el usuario elija salir.
    }
}


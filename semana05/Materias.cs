using System;
using System.Collections.Generic;

namespace SEMANA_5
{
    /// <summary>
    /// Esta clase representa un listado de asignaturas del curso.
    /// </summary>
    public class Materias
    {
        private List<string> asignaturas; // Lista privada para guardar nombres de asignaturas

        // Constructor: inicializo la lista y agrego las materias
        public Materias()
        {
            asignaturas = new List<string>
            {
                "Matematicas",
                "Fisica",
                "Quimica",
                "Historia",
                "Lengua"
            };
        }

        // Método para mostrar las materias en consola
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            foreach (string materia in asignaturas)
            {
                Console.WriteLine("- " + materia);
            }
        }
    }
}
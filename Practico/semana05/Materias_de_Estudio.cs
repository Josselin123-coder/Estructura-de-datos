using System;
using System.Collections.Generic;

namespace SEMANA_5
{
    public class Materias_De_Estudio
    {
        private List<string> materias;

        public Materias_De_Estudio()
        {
            materias = new List<string> {
                "Matematicas", "Fisica", "Quimica", "Historia", "Lengua"
            };
        }

        public void MostrarMaterias()
        {
            foreach (string materia in materias)
            {
                Console.WriteLine("Yo estudio " + materia);
            }
        }
    }
}
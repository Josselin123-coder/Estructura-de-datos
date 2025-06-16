using System;

namespace SEMANA_3
{
    public class Estudiante
    {
        // Campos privados
        private int id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string[] telefonos;
        
        // Constructor
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefonos = telefonos;
        }
        
        // Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Telefonos:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  - " + telefonos[i]);
            }
        }
    }
}
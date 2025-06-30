using System;
using SEMANA_5;

class Program
{
    static void Main(string[] args)
    {
        Palindromo p = new Palindromo();
        p.PedirPalabra();
        p.VerificarPalindromo();

        Console.WriteLine();

        Materias_De_Estudio curso = new Materias_De_Estudio();
        curso.MostrarMaterias();

        Console.WriteLine();

        Precios precios = new Precios();
        precios.MostrarMayorYMenor();

        Console.WriteLine();

        NumeroInverso lista = new NumeroInverso();
        lista.MostrarInverso();

        Materias asignaturasFijas = new Materias();
            asignaturasFijas.MostrarAsignaturas();
    }
}
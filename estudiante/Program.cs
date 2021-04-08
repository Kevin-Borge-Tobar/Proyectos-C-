using System;

namespace DatosEstudiantes
{
    public class Program
    {
        static void Main(String [] args)
        {
            Console.Clear();
            Console.WriteLine("NUMERO DE ESTUDIANTES A INGRESAR:");
            int x = Convert.ToInt32(Console.ReadLine());
            
            String[] Estudiantes = new string[x];
            Estudiantes[] ListaEstudiantes = new Estudiantes[x];
            int j = 0;
            while(j<x)
            {
                Console.Clear();
                Console.WriteLine("Ingrese nombre");
                String nombre = Console.ReadLine();

                Console.WriteLine("Ingrese edad");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el carnet");
                String carnet =Console.ReadLine();

                Console.WriteLine("Indique si está solvente");
                Boolean solvente = Boolean.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese curso");
                String curso = Console.ReadLine();

                Console.WriteLine("Ingrese nota del parcial 1");
                int nota1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese nota del parcial 2");
                int nota2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese nota del examen final");
                int final = Convert.ToInt32(Console.ReadLine());

                Estudiantes estudiante = new Estudiantes(nombre, edad, carnet, solvente, curso, nota1, nota2, final);
                ListaEstudiantes[j] = estudiante;
                j++;
                Console. Clear();
            }
            Console. Clear();
            Console.WriteLine("LISTA DE ESTUDIANTES");
            for(int i=0; i<5; i++)
            {
                Estudiantes estudiante = ListaEstudiantes[i];
                Console.WriteLine("NOMBRE: " +estudiante.nombre);
                Console.WriteLine("CARNET: " +estudiante.carnet);
                Console.WriteLine("EDAD: " +estudiante.edad);
                Console.WriteLine("¿ESTA SOLVENTE?: " +estudiante.solvente);
                Console.WriteLine("CURSO: " +estudiante.curso);
                Console.WriteLine("NOTA DE PARCIAL 1: " +estudiante.nota1);
                Console.WriteLine("NOTA DE PARCIAL 2: "+estudiante.nota2);
                Console.WriteLine("NOTA DE EXAMEN FINAL: "+estudiante.final);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                
            }     
        }
    }
}



using System;

namespace DatosEstudiantes
{
    public class Estudiantes
    {
        public String nombre;
        public int edad;
        public String carnet;
        public Boolean solvente;
        public String curso;
        public int nota1;
        public int nota2;
        public int final;

        public Estudiantes(String nombre, int edad, String carnet, Boolean solvente, String curso, int nota1, int nota2, int final )
        {
            this.nombre= nombre;
            this.edad= edad;
            this.carnet= carnet;
            this.solvente= solvente;
            this.curso = curso;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.final = final;
            
        }  
        
    }
}

using System;

namespace operaciones_basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE OPERACIONES BASICAS");
            Console.WriteLine("Ingrese el Primer Valor a Operar");
            float number1, number2, resultado;
            number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Valor a Operar");
            number2 = float.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("Que Operacion desea Realizar con los Datos  Ingresados");
            Console.WriteLine(" 1.   Suma:");
            Console.WriteLine(" 2.   Resta:");
            Console.WriteLine(" 3.   Multiplicacion:");
            Console.WriteLine(" 4.   Division:");
            Console.WriteLine(" 5.   Modulo:");
            Console.WriteLine(" 6.   Salir:");
            
            string op;
            op = Console.ReadLine();
            switch (op)
            {
                case "1":
                resultado = number1 + number2;
                Console.WriteLine("El Resultado es :   "+ resultado);
                break;

                case "2":
                resultado = number1 - number2;
                Console.WriteLine("El Resultado es :   "+ resultado);
                break;

                case "3":
                resultado = number1 * number2;
                Console.WriteLine("El Resultado es :   "+ resultado);
                break;

                case "4":
                    if(number2 != 0){
                        resultado = number1 / number2;
                        Console.WriteLine("El Resultado es :   "+ resultado);                       
                    }else
                        
                        {
                            Console.WriteLine("Error al Operar Porque es imposible la Division entre 0");
                         
                        }
                break;

                case "5":
                resultado = number1 % number2;
                Console.WriteLine("El Residuo es :   "+ resultado);
                break;

                case "6":
                Console.WriteLine("Saliendo del Programa");
                break;

                default:
                Console.WriteLine("La opcion Ingresada no es Valida");
                break;
            }
        }
    }
}
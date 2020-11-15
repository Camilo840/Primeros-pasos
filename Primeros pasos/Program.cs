using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_pasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos
            int a, b, suma; //declarar una variable tipo entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1} = {2}", a, b, suma);
            

            //tipo de dato: número en coma flotante.
            float sueldo, egreso, total;
            int entero;
            Console.Write("Ingresa el sueldo :");
            sueldo = float.Parse(Console.ReadLine());

            Console.Write("Ingresa los gastosdel trabajador :");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;
            Console.WriteLine("El líquido a recibir es : {0}", total);

           


            //tipo de dato: flotante de doble precisión.
            double x1 = 200.5679;
            Console.WriteLine("Tipo dato :{0}", x1);

            //tipo de dato: Cadena de caracteres (string)
            String nombre;
            Console.Write("Ingresa tu nombre :");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola" + nombre + ",Bienvenido al curso de programacion!");
            //tipo dato booleano(tipo lógico: verdadero/falso) (true/false)
            bool sw;
            sw = a > b;
            Console.WriteLine("El valor de booleano sw: {0}", sw);

            //Pilares fundamentales de la programación estructura.
            //ejecucion de sentencias secuenciales.
            //Uso estructuras repetitivas.
            //uso estructuras selectivas.
            saludos(nombre);
            saludos("José Alcivar");
            saludos("Camilo Cabrera");

            Console.WriteLine();
            Console.WriteLine("LLamada a funcion que devuelve valor");
            Console.WriteLine("Líquido a recibir para Juan {0}", calcularSueldo(300, 200));
            Console.WriteLine("Líquido a recibir para Carlos {0}", calcularSueldo(200, 1000));
            Console.WriteLine("Líquido a recibir para Ana {0}", calcularSueldo(400, 500));

            figura("asterisco");

            //Función, cuadrado de un numero .
            Console.Write("Ingresa el entero :");
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("El cuadrado del numero es : {0}", cuadradoNumero(entero));

            //Función Condicional.
            int numa, numb;
            Console.Write("Ingresa el numero a :");
            numa = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el numero b :");
            numb = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es : {0}", condicional(numa,numb));
            Console.ReadKey();

        }
        //funciones: subprocesos - subprogramas - subrutinas.
        //dividir el codigo en módulos 
        //reutilizar el código.
        //devuelven valores - no devulven valores.
        public static void saludos(String nombre) //parámetro - argumento
        {
            Console.WriteLine("Funciones que nodevuelven valores...");
            Console.WriteLine("HOLA {0}", nombre);


        }
        //funcion que devuelven valores 
        //la función devuelve un tipo de dato.
        static int calcularSueldo(int ingreso, int egreso)
        {
            return (ingreso-egreso);
        }
        //Crear funcion que imprima la siguiente figura
        public static void figura(String asterisco) //parámetro - argumento
        {
         Console.WriteLine("\t     *");
         Console.WriteLine("\t    * *");
         Console.WriteLine("\t   * * *");
         Console.WriteLine("\t  * * * *");
         Console.WriteLine("\t * * * * *");

        }

        //Función cuadrado de un numero.
        static int cuadradoNumero(int numero)
        {
            int num;
            num = (numero * numero);
            return num;
        }

        //función Condicional. (a > b) entonces suma || (a < b) entoces resta.
        static int condicional(int a, int b)
        {
            int resultadoF;
            if (a > b)
            {

                resultadoF = a + b;
            }
           else
            {

                resultadoF = a - b;
            }
            return resultadoF ;
            
        }
    }

}

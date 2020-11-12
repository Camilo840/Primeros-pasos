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
            Console.ReadKey();

            //tipo de dato: número en coma flotante.
            float sueldo, egreso, total;
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

            
            Console.ReadKey();
 
        }
    }
}

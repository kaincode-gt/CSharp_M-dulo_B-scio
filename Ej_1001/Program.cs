using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1001
{
    class Program
    {
        /// <summary>
        /// Ejemplo Básico de Datos introducidos por el usuario.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            PreguntaNombreYEdad();
            Console.Read();
        }
        static void PreguntaNombreYEdad()
        {
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            string output = string.Format("Su nombre es {0} y tiene {1} años de edad", nombre, edad);

            Console.WriteLine(output);
        }
    }
}

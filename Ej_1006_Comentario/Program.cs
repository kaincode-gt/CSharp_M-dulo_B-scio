using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1006_Comentario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("resultado: " + Suma(2, 6));
            Console.WriteLine("producto: " + Producto(5,6));
            Console.Read();
        }

        /// <summary>
        /// Método que suma dos números enteros
        /// </summary>
        /// <param name="a">Sumando 1</param>
        /// <param name="b">Sumando 2</param>
        /// <returns>Resultado de la suma</returns>
        static int Suma(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Método que multiplica dos números enteros
        /// </summary>
        /// <param name="a">Primer factor</param>
        /// <param name="b">Segundo factor</param>
        /// <returns>producto entre los números</returns>
        static int Producto (int a, int b)
        {
            return a * b;
        }
    }
}

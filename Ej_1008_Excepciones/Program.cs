using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1008_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3;
            float b = 5;
           
            
            try
            {
                float c = a / b;
                Console.WriteLine($"resultado de {a} entre {b} es {c}", a, b,c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: No se puede dividir por 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error desconocido");
            }
            finally
            {

            }
            Console.Read();
        }
    }
}

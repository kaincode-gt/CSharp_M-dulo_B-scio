using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1007_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> entero = 5;
            int? entero2 = null;

            entero2 = 4;
            entero = 5;

         //   MostrarNumero(entero); //No se puede convertir int? a int

            if (entero.HasValue)
            {
                MostrarNumero(entero.Value);
            }

            Console.Read();
        }

        static void MostrarNumero(int n)
        {
            Console.WriteLine("Número " + n);
        }
    }
}

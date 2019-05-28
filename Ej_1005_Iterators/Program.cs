using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1005_Iterators
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Con for clásico\n");
            List<string> nombres = new List<string> { "Robert", "Evan", "Ethan", "Alice", "Rose" };

            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            //No permite editar el elemento de la variable usada por el iterador.
            Console.WriteLine("\nCon iterador:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }


            Console.WriteLine("\nCon while:");
            int j = 0;
            while (j<nombres.Count)
            {
                Console.WriteLine(nombres[j]);
                j++;
            }

            Console.WriteLine("");
            while (true)
            {
                Console.Write("Presione S para cancelar: ");
                var respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "s")
                {
                    Console.WriteLine("Saliendo...");
                    break;
                }
            }

            Console.WriteLine("Finalizado");
            Console.Read();
        }
    }
}

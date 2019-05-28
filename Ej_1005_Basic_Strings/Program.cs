using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1005_Basic_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Felipe";
            string frase = "Juan y Jose son amigos";

            //Length

            Console.WriteLine(nombre.Length);
            Console.WriteLine(frase.Length);

            //SubString
            Console.WriteLine(nombre.Substring(3));
            Console.WriteLine(frase.Substring(7,4));

            //StartWitth
            Console.WriteLine(frase.StartsWith("Juan"));
            Console.WriteLine(frase.StartsWith("Jose"));

            //Ends
            Console.WriteLine(frase.EndsWith("amigos"));
            Console.WriteLine(frase.EndsWith("enemigos"));

            //Contains
            Console.WriteLine(frase.Contains("Jose"));
            Console.WriteLine(frase.Contains("Pedro"));

            //indexof
            Console.WriteLine(frase.IndexOf("Jose"));
            Console.WriteLine(frase.IndexOf("Pedro"));

            // + 
            Console.WriteLine(nombre + ", " + frase);

            //Trim
            string ejemploTrim = "   Juan";
            Console.WriteLine(ejemploTrim.Trim());

            //Format
            string ejemploFormat = "Felicidades {0} en tu cumpleaños número {1}!";
            var resultadoFormat = string.Format(ejemploFormat, "Pedro", 54);
            Console.WriteLine(resultadoFormat);

            //Replace
            string ejemploReplace = "Felicidades @nombre en tu cumpleaños número @edad, @nombre";
            var resultadoReplace = ejemploReplace.Replace("@nombre", nombre);
            resultadoReplace = resultadoReplace.Replace("@edad", "50");
            Console.WriteLine(resultadoReplace);

            //IsNullOrWhiteSpace
            string stringEspacios = "    ";
            string stringNulo = null;

            Console.WriteLine(string.IsNullOrWhiteSpace(nombre));
            Console.WriteLine(string.IsNullOrWhiteSpace(stringEspacios));
            Console.WriteLine(string.IsNullOrWhiteSpace(stringNulo));

            Console.Read();
        }
    }
}

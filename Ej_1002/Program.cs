using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Julia";
            p1.Edad = 12;
            p1.Direccion = "Avda. Vacía, 3";
            p1.Mostrar();

            Persona p2 = new Persona();
            p2.Nombre = "Eva";
            p2.Edad = 25;
            p2.Direccion = "Sin dirección";
            p2.Mostrar();

            Console.Read();
        }
    }

    public class Persona
    {
        public string Nombre;
        public int Edad;
        public string Direccion;

        public void Mostrar()
        {
            string output = "{0}, de {1} años, con dirección: {2}";
            Console.WriteLine(string.Format(output, Nombre, Edad, Direccion));
        }
    }
}

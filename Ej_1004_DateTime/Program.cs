using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1004_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2014, 10, 23);
            DateTime fechaConHora = new DateTime(2005,1,4,9,30,45);

            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd-MM-yy"));
            Console.WriteLine(fechaConHora.ToString("dd-MM-yy hh:mm:ss"));


            Console.WriteLine(fecha.AddDays(15));
            Console.WriteLine(fecha.DayOfWeek);
            Console.WriteLine(fechaConHora.Date);

            Console.WriteLine("Diferencia de días entre dos fechas");
            Console.WriteLine(fecha.Subtract(fechaConHora).Days);
            Console.Read();
        }
    }
}

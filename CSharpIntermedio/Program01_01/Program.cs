using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program01_01
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Operaciones operacion = new Operaciones();

            decimal suma = operacion.Suma(5, 3);
            int resta = operacion.Resta(5, 3);
            int multiplicacion = operacion.Multiplicacion(5, 3);
            decimal division = operacion.Division(5, 3);

            Console.WriteLine("Suma: " + suma); // Resultado: 8
            Console.WriteLine("Resta: " + resta); // Resultado: 2
            Console.WriteLine("Multiplicación: " + multiplicacion); // Resultado: 15
            Console.WriteLine("División: " + division); // Resultado: 1.666...


        }
    }
}

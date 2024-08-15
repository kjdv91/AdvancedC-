using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    public class Auto : IAuto
    {
        double costo;
        double tenencia;
        string modelo;

        public Auto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }
        public void CalcularTenencia(double imp)
        {
            tenencia = 500.0 + costo * imp;
        }

        public void MostrarInformacion()
        {
            //Mostrar informacion
            Console.WriteLine($"El modelo de tu automovil es {modelo}");
            Console.WriteLine($"El costo de tu automovil es {costo}");
            Console.WriteLine($"El impuesto de tu automovil es {tenencia}");
            Console.WriteLine($"El total de costo es {costo + tenencia}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopCart store = new ShopCart();



            // Recorro cada uno de los elemenos de la estructura
            foreach(Auto miAuto in store)
            {
                miAuto.CalcularTenencia(0.5);
                miAuto.MostrarInformacion();
            }
        }
    }
}

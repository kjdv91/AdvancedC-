using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    public class ShopCart
    {
        private Auto[] disponibles;

        public ShopCart()
        {
            disponibles = new Auto[4];
            disponibles[0] = new Auto("Soul", 20.500 );
            disponibles[1] = new Auto("Optra", 16.500);
            disponibles[2] = new Auto("Spark", 9.000);
            disponibles[3] = new Auto("March", 11.00);

        }

        public IEnumerator GetEnumerator()
        {
            return disponibles.GetEnumerator();
        }


    }
}

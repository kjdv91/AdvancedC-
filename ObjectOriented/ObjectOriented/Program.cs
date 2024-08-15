using ObjectOriented;
using System;

Car myCar = new Car();
myCar.Year = 2006;
myCar.Model = "Chevrolet";
myCar.Make = "Colombia";
myCar.Color = "Gris";

Car myOtherCar = myCar;

Console.WriteLine(myOtherCar.Year);
Console.WriteLine(myCar.Year);
Console.WriteLine(myCar.prueba());
Console.WriteLine(Car.Prueba3());

namespace ObjectOriented
{
    class Car
    {




        public string Make { get; set; }

        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public string prueba ()
        {
            string name = "KEvin";

            return name;
        }

        private void prueba2 () {
            Console.WriteLine("Soy un metodo privado");
        
        }

        public static bool Prueba3 ()

        {
            bool veardad = false;
            Console.WriteLine("Soy un metodo statico");
            return veardad;

        }




    }

}

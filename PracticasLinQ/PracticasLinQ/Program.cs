using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PracticasLinQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] niveles = { "Basico", "Medio", "Alto" };

            //var nc = niveles.Count();   //Linq
            //int max = 6;
            //var ns = niveles.Where(n => n.Length > max).OrderBy(x => x);
            //foreach ( var n in ns )
            //{
            //    Console.WriteLine(n);
            //}

            //var qn =
            //    from nivel in niveles
            //    where niveles.Length > max
            //    orderby nivel ascending
            //    select nivel;  //que vamos seleccionar

            List<Empleado> empleados = new List<Empleado>()
            {
                new Empleado()
                {
                    Nombre = "Kevin",
                    Apellido = "Jaramillo",
                    Departamento = Departamento.Desarrollo
                },
                new Empleado()
                {
                    Nombre = "David",
                    Apellido = "Guevara",
                    Departamento = Departamento.Admin
                },






            };

            List<Car> cars = new List<Car>()
        {
            new Car() {Modelo = "Chevrolet", Año = 2006, Pais ="Colombia" },
            new Car() {Modelo = "Hiunday", Año= 2020, Pais = "Japon"},
            new Car () {Modelo = "Jeep", Año = 2014, Pais = "Alemania"}



        };

            var orderss = cars.OrderByDescending(car => car.Modelo).ToList();
            var firtsCar = cars.First(x => x.Año == 2014);
            Console.WriteLine(orderss.Count);
            Console.WriteLine(firtsCar.Modelo);
            cars.ForEach(s => Console.WriteLine("{0}{1:C}", s.Pais, s.Año ));
            
            //Linq
            var carros  = from auto in cars 
                          where auto.Modelo == "Chevrolet"
                          select auto;

           

            //Linq Method 
            var orderedCars = from car in cars
                              orderby car.Año descending
                              select car;
            //los ordeno descendientemente
            //Other example 
            
           
            foreach (var autos in orderedCars)
            {
                Console.WriteLine("{0} {1}", autos.Modelo, autos.Año);
            }
        }
    }

    public class Car
    {
        public string Modelo { get; set; }
        public int Año { get; set; }

        public string Pais { get; set; }
    }
}

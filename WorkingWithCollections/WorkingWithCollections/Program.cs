using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car();
            carOne.Make = "Japan";
            carOne.Model = "Chevrolet Optra";

            Car carTwo = new Car();
            carTwo.Make = "Colombia";
            carTwo.Model = "Chevrolet Spark";


            Book book1 = new Book();
            book1.ISBN = "000-0-0-01";
            book1.Title = "Microsoft .Net XML Web Services";
            book1.Author = "Robert Tabor";

            //ArrayList son de tamaño dinámico
            // cool features sorting remove items
            //Collection
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(carOne);
            myArrayList.Add(carTwo);
            myArrayList.Add(book1);

            //foreach (Car car in myArrayList)
            //{
            //    //Da un error porque no solo estams trabajando co car si no tambi con books
            //    Console.WriteLine(car.Make);
            //}
            //Console.ReadLine();

            //Generic List<T>
            //Tipo de dato específico
            List<Car> myListCar = new List<Car>();
            myListCar.Add(carOne);
            myListCar.Add(carTwo);
            foreach(Car car in myListCar)
            {
                Console.WriteLine(car.Make);
            }

            //Dictionariy<TKey, TValue> Clave - Valor

            //Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            //myDictionary.Add(carOne.Make, carOne);
            //myDictionary.Add(carTwo.Make, carTwo);

            //Console.WriteLine(myDictionary["B2"].Make);

            //Inicializar Colección
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Colombia", Model = "Chevrolet Optra"},
                new Car { Make = "Francia", Model = "Peugeot 6"}
            };
            
            



        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
    }
}

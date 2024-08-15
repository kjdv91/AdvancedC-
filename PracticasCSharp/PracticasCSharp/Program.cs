using System;

namespace PracticasCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista 
            string myString = "My  \"so\" ";
            string myString2 = String.Format("{0} = {1}","Primero", "Segundo");
            Console.WriteLine(myString2);
            //int[] numbers = new int[] { 10, 20, 30, 5, 9, 11 };
            //for(int i =0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(numbers);
            //}
            Console.WriteLine(myString);
            //DateTime
            DateTime myValue = DateTime.Now;
            Console.WriteLine("La fecha y hora es:  " + myValue.ToString());
            Console.WriteLine("La hora es: " + myValue.ToShortTimeString());
            Console.WriteLine("La fecha corta es :" + myValue.ToShortDateString());
            Console.WriteLine("La fecha de hoy mas 3 dias:  " + myValue.AddDays(3).ToLongDateString());
            DateTime myBitrhday = new DateTime(1991,12,5);
            Console.WriteLine("Mi cumpleaños es : " + myBitrhday.ToShortDateString());
            

    }

        private static void Reverse()

        {
            string firstName = "Kevin";
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            foreach (char item in firstNameArray)
            {

            }

        }



    }
}

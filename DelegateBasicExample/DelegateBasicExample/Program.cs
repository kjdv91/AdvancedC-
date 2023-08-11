using System;

namespace DelegateBasicExample
{
    public class Program
    {
        delegate void LogDel(string text, DateTime dateTime);
        static void Main(string[] args)
        {
            Log logL = new Log();
            
            LogDel log = new LogDel(logL.LongTextToScreen);
            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();

            log(name, DateTime.Now);
            Console.ReadKey();
        }


       
    }


    public class Log
    {
        public void LongTextToScreen(string text, DateTime dateTime)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

    }
}

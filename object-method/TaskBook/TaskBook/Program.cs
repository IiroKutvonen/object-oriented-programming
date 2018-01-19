using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book();          
            bookOne.PrintBookInfo();            
            Console.ReadKey();
        }
    }
}

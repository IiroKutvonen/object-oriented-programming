using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book();

            bookOne.Id = int.Parse(Utils.CreateId(5));
            bookOne.PrintBookInfo();
            Console.ReadKey();
        }
    }
}

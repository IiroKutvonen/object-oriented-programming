using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class Book
    {
        Random rnd = new Random();
        public string Title;
        public string Author;
        public int Id;
        public string Price;

            

        public void PrintBookInfo()
        {
            Console.WriteLine($"Nimi: {Utils.CreateTitle()}");
            Console.WriteLine($"Id-numero: {Utils.CreateId(10)}");
            Console.WriteLine($"Hinta: {Utils.CreatePrice()}");
        }
    }
}

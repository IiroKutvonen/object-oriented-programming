using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class Utils
    {
        static Random rnd = new Random();
        public static string CreateId(int lkm)
        {

            int i = 0;
            string idNum = "";

            while (i < lkm)
            {
                i++;
                idNum += rnd.Next(0, 9).ToString();
            }
            return idNum;
        }

        public static string CreateTitle()
        {
            string[] bookTitles = new string[] { "Aapinen", "Virikirja", "C#", "Olio-ohjemointi" };
            return bookTitles[rnd.Next(bookTitles.Length)];

        }

        public static string CreatePrice()
        {

            int euro = 0;
            int cent = 0;
            string price = "";

            euro = rnd.Next(0, 100);
            cent = rnd.Next(0, 100);
            price = price + euro.ToString() + "," + cent.ToString() + " euroa";
            return price;
        }

        public static string CreateAuthor()
        {
            string[] firstName = new string[] { "David", "John", "Mary", "Jack", "Agatha" };
            string authorFirstName = firstName[rnd.Next(firstName.Length)];
            string[] lastName = new string[] { "McClane", "Bowie", "Madrigal", "Johnson", "York" };
            string authorLastName = lastName[rnd.Next(lastName.Length)];
            return authorFirstName + " " + authorLastName;

        }
    }
}

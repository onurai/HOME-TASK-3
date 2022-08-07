using System;

namespace home_task_3__08._07._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Countspaces(string str)
        {
            int spcctr = 0;
            string strone;
            for (int i = 0; i < str.Length; i++)
            {
                strone = str.Substring(i, 1);
                if (strone == " ")
                    spcctr++;
            }
            return spcctr;
        }
        public static void ali()
        {
            string strtwo;
            Console.Write("Please Enter a string : ");
            strtwo = Console.ReadLine();
            Console.WriteLine("\"" + strtwo + "\"" + " contains {0} spaces", Countspaces(strtwo));

            Console.ReadLine();

        }
        static void GAIN(string[] args)
        {
            Console.Write("Input a string: ");
            string text = Console.ReadLine();
            string newString;

            if (text.Length <= 4)
            {
                newString = text.ToUpper();
            }
            else
            {
                newString = text.Substring(0, 4).ToLower() + text.Substring(4);
            }

            Console.WriteLine(newString);
            //Burda yuxarida MAIN yazilmisdi oxsar olmasin deye GAIN yazdim
        }
    }   }   

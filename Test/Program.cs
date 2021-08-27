using System;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    class Program

    {
        private static void Anagram(string str1, string str2)
        {

            if (str1.Length == str2.Length)
            {
                int Result= string.Compare(str1, str2, false);

                if (Result == 0)
                {
                    Console.WriteLine($"Strings are equal");
                }
                else
                {
                    Console.WriteLine($"Strings are  not equal ");
                } 

            }
            else
            {
                Console.WriteLine($"Strings are  not equal ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter firstString:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter secondString:");
            string string2 = Console.ReadLine();



            Anagram(string1, string2);

            Console.WriteLine($"Strings are:  {string1},{string2}");


        }

        
    }
}

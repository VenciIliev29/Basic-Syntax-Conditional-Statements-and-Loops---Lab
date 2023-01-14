using System;
using System.Net.Http.Headers;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int haurs = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) +30;

            if (minutes > 60)
            {

                haurs += 1;
                minutes -= 60;



            }


            if ( haurs > 23)
            {

                haurs = 0;


            }

            Console.WriteLine($"{haurs}:{minutes:D2}");

        }
    }
}

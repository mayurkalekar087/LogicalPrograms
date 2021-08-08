using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CoupanNumber
    {
        public static void CoupanNumber1()
        {
            int number;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Console.WriteLine("Enter a coupan number");
            number = int.Parse(Console.ReadLine());
            var stringChars = new char[6];
            var random = new Random();
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                   
                }
                var finalString = new String(stringChars);
                Console.WriteLine(stringChars);
            }
        }
    }
}

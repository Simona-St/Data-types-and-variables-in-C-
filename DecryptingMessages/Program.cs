using System;
using System.Collections.Generic;
using System.Text;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                char characters = char.Parse(Console.ReadLine());
                int symbolToNum = Convert.ToInt32(characters) + key;
                char charNew = Convert.ToChar(symbolToNum); 

                message += charNew;
            }
            Console.WriteLine(message);
        }
    }
}

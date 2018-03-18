using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = 0.00; // temp variables
            string biggestModel = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume >= biggestVolume)
                {
                    biggestModel = model;
                }

                biggestVolume = Math.Max(volume, biggestVolume);
            }

            Console.WriteLine(biggestModel);
            
        }
    }
}

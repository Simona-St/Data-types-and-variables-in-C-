using System;
using System.Collections.Generic;
using System.Text;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long resultBoat1 = 0;
            long resultBoat2 = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (i % 2 == 1)
                {
                    if (input == "UPGRADE")
                    {
                        long upgradeBoat1 = Convert.ToInt32(firstBoat) + 3;

                        firstBoat = Convert.ToChar(upgradeBoat1);
                    }

                    else
                    {
                        resultBoat1 += Convert.ToInt32(input);
                        //The boat moves with the count of the tiles, equal to the length of the given string. 

                        if (resultBoat1 >= 50)
                        {
                            Console.WriteLine(firstBoat);
                            return;
                        }

                    }
                }

                else
                {

                    if (input == "UPGRADE")

                    {
                        long upgradeBoat2 = Convert.ToInt32(secondBoat) + 3;
                        secondBoat = Convert.ToChar(upgradeBoat2);
                    }
                    else
                    {
                        resultBoat2 += Convert.ToInt32(input);
                        if (resultBoat2 >= 50)
                        {
                            Console.WriteLine(secondBoat);
                            return;
                        }
                    }

                }

            }
            // If neither of the boats reaches 50 moves – print the boat, which reached the most moves.

            if (resultBoat1 > resultBoat2)
            {
                Console.WriteLine(firstBoat);
            }

            else
            {
                Console.WriteLine(secondBoat);
            }

        }
    }
}

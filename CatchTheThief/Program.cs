using System;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine().ToLower();
            byte n = byte.Parse(Console.ReadLine());
            long thiefId = long.MinValue;

            for (byte i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());
                
                switch (idType)
                {
                    case "sbyte":
                        if (id >= sbyte.MinValue && id <= sbyte.MaxValue)
                        {
                            thiefId = Math.Max(thiefId, id);

                        }

                        break;

                    case "int":
                        if (id >= int.MinValue && id <= int.MaxValue)
                        {
                            thiefId = Math.Max(thiefId, id);

                        }
                        break;

                    case "long":
                        if (id >= long.MinValue && id <= long.MaxValue)
                        {
                            thiefId = Math.Max(thiefId, id);

                        }
                        break;
                }

            }

            Console.WriteLine(thiefId);
        }
    }
}

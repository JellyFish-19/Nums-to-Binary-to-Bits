using System;
using System.Linq;

namespace PRAKTIKA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, 2);

            Console.WriteLine($"The {num} in binary is {binary}, and it has {ToBits(num)} bits");

            Console.ReadLine();

            static int ToBits(int num)
            {
                string binary = Convert.ToString(num, 2);

                int count = 0;

                var newString = binary.ToCharArray();

                foreach (var item in newString)
                {
                    if (item == '1')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}

using System;
 
namespace chetnye_kuby
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число N: ");
            int chisloN = int.Parse(Console.ReadLine());
            int i = 1;
            while ( i < chisloN )
            {
                double kub = Math.Pow(i, 3);
                if ( kub % 2 == 0)
                {
                Console.WriteLine("Четный куб числа " + i + "  " + kub);
                }
                i = i + 1;
            }
        }
    }
}

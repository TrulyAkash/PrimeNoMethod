using System;
namespace ChetuInc
{
    class PrimeNoRec
    {
        public int PrimeNo(int num, int i)
        {

            if (i == 1)
                return 1;
            else
            {
                if (num % i == 0)
                    return 0;
                else
                    return PrimeNo(num, i - 1);


            }

        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a no. :");
            n = int.Parse(Console.ReadLine());
            PrimeNoRec z = new PrimeNoRec();
            int x = z.PrimeNo(n, n / 2);
            if (x == 1)
                Console.WriteLine("it is a prime no.");
            else
                Console.WriteLine("not a prime no.");

            Console.ReadLine();
        }
    }
}
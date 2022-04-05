using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Predicates
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Predicate<int> predicate = new Predicate<int>(GetPrimes);

            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            //List<int> result = list.FindAll(predicate);
            List<int> result = LambdaExpression.getPairs();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static bool GetPairs(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        static bool GetPrimes(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }

    class LambdaExpression
    {
        private static List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static List<int> getPairs()
        {
            return list.FindAll(x => x % 2 == 0);
        }
    }
}

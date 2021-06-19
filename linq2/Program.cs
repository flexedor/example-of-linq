using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = {-1,0,-59, 90, 71, 82,-17, 93, 75, 82 };

            IEnumerable<string> querySelector =
                from score in scores
                where score > 70
                orderby score descending //отсортировать в обратном порядке 
                select $"The score is {score}";//возвраат со строкой
            int legth = querySelector.Count();

            foreach (var x in querySelector)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(scores.Sum());//найти сумму всего 
            Console.WriteLine(scores.Where((p) => p >= 0).Sum()); // сумма всех положительных 
            Console.WriteLine(scores.Where((p) => p % 2 == 0).Sum());//сумма всех четных чисел 
            var querySelector1 =
                from score in scores
                where score > scores.Min() && score < scores.Max()//вывести все цифры , кроме самой мальнокой и большой 
                select score;
            foreach (var x in querySelector1)
            {
                Console.Write(x + " ");
            }
            
            foreach ( var x in scores.Select(x=>Math.Abs(x)))
            {
                Console.Write(x + " ");
                //Console.Write(Math.Abs(x) + " ");
            }
            Console.ReadLine();
        }
    }
}

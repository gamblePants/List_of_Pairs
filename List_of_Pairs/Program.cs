using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 5, 7, 9 };
            int k = 2;
            int answer = PairDifference(numbers, k);

            Console.WriteLine(answer);
            Console.ReadKey();
        }

        // method takes a list of ints and splits them into pairs
        // then checks if the difference between the pair (pair[1] - pair[0]) equals k
        // returns the number of times this is true
        static int PairDifference(List<int> numbers, int k)
        {
            int answer = 0;

            List<int[]> pairs = new List<int[]>();

            for (int i = 0; i < numbers.Count -1; i ++)
            {
                pairs.Add(new[] { numbers[i], numbers[i + 1] });
            }

            for (int i = 0; i < pairs.Count; i ++)
            {
                if (pairs[i][1] - pairs[i][0] == k)
                {
                    answer += 1;
                }
            }

            return answer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop01JediMeditation
{
    public class Program
    {
        public static void Main()
        {
            int numberOfJedis = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');

            Queue<string> jediMasters = new Queue<string>();
            Queue<string> jediKnights = new Queue<string>();
            Queue<string> jediPadawans = new Queue<string>();

            for (var i = 0; i < numberOfJedis; i++)
            {
                if (input[i][0] == 'm')
                {
                    jediMasters.Enqueue(input[i]);
                }
                if (input[i][0] == 'k')
                {
                    jediKnights.Enqueue(input[i]);
                }
                if (input[i][0] == 'p')
                {
                    jediPadawans.Enqueue(input[i]);
                }
            }

            StringBuilder sb = new StringBuilder();
            while (jediMasters.Count > 0)
            {
                var currentJedi = jediMasters.Dequeue();
                sb.Append(currentJedi + " ");
            }

            while (jediKnights.Count > 0)
            {
                var currentJedi = jediKnights.Dequeue();
                sb.Append(currentJedi + " ");
            }

            while (jediPadawans.Count > 0)
            {
                var currentJedi = jediPadawans.Dequeue();
                sb.Append(currentJedi + " ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}

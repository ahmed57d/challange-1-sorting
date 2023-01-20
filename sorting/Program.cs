using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace sorting
{
    internal class Program
    {
        static bool isSmaller(string a, string b)
        {
            a = String.Concat(a.OrderBy(c => c));
            b = String.Concat(b.OrderBy(c => c));
            bool isSmall = true;
            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
                if (a[i] > b[i])
                {
                    isSmall = false;
                    break;
                }
            return isSmall;
        }
        static void Main(string[] args)
        {

            var words = new List<string>();
            var word = "";
            do
            {
                Console.WriteLine("Enter a word, press enter when you are done");
                word = Console.ReadLine();
                words.Add(word);
            } while (!String.IsNullOrWhiteSpace(word));
            //var sortedList = words.OrderByDescending(x => x).ToList();
            //sortedList.ForEach(x => Console.WriteLine(x));
            for (int i = 0; i < words.Count; i++)
            {
                string min = words[i];
                int minIndex = i;
                for (int j = i + 1; j < words.Count; j++)
                    if (isSmaller(words[j], min))
                    {
                        min = words[j];
                        minIndex = j;

                    }
                (words[i], words[minIndex]) = (words[minIndex], words[i]);

            }
            words.ForEach(x => Console.WriteLine(x));
        }




    }
}








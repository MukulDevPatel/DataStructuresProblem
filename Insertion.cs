using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class Insertion
    {
        public void Main()
        {
            Console.WriteLine("Enter the list word");
            string word = Console.ReadLine();
            string[] words = word.Split(" ");

            InsertionSort(words);

            Console.WriteLine("Sorted list");
            foreach (var data in words)
            {
                Console.WriteLine(word + " ");
            }
            Console.WriteLine();
        }

        private void InsertionSort(string[] words)
        {
            for (int i = 1; i < words.Length; i++)
            {
                string key = words[i];
                int j = i - 1;
                while (j >= 0 && words[j].CompareTo(key)>0)
                {
                    words[j + 1] = words[j];
                    j = j - 1;
                }
                words[j + 1] = key;
            }
        }
    }
}

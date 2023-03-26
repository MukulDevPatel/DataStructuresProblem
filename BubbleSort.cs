using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class BubbleSort
    {
        public void ReadFile(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            int[] arr = new int[words.Length];
            int count = 0;
            foreach (var data in words)
            {
                arr[count] = Convert.ToInt32(Console.ReadLine());
                count++;
                Console.WriteLine(data);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i;  j < arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var data in arr)
            {
                Console.WriteLine("Sorted List: "+ data + " ");
            }
        }
    }
}

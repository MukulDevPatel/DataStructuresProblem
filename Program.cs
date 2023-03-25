using System;

namespace DataStructureProblem
{
    class Problem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Data Structure Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the number for execution");
                Console.WriteLine("\n1. Binary Search\n2. Exit");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        BinarySearch binary = new BinarySearch();
                        binary.ReadFile(@"D:\BridgeLabz\DataStructuresProblem\File.txt");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}

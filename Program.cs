using System;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CList<int> ints = [1, 2, 512, -1];
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }
}

using System;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CList<int> ints = [1, 2, 3, 42, -1];
            ints.AddHead(512);
            ints.AddHead(256);
            ints.AddTail(1024);
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }
}

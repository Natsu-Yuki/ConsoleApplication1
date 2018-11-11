using System;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main()
        {

            Bst<int> bst =new Bst<int>();
            for (int i = 0; i < 10; i++)
            {
                bst.Add(i);
            }

            Console.WriteLine(bst.Contains(1));
            Console.WriteLine(bst.Contains(10));
            
        }
    }
}
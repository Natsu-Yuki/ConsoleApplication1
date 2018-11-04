using System;

namespace ConsoleApplication1
{
    public static class ExtendedMethod
    {
        public static int Add(this int i,int a)
        {
            return i+a;
            
            
        }

        public static int ToInt(this string s)
        {
            return int.Parse(s);
        }
        
        
        
        public static void ForEach<T>(this GAD_List_Array<T> listArray,Action<T> f )
        {
            foreach (var n in listArray)
            {
                f(n);
            }
        }

        public static int sum(this GAD_List_Array<int> listArray, Func<int, int> f)
        {
            int sum = 0;
            foreach (var n in listArray)
            {
                sum += f(n);
            }

            return sum;
        }
        
    }
}
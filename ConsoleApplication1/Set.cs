using System;

namespace ConsoleApplication1
{
    public interface Set<T>
    {
        void Add(T t);
        void Remove(T t);
        void Contains(T t);
        int GetSize();
        Boolean IsEmpty();

    }
}
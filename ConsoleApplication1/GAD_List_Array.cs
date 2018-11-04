using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class GAD_List_Array<T>:IEnumerable<T>
    {
        protected int _MAX;
        protected T[] _elements;
        protected int _count;

        
        public GAD_List_Array()
        {
            _MAX = 10000000;
            _elements = new T[_MAX];
            _count = 0;
        }
        public int Count()
        {
            // ...
            return _count;
        }
        public int Index(T element)
        {
            // ...
            if (Count()==0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < Count(); i++)
                {
                    if (_elements[i].Equals(element))
                    {
                        return i;
                        break;                  
                    }
                }
            }

            return -1;
        }
        public T Next(T element)
        {
            // ...
            int index = Index(element);
            if (index >= 0)
            {
                if (index == Count() - 1)
                    throw new Exception("Tail!");
                else
                {
                    return _elements[index + 1];
                }
            }
            else
            {
                throw new Exception("Not found element");
            }
        }
        public T Prev(T element)
        {
            // ...
            int index = Index(element);
            if (index >= 0)
            {
                if (index == 0)
                    throw new Exception("Head!");
                else
                {
                    return _elements[index - 1];
                }
            }
            else
            {
                throw new Exception("Not found element");
            }
        }
        public T Head()
        {
            // ...
            if (Count() > 0)
                return _elements[0];
            else
            {
                throw new Exception("Empty list!");
            }
        }
        public T Tail()
        {
            // ...
            if (Count() > 0)
                return _elements[Count() - 1];
            else
            {
                throw new Exception("Empty list!");
            }
        }
        public T Get(int index)
        {
            // ...
            if (index >= 0 && index < Count())
                return _elements[index];
            else
                throw new Exception("invalid index!");
        }
        public void Insert(int index, T element)
        {
            // ...
            if (Count() >= _MAX)
            {
                throw new Exception("Exceed storage!");
            }
            else if (index == Count() && index < _MAX)
            {
                _elements[Count()] = element;
                _count++;
            }
            else if (index >=0 && index < Count())
            {
                for (int i = Count(); i > index; i--)
                {
                    _elements[i] = _elements[i - 1];
                }
                _elements[index] = element;
                _count++;
            }
            else
            {
                throw new Exception("Invalid index");
            }
        }
        public void InsertBefore(T pos, T element)
        {
            // ...
            if (pos == null && Count() == 0)
            {
                Insert(0, element);
            }
            else
            {
                int index = Index(pos);
                Insert(index, element);
            }
        }
        public void InsertAfter(T pos, T element)
        {
            // ...
            if (pos == null && Count() == 0)
            {
                Insert(0, element);
            }
            else
            {
                int index = Index(pos);
                Insert(index + 1, element);
            }
        }
        public void Remove(int index)
        {
            // ...
            if (Count() <= 0)
            {
                throw new Exception("Empty storage!");
            }
            
            else if (index >= 0 && index < Count())
            {
                for (int i = index; i < Count() - 1; i++)
                {
                    _elements[i] = _elements[i + 1];
                }
                _count--;
            }
            else
            {
                throw new Exception("Invalid index");
            }
        }
        public void Remove(T element)
        {
            // ...
            int index = Index(element);
            Remove(index);
        }

        public void Swap(int index1, int index2)
        {
            //...
            if (index1 < 0 || index2 < 0 || index1 >= Count() || index2 >= Count())
            {
                throw new Exception("Invalid index");
            }
            else
            {
                T temp = Get(index1);
                _elements[index1] = _elements[index2];
                _elements[index2] = temp;
            }
        }
       
        public void SetValue(int index,T value)
        {
            if (index<0||index>=Count())
            {
                throw new Exception("Invalid index!");
            }
            else
            {
                _elements[index] = value;
            }
        }

        public void Add(T element)
        {
            if (Count() >= _MAX)
            {
                throw new Exception("Exceed storage!");
            }
            else
            {
                _elements[_count++] = element;
                
            }
            
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count(); i++)
            {
                yield return _elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object this[int i]
        {
            get
            {
                if (i>=0&&i<Count())
                {
                    return _elements[i];
                }
                else
                {
                    throw new Exception("Invalid index!");
                }
                
                
            }
            set
            {
                if (i>=0&&i<Count())
                {
                    _elements[i] = (T)value;
                }
                else
                {
                    throw new Exception("Invalid index!");
                }
            }
        }
    }
    
    
    
    
}
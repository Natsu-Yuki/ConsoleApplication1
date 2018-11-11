using System;


namespace ConsoleApplication1
{
    public class Bst<T> where T : IComparable
    {
        public class Node
        {
            public T T;
            public Node Left, Right;

            public Node(T t)
            {
                T = t;
                Left = null;
                Right = null;
            }

            
        }

        private Node _root;
        private int _size;

        public Bst()
        {
            _root = null;
            _size = 0;
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
            
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public void Add(T t)
        {
            _root = Add(_root, t);
        }
        
        private Node Add(Node node, T t)
        {

            if (node == null)
            {
                _size++;
                return new Node(t);
            }


            if (t.CompareTo(node.T) < 0)
            {
                node.Left = Add(node.Left, t);
            }
            else if(t.CompareTo(node.T)>0)
            {
                node.Right = Add(node.Right, t);
            }

            return node;

        }

        public Boolean Contains( T t)
        {
            return Contains(_root, t);
        }

        private Boolean Contains(Node node, T t)
        {
            if (node==null)
            {
                return false;
            }
            else if (t.CompareTo(node.T)==0)
            {
                return true;
            }

            else if(t.CompareTo(node.T)<0)
            {
                return Contains(node.Left, t);
            }
            else
            {
                return Contains(node.Right, t);
            }
        }


        private Node Minmum(Node node)
        {
            if (node.Left==null)
            {
                return node;
            }
            else
            {
                return Minmum(node.Left);
            }
        }

        private Node RemoveMin(Node node)
        {
            if (node.Left==null)
            {
                Node rightNode = node.Right;
                node.Right = null;
                _size--;
                return rightNode;
            }

            node.Left = RemoveMin(node.Left);
            return node;
        }

//        public T Traverse()
//        {
//            
//        }




    }
}
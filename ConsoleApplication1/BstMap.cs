using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class BstMap<K,V> : Dictionary<K,V> where K :IComparable<K> 
    {
        private class Node
        {
            public K Key;
            public V Value;
            public Node Left, Right;

            public Node(K key,V value)
            {
                this.Key = key;
                this.Value = value;
                Left = null;
                Right = null;

            }
        }

        private Node root;
        private int size;

        public BstMap()
        {
            root = null;
            size = 0;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
            
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Add(K key, V value)
        {
            root = Add(root, key, value);
        }

        private Node Add(Node node,K key, V value)
        {
            if (node == null)
            {
                size++;
                return new Node(key,value);
            }


            if (key.CompareTo(node.Key) < 0)
            {
                node.Left = Add(node.Left, key,value);
            }
            else if(key.CompareTo(node.Key)>0)
            {
                node.Right = Add(node.Right, key,value);
            }
            else
            {
                node.Value = value; 
            }
            

            return node;
            
        }

        private Node GetNode(Node node, K key)
        {
            if (node == null) return null;

            if (key.CompareTo(node.Key)==0)
            {
                return node;
            }
            else if (key.CompareTo(node.Key)<0)
            {
                return GetNode(node.Left, key);
            }
            else
            {
                return GetNode(node.Right, key);
            }
            
            
        }

        public bool Contains(K key)
        {
            return GetNode(root, key) != null;
        }

        public V Get(K key)
        {
            Node node = GetNode(root, key);
            if(node==null) throw new Exception("null!");
            else
            {
                return node.Value;
            }
        }

        public void Set(K key,V newvalue)
        {
            Node node = GetNode(root, key);
            if(node==null) throw new Exception("null!");
            else
            {
                node.Value=newvalue;
            }
            
        }
        
        
        
    }
}
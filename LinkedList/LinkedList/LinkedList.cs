using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> 
    {
        private Node<T> head;       

        public void AddFirst(T value)
        {
            Node<T> temp = new Node<T>();
            temp.data = value;
            temp.Next = head;
            head = temp;
        }


        public void AddLast(T value)
        {
            if (head == null)
            {
                head = new Node<T>();
                head.data = value;
                head.Next = null;
            }
            else
            {
                Node<T> newNode = new Node<T>();
                newNode.data = value;
                newNode.Next = null;

                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void PrintAll()
        {
            var current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.Next;
            }
        }

        public int Count()
        {
            var current = head;
            int count = 0;
            while (current != null)
            {
                current = current.Next;
                count++;
            }
            return count;
        }


        public T GetFirstData()
        {
            if (head == null)
            {
                return default(T);
            }
            return head.data;
        }

        public Node<T> GetFirstNode()
        {
            return head;
        }

        public Node<T> GetLastNode()
        {
            var current = head;
            if (head == null)
            {
                return null;
            }
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }

        public T GetLastData()
        {
            if (head == null)
            {
                return default(T);
            }
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.data;
        }


        public void AddAfter(Node<T> node, T value)
        {
            var newNode = new Node<T>();
            if (head == null)
            {
                newNode.data = value;
                newNode.Next = null;
                head = newNode;
                return;
            }             
            newNode.data = value;
            newNode.Next = node.Next;
            node.Next = newNode;
        }


        public void AddAfter(Node<T> node, Node<T> newNode)
        {
            if (node == null)
            {
                return;
            }
            node.Next = newNode;
        }

        public void Clear()
        {
            head = null;
        }

        public void AddLastToFirst()
        {
            GetLastNode().Next = GetFirstNode();
        }


        public int IndexOf(T data)
        {
            var current = head;
            for (int i = 0; i < Count(); i++)
            {
                if (current.data.Equals(data))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(T data)
        {
            return IndexOf(data) > -1;
        }

        public void Remove(T data)
        {
            var current = head;
            if (head == null)
            {
                throw new Exception();
            }
            if (IndexOf(data) == 0)
            {
                head = current.Next;
                return;
            }
            for (int i = 0; i < IndexOf(data) - 1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new Exception();
            }
            head = head.Next;
        }

        public void RemoveLast()
        {
            var current = head;
            if (head == null)
            {
                throw new Exception();
            }
            for (int i = 0; i < Count() - 2; i++)
            {
                current = current.Next;
            }
            current.Next = null;
        }

    }
}

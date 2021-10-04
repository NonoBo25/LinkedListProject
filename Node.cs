using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Node<T>
    {
        private T value;
        private Node<T> next;
        public Node()
        {
            next = null;
        }
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.next = next;
            this.value = value;
        }

        public Node(Node<T> n)
        {
            this.value = n.Value;
            this.next = n.Next;
        }

        public T Value { get => value; set => this.value = value; }
        public Node<T> Next { get => next; set => this.next = value; }

        public override string ToString()
        {
            return value.ToString();
        }
        public override bool Equals(object obj)
        {
            if(obj.GetType() == this.GetType())
            {
                Node<T> comp = (Node<T>)obj;
                if (comp.Value.Equals(this.Value))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

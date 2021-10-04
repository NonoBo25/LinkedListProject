using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int len;

        public List() { len = 0; }
        public List(T value) 
        {
            this.head = new Node<T>(value);
            this.len = 1;
            this.tail = head;
        }
        public List(Node<T> head)
        {
            this.head = head;
            this.tail = head;
            this.len = 0;
            CalcLen();
        }

        private void CalcLen()
        {
            Node<T> curr = new Node<T>(head);
            while (curr != null)
            {
                len++;
                curr = curr.Next;
            }
            
        }

        public List(Node<T> head , Node<T> tail)
        {
            this.head = head;
            this.tail = tail;
            this.len = 0;
            CalcLen();
        }

        public Node<T> Get(int index)
        {
            if(index <= len - 1 && index>=0)
            {
                int count = 0;
                Node<T> curr = head;
                while (count < index)
                {
                    curr = curr.Next;
                    count++;
                }
                return curr;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Append(Node<T> cell)
        {
            this.tail.Next = cell;
            this.tail = tail.Next;
            this.len++;
        }
        public void Append(T value)
        {
            this.tail.Next = new Node<T>(value);
            this.tail = tail.Next;
            this.len++;
        }

        public T this[int i]
        {
            get { return Get(i).Value; }
            set { Get(i).Value = value; }
        }

        public override string ToString()
        {
            string repr = "[ ";
            for(int i=0;i<Len;i++)
            {
                repr += this[i].ToString() + ", ";
            }
            repr += "\b\b ]";

            return repr;
        }
        
        public int Len { get => len; set => len = value; }

        public void remove(int index)
        {
            if (index < len&& index>0)
            {

                Node<T> prev = this.Get(index - 1);
                Node<T> crr = this.Get(index);
                prev.Next = crr.Next;
                len--;
            }
            else if (index == 0)
            {
                this.head = this.head.Next;
            }
        }

        public void insert(T value, int index)
        {
            if (index < Len)
            {
                Node<T> newItem = new Node<T>(value);
                Node<T> next = this.Get(index);
                newItem.Next = next;
                if (index > 0 )
                {
                    
                    this.Get(index - 1).Next = newItem;
                    len++;
                }
                else if (index == 0)
                {
                    this.head = newItem;
                    len++;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }


        }
    }
}

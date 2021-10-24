using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static Node<int> Ex_10(int begginer,int num)
        {
            int count = 1;
            Node<int> head = new Node<int>(begginer);
            Node<int> curr = head;
            while (count < num)
            {
                curr.Next = new Node<int>(begginer + count);
                curr = curr.Next;
                count++;
            }
            return head;
        }
        static Node<T> Ex_6<T>(Node<T> head)
        {
            Node<T> headCpy = new Node<T>(head);
            headCpy.Next = null;
            Node<T> newHead = headCpy;
            Node<T> curr = head;
            while (curr != null)
            {
                if (!isInList<T>(newHead, curr))
                {
                    headCpy.Next = new Node<T>(curr);
                    headCpy = headCpy.Next;
                    headCpy.Next = null;
                }
                curr = curr.Next;

            }
            return newHead;
        }

        static bool isInList<T>(Node<T> list, Node<T> item)
        {
            Node<T> curr = list;
            while (curr != null)
            {
                if (item.Equals(curr))
                {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }
    }
}

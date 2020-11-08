using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace AddRemoveProject
{
    class Program
    {
        public static Node<int> AddSorted (Node<int> head, int x)
        {
            Node<int> previous = null;
            Node<int> current = head;
            while (current!=null && current.GetValue() < x)
            {
                previous = current;
                current = current.GetNext();
            }
            if (previous == null)
                return new Node<int>(x, head);
            previous.SetNext(new Node<int>(x, current));
            return head;
        }
        public static Node<int> Sort (Node<int> head)
        {
            Node<int> newList = null;
            for (; head != null; head= head.GetNext())
            {
                newList = AddSorted(newList, head.GetValue());
            }
            return newList;
        }
        public static Node<int> Listing (int[] ar)
        {
            Node<int> dummy = new Node<int> (ar[0]);
            Node<int> last = dummy;
            for (int i =1; i < ar.Length; i++)
            {
                last.SetNext(new Node<int>(ar[i]));
                last = last.GetNext();
            }
            return dummy;
        }
        public static void Print(Node<int> a)
        {
            if (a.GetNext() == null)
                Console.WriteLine(a.GetValue());
            else
            {
                Console.Write($"{a.GetValue()}, ");
                Print(a.GetNext());
            }
        }
        static Node<int> Merge (Node<int> p1, Node<int> p2)
        {
            throw new NotImplementedException();

        }
        static Node<int> Remove (Node<int> p , int x)
        {
            throw new NotImplementedException();
        }
        static Node<int> RemoveAt (Node<int> p, int index)
        {
            throw new NotImplementedException();
        }
        static Node<int> Rearrange (Node<int> head)
        {
            // all nodes with bigger value  of the original first node with the node at the end 
            //all the pedestrians take the first reing ony this house
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 4, 6, 1, 12, 9 };
            Node<int> p = Listing(numbers);
            Print(p);
            p = Sort(p);
            Print(p);
            int[] nums = { 5, 3, 1, 9, 10 };

            Node<int> p1 = Listing(nums);
            p1 = Sort(p1);
            Print(p1);
            Node<int> p3 = Merge(p, p1);
            Print(p3);

            Console.ReadKey();
        }
    }
}

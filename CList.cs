
using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    internal class CList<T> : IEnumerable<T>
    {
        public class Node
        {
            public T Value;
            public Node Next;
        }

        private Node Head;
        private Node Last;

        //just to "CList<int> ints = [1, 2, 3, 42, -1];" syntaxis, lol
        public void Add(T item)
        {
            AddTail(item);
        }

        public void AddTail(T item)
        {
            if(Head == null)
            {
                InitHead(item);
                return;
            }
            Node next = new Node();
            next.Value = item;
            Last.Next = next;
            Last = next;
        }

        public void AddHead(T item)
        {
            if(Head == null)
            {
                InitHead(item);
                return;
            }
            Node newHead = new Node();
            newHead.Value = item;
            newHead.Next = Head;
            Head = newHead;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void InitHead(T item)
        {
            Head = new Node();
            Head.Value = item;
            Last = Head;
        }
    }
}

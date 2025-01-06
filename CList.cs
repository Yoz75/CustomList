
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

        public void AddTail(T item)
        {
            CreateHeadIfNull();
            Node next = new Node();
            next.Value = item;
            Last.Next = next;
            Last = next;
        }

        public void AddHead()
        {
            CreateHeadIfNull();
            if(Head == null)
            {
                Head = new Node();
                Last = Head;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void CreateHeadIfNull()
        {
            if(Head == null)
            {
                Head = new Node();
                Last = Head;
            }
        }

    }
}


using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    internal class CEnumerator<T> : IEnumerator<T>
    {
        private readonly CList<T>.Node FirstNode;
        private CList<T>.Node CurrentNode;

        public CEnumerator(CList<T>.Node startNode)
        {
            FirstNode = startNode;
        }
        public T Current => CurrentNode.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            return;
        }

        public bool MoveNext()
        {
            if(CurrentNode == null)
            {
                CurrentNode = FirstNode;
                return true;
            }
            if(CurrentNode.Next == null)
            {
                return false;
            }
            CurrentNode = CurrentNode.Next;
            return true;
        }

        public void Reset()
        {
            CurrentNode = FirstNode;
        }
    }
}

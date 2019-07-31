using System;

namespace DataStructures
{
    public class LinkedList : IDataStructure
    {
        private Node _anchor;
        public LinkedList()
        {
            _anchor = new Node();
        }
        public void Add(int value)
        {
            Node current = _anchor;

            while (current.Next != null)
                current = current.Next;

            Node node = new Node
            {
                Value = value
            };
            current.Next = node;
        }
        public void Remove(int index)
        {
            if (IsEmpty())
                return;

            if (index == 0)
            {
                var tmp = _anchor.Next;
                _anchor.Next = tmp.Next;
                tmp.Next = null;
                return;
            }

            var previous = FindPrevious(index);
            var node = Find(index);

            if (node == null)
                return;

            previous.Next = node.Next;
            node.Next = null;
        }
        public void Cross()
        {
            Node current = _anchor;

            while (current.Next != null)
            {
                current = current.Next;
                Console.Write(current);
            }

            Console.WriteLine();
        }
        public bool IsEmpty()
        {
            if (_anchor.Next == null)
                return true;
            else
                return false;
        }
        public Node Find(int index)
        {
            Node current = _anchor;
            int i = 0;

            while (current.Next != null)
            {
                current = current.Next;

                if (i == index)
                    return current;
                else
                    i++;
            }
            
            return null;
        }
        public Node FindPrevious(int index)
        {
            var node = Find(index - 1);
            return node;
        }
        public void InsertAfter(int index, int value)
        {
            var node = Find(index);

            if (node == null)
                return;

            Node newNode = new Node
            {
                Value = value,
                Next = node.Next
            };

            node.Next = newNode;
        }
        public void InsertToStart(int value)
        {
            var node = new Node
            {
                Value = value,
                Next = _anchor.Next
            };
            _anchor.Next = node;
        }
        public int? this[int index]
        {
            get
            {
                var node = Find(index);

                if (node != null)
                    return node.Value;
                else
                    return null;
            }
            set
            {
                var node = Find(index);

                if (node != null)
                    node.Value = (int)value;
            }
        }
        public int Count()
        {
            Node current = _anchor;
            int i = 0;

            while (current.Next != null)
            {
                current = current.Next;
                i++;
            }   

            return i;
        }
        public void Clear()
        {
            _anchor.Next = null;
        }
    }
}

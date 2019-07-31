using System;

namespace DataStructures
{
    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }
        public override string ToString()
        {
            return string.Format("[{0}]", Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TryLearnedConcepts
{
    public class Node<T>
    {
        //Private member-variables
        private T data;
        private NodeList<T> neighbors = null;

        public Node() { }
        public Node(T data ) : this(data, null) { }
        public Node(T data, NodeList<T> neighbors)
        {
            this.data = data;
            this.neighbors = neighbors;
        }

        public T Value
        {
            get => data;
            set => data = value;
        }

        protected NodeList<T> Neighbors
        {
            get => neighbors;
            set => neighbors = value;
        }
    }
}

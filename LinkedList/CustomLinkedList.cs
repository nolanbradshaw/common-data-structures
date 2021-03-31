
using System;
namespace CommonDataStructures 
{
    public class LinkedListNode<T>
    {
        public T Value;
        public LinkedListNode<T> Next;
        
        public LinkedListNode(T value)
        {
            this.Value = value;
        }
    }


    public class LinkedList<T>
    {
        public LinkedListNode<T> Head;
        public LinkedList()
        {
            this.Head = null;
        }

        public LinkedList<T> Add(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if(this.Head == null)
            {
                this.Head = newNode;
                return this;
            }

            LinkedListNode<T> currentNode = this.Head;
            while(currentNode != null)
            {
                if(currentNode.Next == null)
                {
                    currentNode.Next = newNode;
                    break;
                }

                currentNode = currentNode.Next;
            }

            return this;
        }
    }
}
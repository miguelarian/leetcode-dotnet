namespace LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public class ListNode<T>
    {
        public T value;
        public ListNode<T> next;

        public ListNode()
        {
            this.value = default(T);
            this.next = null;
        }

        public ListNode(T value, ListNode<T> next)
        {
            this.value = value;
            this.next = next;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is ListNode<T> node &&
                   EqualityComparer<T>.Default.Equals(value, node.value);
        }

        public string PrintList()
        {
            string result = this.ToString();
            if(this.next != null)
            {
                result = $"{result},{this.next.PrintList()}";
            }
            return result;
        }

        public ListNode<T> Add(ListNode<T> node)
        {
            ListNode<T> pointer = this;

            while(pointer.next != null)
            {
                pointer = pointer.next;
            }

            pointer.next = node;
            return this;
        }

        public ListNode<T> Remove(ListNode<T> node)
        {
            ListNode<T> pointer = this;
            ListNode<T> previous = null;

            while (pointer != null)
            {
                if (pointer.Equals(node))
                {
                    if(previous != null)
                    {
                        previous.next = pointer.next;
                        return this;
                    }
                    else
                    {
                        previous = this.next;
                        return previous;
                    }
                }

                previous = pointer;
                pointer = pointer.next;
            }

            return this;
        }

        public ListNode<T> Reverse()
        {
            if(this.Length == 1)
            {
                return this;
            }

            ListNode<T> previous = null;
            ListNode<T> current = this;
            ListNode<T> next = null;
            
            while(current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }

        public int Length
        {
            get
            {
                int length = 0;

                ListNode<T> pointer = this;

                while(pointer != null)
                {
                    length++;
                    pointer = pointer.next;
                }

                return length;
            }
        }
    }
}

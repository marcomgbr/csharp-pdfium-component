using System;
using System.Collections;
using System.Collections.Generic;

namespace MMG.Utils
{
    /// <summary>
    /// A stack where, when maxLength is reached, the elements rotate, removing one element from the base for each element added to the top.
    /// </summary>
    /// <typeparam name="T">The type that stack will contain</typeparam>
    public class RotationStack<T> : List<T>
    {
        int maxSize = 0;
        
        public RotationStack(int maxSize) : base()
        {
            this.maxSize = maxSize;
        }

        /// <summary>
        /// Adds an element to the top of stack.
        /// </summary>
        /// <param name="item"></param>
        public new void Add(T item)
        {
            if (Contains(item))
            {
                Remove(item);
            }
            else
            {
                if (Count >= maxSize)
                {
                    RemoveAt(Count - 1);
                }
            }
            Insert(0, item);
        }

        /// <summary>
        /// Removes an element from the top of the stack.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T response = this[0];
            RemoveAt(0);
            return response;
        }
    }
}

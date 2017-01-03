using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public object Pop()
        {

            if (_stack.Count <= 0)
                throw new InvalidOperationException("The Stack is Empty");

            var removedNum = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return removedNum;

        }

        public void Push(object obj)
        {
            _stack.Add(obj);

        }

        public void Clear()
        {
            if (_stack.Count <= 0)
                throw new InvalidOperationException("The Stack is Empty");

            _stack.Clear();
        }

    }
}

using System;
using System.Collections.Generic;

namespace DesignStackExercise
{
    class Stack
    {
        List<object> _stack;
        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj != null)
                _stack.Add(obj);
            else
                throw new System.InvalidOperationException("Parameter cannot be null");
        }

        public object Pop()
        {
            if (_stack.Count > 0)
            {
                object obj = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count - 1);
                return obj;
            }
            else
                throw new System.InvalidOperationException("Stack is empty");
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}

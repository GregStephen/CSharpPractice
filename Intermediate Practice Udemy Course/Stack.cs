using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class Stack
    {
        private List<object> _stack = new List<object>(); 
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot add type null to stack");
            }
            _stack.Insert(0, obj);

        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Nothing to pop!");
            }
            var objToReturn = _stack[0];
            _stack.RemoveAt(0);
            return objToReturn;
        }

        public void Clear()
        {
            _stack.Clear();
        }

    }
}

using System;
using System.Collections.Generic;

namespace InheritanceExer
{
    
    public class Stack
    {
        
        private readonly Dictionary<int, object> _dictionary;

        public int Index { get; private set; }   


        public void Push(object obj)
        {
            if (obj != null)
            {

                
                _dictionary[Index] = obj;
                
                Index++;
             

            }
            else
            {
                throw new InvalidOperationException("Stopwatch is running");
            }

        }
        public object Pop()
        {
            var index = Index - 1;
            object text;

            if (Index != 0)
            {
                text = _dictionary[index];
                _dictionary[index] = null;
                Index--;

            }
            else
            {
                throw new InvalidOperationException("Stopwatch is running");
            }
            return text;
        }

        public Stack()
        {
            _dictionary = new Dictionary<int, object>();

        }
        

        public void Clear()
        {
            if (Index != 0)
            {
                for (int i = Index; i > 0 ; i--)
                {
                    var indexs = i - 1;
                    _dictionary[indexs] = null;
                    if (i == 1)
                    {
                        Index = 0;
                        Console.WriteLine("Cleared");
                    }
                }
            }
            else
            {
                Console.WriteLine("Already Cleared");
            }
            
            
        }
    }
}
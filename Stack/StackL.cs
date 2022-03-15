using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class StackL
    {
        private int size = 10;
        private int spaceUsed = 0;
        private int[] stack;
        public StackL(int expsize)
        {
             size = expsize;
             stack = new int[size];
        }
        public void Push(int value)
        {
            stack[spaceUsed] = value;
            spaceUsed++;
            if(size == spaceUsed)
            {
                size += 10;
                int[] newStack = new int[size];
                for(int i = 0; i < stack.Length; i++)
                {
                    newStack[i] = stack[i];
                }
                stack = newStack;
            }
        }
        public int Pop()
        {
            int stackPop;
            spaceUsed--;
            stackPop = stack[spaceUsed];
            return stackPop;          
        }
        public void Clear()
        {
            spaceUsed = 0;
        }
        public int Length()
        {
            return spaceUsed;
        }
        
    }
}

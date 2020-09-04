using System;

namespace cciProblemSolving
{
    public class FixedMultiStack
    {
        private int numberOfStacks = 3;
        public int stackCapacity { get; set; }
        private int[] values { get; set; }
        private int[] sizes { get; set; }
        public FixedMultiStack(int stackSize)
        {
            stackCapacity = stackSize;
            values = new int[stackSize * numberOfStacks];
            sizes = new int[numberOfStacks];
        }
        public void push(int stackNum, int value)
        {
            if (isFull(stackNum))
            {
                System.Console.WriteLine("stack is full");
            }
            /*Increment stack pointer and then update top value. */
            sizes[stackNum]++;
            values[indexOfTop(stackNum)] = value;
        }

        /* Pop item from top stack. */
        public int pop(int stackNum)
        {
            if (isEmpty(stackNum))
            {
                System.Console.WriteLine("stach is empty");
            }
            int topIndex = indexOfTop(stackNum);
            int value = values[topIndex]; // Get top values[topindex] = 0; 
            values[topIndex] = 0; // Clear
            sizes[stackNum]--; // Shrink
            return value;
        }
        public int peek(int stackNum)
        {
            if (isEmpty(stackNum))
            {
                System.Console.WriteLine("stack is empty"); ;
            }
            return values[indexOfTop(stackNum)];
        }
        /* Return if stack is empty. */
        public Boolean isEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }
        /* Return if stack is full. */
        public Boolean isFull(int stackNum)
        {

            return sizes[stackNum] == stackCapacity;
        }
        /* Returns index of the top of the stack. */
        private int indexOfTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];
            return offset + size - 1;
        }
    }


}
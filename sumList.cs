using System;
using System.Text;

namespace Problems
{
    class sumList
    {

        public static LinkedList<char> SumList(LinkedList<int> firsDigits, LinkedList<int> secondDigits)
        {
            StringBuilder firsDigit = listToDigit(firsDigits);
            StringBuilder secondDigit = listToDigit(secondDigits);
            int sum = Convert.ToInt32(firsDigit.ToString()) + Convert.ToInt32(secondDigit.ToString());
            StringBuilder resultt = new StringBuilder(sum.ToString());
            LinkedList<char> result = digitToList(resultt);
            static LinkedList<char> digitToList(StringBuilder Number)
            {
                LinkedList<char> listOfNumbers = new LinkedList<char>();
                for (int i = Number.Length - 1; i >= 0; i--)
                {
                    listOfNumbers.AddLast(Number[i]);
                }
                return listOfNumbers;
            }
            StringBuilder listToDigit(LinkedList<int> listOfNumber)
            {
                StringBuilder Digit = new StringBuilder();
                while (listOfNumber.Tail != null)
                {
                    Digit.Append(listOfNumber.Tail.Value);

                    listOfNumber.Tail = listOfNumber.Tail.Previous;
                }
                return Digit;
            }
            return result;
        }
    }
}
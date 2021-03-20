using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTempConsoleApp
{
    public class Temperature : ITemperature
    {
        /// <summary>
        ///  Method to determine how many days required to wait for the next  warmer temperature 
        /// </summary>
        /// <param name="tempArray"></param>
        /// <returns></returns>
        public int[] CalculateDaysForNextTemperatureRise(int[] tempArray)
        {
            int tempLength = tempArray.Length;
            // To store the answer 
            int[] daysOfWait = new int[tempLength];
            try
            {
                for (int i = 0; i < tempLength; i++)
                    daysOfWait[i] = 0;

                Stack<int> tempStack = new Stack<int>();

                // Traverse all the temperatures 
                for (int i = 0; i < tempLength; i++)
                {
                    // Check if current index is the next warmer temperature of any previous indexes 
                    while (tempStack.Count != 0 && tempArray[tempStack.Peek()] < tempArray[i])
                    {
                        daysOfWait[tempStack.Peek()] = i - tempStack.Peek();

                        // Pop the element 
                        tempStack.Pop();
                    }
                    // Push the current index 
                    tempStack.Push(i);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return daysOfWait;
        }
    }
}

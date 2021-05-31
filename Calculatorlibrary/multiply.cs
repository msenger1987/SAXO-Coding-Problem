using System;

namespace Calculatorlibrary
{
    public class multiply : IOperations
    {
        protected static int counter = 0;        
        public multiply()
        {
            
        }
        public int performCalculation(string numbers)
        {
            int result = 1;
            string[] str = numbers.ToString().Split(new char[] {','});
            for(int i=0; i < str.Length; i++)
             {
                 result = result * Convert.ToInt32(str[i]);
             }
             return result;
        }

        public virtual void increaseCount()
        {
            counter++;
        }
        public virtual int count()
        {
            return counter;
        }
    }
}

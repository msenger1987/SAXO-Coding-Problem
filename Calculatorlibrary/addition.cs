using System;

namespace Calculatorlibrary
{
public class addition :IOperations
    {
        protected static int counter = 0;
        public addition()
        {
            
        }
        public int performCalculation(string numbers)
        {
            int result = 0;
            string[] str = numbers.ToString().Split(new char[] {','});
            for(int i=0; i < str.Length; i++)
             {
                 result += Convert.ToInt32(str[i]);
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
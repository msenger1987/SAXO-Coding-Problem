namespace Calculatorlibrary
{
    public class sum : addition
    {
         public sum()
        {
            
        }

        public override void increaseCount()
        {
            counter++;
        }
        public override int count()
        {
            return counter;
        }
    }
}
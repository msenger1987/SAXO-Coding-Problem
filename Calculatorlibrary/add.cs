namespace Calculatorlibrary
{
    public class add : addition
    {
        public add()
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
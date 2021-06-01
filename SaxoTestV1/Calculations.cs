using System;

namespace SaxoTestV1
{
    public class Calculations
    {
        public Calculations()
        {
            
        }

    public string[] GetCommandParameters(string input)
    {
     return input.Split(new char[] {' '});
    }
    public  int GetCommandCount(string[] command)
    {
        dynamic op;
        op = CommandParser.GetCommand(command[1]);
        return op.count();       
    }

    public int DoOperation(string[] command)
    {
        IOperations op = (IOperations)CommandParser.GetCommand(command[0]);
        op.increaseCount();
        return op.performCalculation(command[1]);
    }
 }
}

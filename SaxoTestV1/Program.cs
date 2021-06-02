using System;
using Calculatorlibrary;
using System.IO;
using System.Reflection;

namespace SaxoTestV1
{
    public class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Input command"); 
        
         string input = Console.ReadLine();
         Calculations calc = new Calculations();
         do
         {
          string[] command = calc.GetCommandParameters(input);
          if (Convert.ToString(command[0]) != "count")
            {
                Console.WriteLine(calc.DoOperation(command));
            }
            else{
                Console.WriteLine(calc.GetCommandCount(command));
            }
           input = Console.ReadLine();
        }while(input != string.Empty);
    }
}
}

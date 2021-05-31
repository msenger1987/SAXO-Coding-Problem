using System;
using System.IO;
using System.Reflection;
using Calculatorlibrary;

namespace SaxoTestV1
{
    public static class CommandParser
    {
        private static readonly Assembly asem;
        private static readonly string assemblyName;
        static CommandParser()
        {
         var dllfile = new FileInfo(@"Calculatorlibrary.dll");
         asem =  Assembly.LoadFile(dllfile.FullName);
         assemblyName = asem.GetName().Name;
        }
        public static dynamic GetCommand(string command)
        {
         command = string.Concat(assemblyName,'.',command);
         return asem.CreateInstance(command);
        }
    }
}
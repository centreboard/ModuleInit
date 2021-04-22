using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class Class1
    {
        [ModuleInitializer]
        internal static void ModuleInitializer() {
            Console.WriteLine("Class Lib ModuleInitializer");
        }
    }
    
    
}

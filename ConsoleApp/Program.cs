using System;
using System.Runtime.CompilerServices;

using ClassLibrary;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            new Class1();
        }

        [ModuleInitializer]
        internal static void ModuleInitializer() {
            Console.WriteLine("Console App ModuleInitializer");
        }
    }
}
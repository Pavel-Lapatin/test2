using System;
using Nancy.ModelBinding;

namespace HiddenVarnulableLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new VulnerableLibraries.Modules.FooModule();
            Console.WriteLine($"{model.Context}");
        }
    }
}

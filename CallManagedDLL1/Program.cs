using System;
using System.Reflection;
using EngineInterface;

namespace CallManagedDLL1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly engineAssembly = Assembly.LoadFrom("Engine.dll");
            Type type = engineAssembly.GetType("EngineSDK.Engine");
            IEngine engine = (IEngine)Activator.CreateInstance(type);

            engine.SetSomething("Long live the new text.");
            Console.WriteLine("Text set to: " + engine.GetSomething());
            engine.PrintSomething();
            Console.ReadLine();
        }
    }
}

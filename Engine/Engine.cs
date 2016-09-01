using System;
using EngineInterface;

namespace EngineSDK
{
    public class Engine : IEngine
    {
        private string text;

        public void SetSomething(string text)
        {
            this.text = text;
        }

        public string GetSomething()
        {
            return text;
        }

        public void PrintSomething()
        {
            Console.WriteLine("uhhh: " + text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineInterface
{
    public interface IEngine
    {
        void SetSomething(string text);
        string GetSomething();
        void PrintSomething();
    }
}

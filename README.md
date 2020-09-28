# EasyAntiDebug
C# Visual Studio Library for AntiDebugging

# How to use

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyAntiDebug;

namespace AntiDebugCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AntiDebugger.isDebugging() ? "Debugger found." : "Not debugging.");
            Console.ReadKey(true);
        }
    }
}
```

"isDebugging" method returns a boolean, either true or false, related to the actual debugger presence.

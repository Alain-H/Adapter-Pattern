using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_pattern
{
    internal class Quadrat : IZeichnen
    {
        public void draw()
        {
            Console.WriteLine("Es wird ein Quadrat gezeichnet");
        }
    }
}

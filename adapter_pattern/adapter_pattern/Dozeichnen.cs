using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_pattern
{
    internal class Dozeichnen
    {
        public IZeichnen kreis;
        public IZeichnen paralellogram;
        public IZeichnen quadrat;


        public Dozeichnen()
        {
            kreis = new Kreis();
            paralellogram = new Paralellogram();
            quadrat = new Quadrat();
        }

        public void ZeichneKreis()
        {
            kreis.draw();
        }

        public void ZeichneParalellogram()
        {
            paralellogram.draw();
        }

        public void ZeichneQuadrat()
        {
            quadrat.draw();
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    class Dado
    {
        private static Random ran;

        public Dado()
        {
            ran = new Random();
        }

        public int lanzar()
        {
            return ran.Next(1, 7);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    class Player
    {
        private int _pos;
        private bool _gano;

        public bool Gano
        {
            get { return _gano; }
            set { _gano = value; }
        }

        public int Pos
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public Player()
        {
            _pos = 0;
            _gano = false;
        }
    }
}

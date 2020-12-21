using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWalks.Functionality
{
    class HadamardWalk
    {
        private readonly State startState;
        public Grid1D Grid { get; set; }

        public HadamardWalk(State startState)
        {
            this.startState = startState;
        }

        public HadamardWalk(double up, double down)
        {
            this.startState = new State(up, down);
            this.Grid = new Grid1D(startState);
        }

        public void Step()
        {
            
        }
    }
}

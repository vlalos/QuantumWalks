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
        public List<State> Grid { get; set; }

        public HadamardWalk(State startState)
        {
            this.startState = startState;
        }

        public HadamardWalk(double up, double down)
        {
            this.startState = new State(up, down);
        }

        public void InitializeGrid(int width, int dimension)
        {
            if (dimension == 1)
            {
                this.Grid = new List<State>();
                for(int i = -width; i < 0; i++)
                {
                    this.Grid.Add(new State(0, 0));
                }

                this.Grid.Add(startState);

                for(int i = 1; i <= width; i++)
                {
                    this.Grid.Add(new State(0, 0));
                }
            }
        }

        public void Step()
        {
            
        }
    }
}

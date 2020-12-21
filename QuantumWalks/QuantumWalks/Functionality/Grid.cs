using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWalks.Functionality
{
    /// <summary>
    /// linear grid of states
    /// </summary>
    public class Grid1D 
    {
        public State Start { get; set; }
        public Grid1D Next { get; set; }
        public Grid1D Prev { get; set; }

        public Grid1D(State start)
        {
            this.Start = start;
        }

        public Grid1D(State start, Grid1D next)
        {
            this.Start = start;
            this.Next = next;
        }

        public Grid1D(State start, Grid1D next, Grid1D prev)
        {
            this.Start = start;
            this.Next = next;
            this.Prev = prev;
        }

        public void Step()
        {
            if (this.Next == null)
            {
                this.Next = new Grid1D(State.GetZero());
            }
            this.Next.Start.Up += this.Start.Up;

            if (this.Prev == null)
            {
                this.Prev = new Grid1D(State.GetZero());
            }
            this.Prev.Start.Down += this.Start.Down;

            this.Start = new State(0, 0);
        }
    }
}

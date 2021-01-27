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
            // recursive step to the left
            if (this.Next == null)
            {
                this.Next = new Grid1D(State.GetZero());
            }
            this.Next.Start.Up += this.Start.Up;

            if (this.Next.Next != null)
            {
                this.Next.Next.Step();
            }

            // recursive step to the right
            if (this.Prev == null)
            {
                this.Prev = new Grid1D(State.GetZero());
            }
            this.Prev.Start.Down += this.Start.Down;

            if (this.Prev.Prev != null)
            {
                this.Prev.Prev.Step();
            }


            this.Start = new State(0, 0);
        }

        public void Coin()
        {
            if (this.Next != null)
            {
                this.Next.Start.HadamardCoin();
            }

            this.Start.HadamardCoin();

            if (this.Prev != null)
            {
                this.Prev.Start.HadamardCoin();
            }
        }

        public List<double> GetGridProbability()
        {
            List<double> probabilities = new List<double>();

            return probabilities;
        }
    }
}

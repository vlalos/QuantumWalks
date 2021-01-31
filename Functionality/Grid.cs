using QuantumWalks.States;
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
        public Grid1D Right { get; set; }
        public Grid1D Left { get; set; }
        
        public bool EvenStep { get; set; }

        #region Constructors

        public Grid1D(State startState)
        {
            this.Start = startState;
            this.Right = null;
            this.Left = null;
        }

        public Grid1D(Complex startUp, Complex startDown)
        {
            this.Start = new State(startUp, startDown);
            this.Right = null;
            this.Left = null;
        }

        public Grid1D(State start, Grid1D right, Grid1D left)
        {
            this.Start = start;
            this.Right = right;
            this.Left = left;
        }

        #endregion

        public void Step()
        {
            //recursive to the left
            if (this.Left == null)
            {
                this.Left = new Grid1D(new State(new Complex(), this.Start.Down)); //Down 
                this.Start.Down = new Complex();
            }

            //recursive to the right
            if (this.Right == null)
            {
                this.Right = new Grid1D(new State(this.Start.Up, new Complex())); //Up 
                this.Start.Up = new Complex();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWalks.States
{
    public class State
    {
        public Complex Up { get; set; }
        public Complex Down { get; set; }

        #region Constructors

        public State()
        {
            this.Up = new Complex();
            this.Down = new Complex();
        }

        public State(Complex up, Complex down)
        {
            this.Up = up;
            this.Down = down;
        }

        public State(double up, double down)
        {
            this.Up = new Complex(up, 0);
            this.Down = new Complex(down, 0);
        }
        #endregion

        #region Operators

        public static State operator*(State a, double b)
        {
            State result = new State();

            result.Up = a.Up * b;
            result.Down = a.Down * b;

            return result;

        }

        public static State operator*(State a, Complex b)
        {
            State result = new State();

            result.Up = a.Up * b;
            result.Down = a.Down * b;

            return result;

        }

        public static Complex operator*(State a, State b)
        {
            return a.Up * b.Up + a.Down * b.Down;
        }

        public static State operator*(Matrix m, State b)
        {
            return new State(m.Up * b, m.Down * b);
        }

        #endregion

        public double GetProbability()
        {
            return Up.AmpSquare() + Down.AmpSquare();
        }

        public void Normalize()
        {
            this.Up = this.Up / Math.Sqrt(GetProbability());
            this.Down = this.Down / Math.Sqrt(GetProbability());
        }

        public void SetUp()
        {
            this.Up = new Complex(1, 0);
            this.Down = new Complex(0, 1);
        }

        public void SetDown()
        {
            this.Up = new Complex(0, 1);
            this.Down = new Complex(1, 0);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWalks.Functionality
{
    public class State
    {
        public double Up { get; set; }
        public double Down { get; set; }

        public State(double up, double down)
        {
            this.Up = up;
            this.Down = down;
        }

        public double GetProbability()
        {
            return Up * Up + Down * Down;
        }

        public void HadamardCoin()
        {
            double newUp = (Up + Down) / Math.Sqrt(2);
            double newDown = (Up - Down) / Math.Sqrt(2);

            this.Up = newUp;
            this.Down = newDown;
        }

        public static State GetZero()
        {
            return new State(0, 0);
        }
    }
}

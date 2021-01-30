using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWalks.States
{
    public class Matrix
    {
        public State Up { get; private set; }
        public State Down { get; private set; }

        #region Constructors

        // [ a b ] Up
        // [ c d ] Down
        public Matrix(Complex a, Complex b, Complex c, Complex d)
        {
            this.Up = new State(a, b);
            this.Down = new State(c, d);
        }

        public Matrix()
        {
            this.Up = new State(1, 0);
            this.Down = new State(0, 1);
        }

        public Matrix(double a, double b, double c, double d)
        {
            this.Up = new State(a, b);
            this.Down = new State(c, d);
        }

        #endregion

        #region Operators
        
        public static Matrix operator*(Matrix m, Complex b)
        {
            Matrix result = new Matrix();

            result.Up = m.Up * b;
            result.Down = m.Down * b;

            return result;
        }

        public static Matrix operator*(Matrix m, double b)
        {
            Matrix result = new Matrix();

            result.Up = m.Up * b;
            result.Down = m.Down * b;

            return result;
        }

        #endregion

        public static Matrix HadamardMatrix()
        {
            return new Matrix(1, 1, 1, -1) * (1 / Math.Sqrt(2));
        }
    }
}

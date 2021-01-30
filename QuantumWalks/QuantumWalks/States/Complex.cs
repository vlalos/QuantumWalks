using System;

namespace QuantumWalks.States
{
    public class Complex
    {
        public double Real { get; protected set; }
        public double Imag { get; protected set; }

        #region Constructors

        public Complex()
        {

            this.Real = 0;
            this.Imag = 0;
        }

        public Complex(double number)
        {
            this.Real = number;
            this.Imag = 0;
        }

        public Complex(double Real, double Imag)
        {
            this.Real = Real;
            this.Imag = Imag;
        }
        #endregion

        #region Operators
        public static Complex operator +(Complex a, Complex b)
        {
            Complex result = new Complex();

            result.Real = a.Real + b.Real;
            result.Imag = a.Real + b.Real;

            return result;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex result = new Complex();

            result.Real = a.Real - b.Real;
            result.Imag = a.Real - b.Real;

            return result;
        }

        public static Complex operator *(Complex a, double b)
        {
            Complex result = new Complex();

            result.Real = a.Real * b;
            result.Imag = a.Imag * b;

            return result;
        }

        public static Complex operator *(double b, Complex a)
        {
            Complex result = new Complex();

            result.Real = a.Real * b;
            result.Imag = a.Imag * b;

            return result;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex result = new Complex();

            result.Real = a.Real * b.Real - a.Imag * b.Imag;
            result.Imag = a.Real * b.Imag - b.Real * a.Imag;

            return result;
        }

        public static Complex operator /(Complex a, double b)
        {
            Complex result = new Complex();

            result.Real = a.Real / b;
            result.Imag = a.Imag / b;

            return result;
        }
        #endregion

        public double Modulus()
        {
            return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imag, 2));
        }

        public double AmpSquare()
        {
            return Math.Pow(Real, 2) + Math.Pow(Imag, 2);
        }

 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonky_Maths
{
    class WonkyMaths
    {
        //attributes

        //member functions
        //add function int
        public int Add (int a)
        {
            return a;
        }
        public int Add (int a, int b)
        {
            return Convert.ToInt32(this.Add(Convert.ToSingle(a), Convert.ToSingle(b)));
        }
        public int Add(int a, int b, int c)
        {
            return Convert.ToInt32(this.Add(Convert.ToSingle(a), Convert.ToSingle(b), Convert.ToSingle(c)));
        }
        //add function float
        public float Add (float a)
        {
            return a;
        }
        public float Add (float a, float b)
        {
            return a + b;
        }
        public float Add (float a, float b, float c)
        {
            return a + b + c;
        }
        //add function double
        public double Add(double a)
        {
            return a;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        //constructors
        public WonkyMaths() { }
    }
}

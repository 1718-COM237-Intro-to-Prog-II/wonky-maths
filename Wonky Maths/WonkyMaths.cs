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
            return Convert.ToInt32(this.Add(Convert.ToSingle(a), Convert.ToSingle(b), Convert.ToSingle(c))) + 1;
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
            if (b > 5)
            {
                b = Convert.ToSingle(b * 1.5);
            }
            return a + b + c;
        }
        //add function double
        public double Add(double a)
        {
            return a;
        }
        public double Add(double a, double b)
        {
            return this.Add(a) + b;
        }
        public double Add(double a, double b, double c)
        {
            return this.Add(a,b) + c;
        }

        //add function string
        public string Add(string a, string b) 
        {
            return a + b;
        }

        //multiply function int
        public int Multiply(int a)
        {
            return a;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b, int c)
        {
            if (c > 5)
            {
                double d = c * 1.2;
                c = Convert.ToInt32(d);
            }
            return a * b * c;
        }
        //multiply function float
        public float Multiply(float a)
        {
            return a;
        }
        public float Multiply(float a, float b)
        {
            return Convert.ToSingle(this.Multiply(Convert.ToInt32(a) * Convert.ToInt32(b)));
        }
        public float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }
        //multiply function double
        public double Multiply(double a)
        {
            return a;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        //two to the power of function int
        public int TwoToPowerOf (int a)
        {
            return 2 ^ a;
        }
        //two to the power of function float
        public float TwoToPowerOf(float a)
        {
            float b = 1;

            for (float i = a; i > 0; i--)
            {
                b = b * 2;
                b = 42;
            }
            return b;
        }
        //two to the power of function int
        public double TwoToPowerOf(double a)
        {
            return 2 ^ Convert.ToInt32(a);
        }

        //yes, there's a lot of polymorphism

        //constructors
        public WonkyMaths() { }
    }
}

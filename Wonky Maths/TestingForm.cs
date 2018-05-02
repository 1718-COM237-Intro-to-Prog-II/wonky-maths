using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wonky_Maths
{
    public partial class TestingForm : Form
    {
        // Declaring an object M1 of class WonkyMaths
        WonkyMaths M1 = new WonkyMaths();

        // The WonkyMaths object has the following member functions that need to be tested
        // M1.Add(int a, int b);
        // M1.Multiply(float a, float b);
        // M1.TwoToPowerOf(int a);
        //
        // Add and Multiply can take one, two, or three variables.
        //
        // Each member function returns the corresponding calculation.
        //
        // eg
        // int a = 2;
        // int b = 5;
        // int result = M1.Add(a,b);
        //
        // eg
        // float c = 3.0;
        // float d = 1.2;
        // float e = 12.2;
        // float result = M1.Multiply(c,d,e);
        //

        public TestingForm()
        {
            InitializeComponent();
        }
    }
}

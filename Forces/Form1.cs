using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        double sin(double x)
            {
                return (Math.Sin(x* Math.PI / 180.0));
            }

    double asin(double x)
            {
                return (Math.Asin(x* Math.PI / 180.0));
            }

double cos(double x)
            {
                return (Math.Cos(x* Math.PI / 180.0));
            }

            double acos(double x)
            {
                return (Math.Acos(x* Math.PI / 180.0));
            }

            double tan(double x)
            {
                return (Math.Tan(x* Math.PI / 180.0));
            }

            double atan(double x)
            {
                return (Math.Atan(x* Math.PI / 180.0));
            }
        }
    }


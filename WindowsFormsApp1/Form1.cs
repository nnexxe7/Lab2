using Lab2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();

            try
            {
                double RealA = double.Parse(textBox1.Text);
                double ImaginaryA = double.Parse(textBox2.Text);
                double RealB = double.Parse(textBox3.Text);
                double ImaginaryB = double.Parse(textBox4.Text);

                ComplexNumber numberA = new ComplexNumber { Real = RealA, Imaginary = ImaginaryA };
                ComplexNumber numberB = new ComplexNumber { Real = RealB, Imaginary = ImaginaryB };

                ComplexNumber result = client.Add(numberA, numberB);

                label1.Text = $"Real: {result.Real}, Imaginary: {result.Imaginary}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }

        }
    }
}

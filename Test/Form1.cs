using System;
using System.Windows.Forms;
using TestMyLib;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TriangleSquare triangle = new TriangleSquare();
            string[] masText = textBox2.Text.Split(' ');
            textBox2.Text = triangle.Sides(new double[] { Convert.ToDouble(masText[0]), Convert.ToDouble(masText[1]), Convert.ToDouble(masText[2]) }).ToString();
            label4.Text = triangle.TriangleIsRectangular();
            
            if (triangle.СorrectnessTriangle())            
                label5.Text = "Треугольник прямоугольный";
            else
                label5.Text = "Треугольник не прямоугольный";
        }
        private void button2_Click(object sender, EventArgs e)
        {           
            CircleSquare fihure = new CircleSquare();
            textBox1.Text = fihure.Sides(new double[] { Convert.ToDouble(textBox1.Text) });
        }
    }
}

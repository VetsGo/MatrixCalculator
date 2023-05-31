using System;
using System.Linq;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double[,] ParseMatrixA()
        {
            double[,] matrix = new double[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = double.Parse(this.Controls["textBox" + (i * 3 + j + 1)].Text);
                }
            }
            return matrix;
        }
        public double[,] ParseMatrixB()
        {
            double[,] matrix = new double[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = double.Parse(this.Controls["textBox" + (i * 3 + j + 10)].Text);
                }
            }
            return matrix;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                label6.Text = "Fill all boxes!!!!";
            }
            else
            {
                label6.Text = "";
                label10.Text = "";
                label8.Text = "";
                double[,] matrix;

                try
                {
                    matrix = ParseMatrixA();
                }
                catch
                {
                    label6.Text = "Only numbers!!!";
                    return;
                }

                double determA = 0;

                for (int i = 0; i < 3; i++)
                {
                    determA += matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
                }
                textBox28.Text = determA.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                label7.Text = "Fill all boxes!!!!";
            }
            else
            {
                label7.Text = "";
                label10.Text = "";
                label9.Text = "";
                double[,] matrix;

                try
                {
                    matrix = ParseMatrixB();
                }
                catch
                {
                    label7.Text = "Only numbers!!!";
                    return;
                }

                double determB = 0;

                for (int i = 0; i < 3; i++)
                {
                    determB += matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
                }
                textBox29.Text = determB.ToString();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                TextBox textBox = Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 10; i <= 18; i++)
            {
                TextBox textBox = Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                label6.Text = "Fill all boxes!!!!";
            }
            else
            {
                label6.Text = "";
                label10.Text = "";
                label8.Text = "";
                double[,] valA;

                try
                {
                    valA = ParseMatrixA();
                }
                catch
                {
                    label6.Text = "Only numbers!!!";
                    return;
                }

                Complex[,] amatrix = new Complex[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        amatrix[i, j] = new Complex(valA[i, j], 0);
                    }
                }

                Matrix<Complex> matrixA = Matrix<Complex>.Build.DenseOfArray(amatrix);
                int rank = matrixA.Rank();
                textBox28.Text = rank.ToString();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                label7.Text = "Fill all boxes!!!!";
            }
            else
            {
                label7.Text = "";
                label10.Text = "";
                label9.Text = "";
                double[,] valB;

                try
                {
                    valB = ParseMatrixB();
                }
                catch
                {
                    label7.Text = "Only numbers!!!";
                    return;
                }

                Complex[,] bmatrix = new Complex[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        bmatrix[i, j] = new Complex(valB[i, j], 0);
                    }
                }

                Matrix<Complex> matrixB = Matrix<Complex>.Build.DenseOfArray(bmatrix);
                int rank = matrixB.Rank();
                textBox29.Text = rank.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                label6.Text = "Fill all boxes!!!!";
            }
            else
            {
                label6.Text = "";
                label10.Text = "";
                label8.Text = "";
                double[,] valA;

                try
                {
                    valA = ParseMatrixA();
                }
                catch
                {
                    label6.Text = "Only numbers!!!";
                    return;
                }

                double[,] result = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[j, i] = valA[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        this.Controls["textBox" + (i * 3 + j + 19)].Text = result[i, j].ToString();
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                label7.Text = "Fill all boxes!!!!";
            }
            else
            {
                label7.Text = "";
                label10.Text = "";
                label9.Text = "";
                double[,] valB;

                try
                {
                    valB = ParseMatrixB();
                }
                catch
                {
                    label7.Text = "Only numbers!!!";
                    return;
                }

                double[,] result = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[j, i] = valB[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        this.Controls["textBox" + (i * 3 + j + 19)].Text = result[i, j].ToString();
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                label6.Text = "Fill all boxes!!!!";
            }
            else
            {
                label6.Text = "";
                label10.Text = "";
                double[,] matrix;

                try
                {
                    matrix = ParseMatrixA();
                }
                catch
                {
                    label6.Text = "Only numbers!!!";
                    return;
                }

                double det = 0;

                for (int i = 0; i < 3; i++)
                {
                    det += matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
                }

                if (det == 0)
                {
                    label8.Text = "Matrix A is not invertible";
                }
                else
                {
                    label8.Text = "";
                    double[,] invMatrix = new double[3, 3];

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            double cof = ((i + j) % 2 == 0 ? 1 : -1) * (
                                (matrix[(j + 1) % 3, (i + 1) % 3] * matrix[(j + 2) % 3, (i + 2) % 3]) -
                                (matrix[(j + 1) % 3, (i + 2) % 3] * matrix[(j + 2) % 3, (i + 1) % 3])
                            );
                            invMatrix[i, j] = cof / det;
                        }
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            this.Controls["textBox" + (i * 3 + j + 19)].Text = invMatrix[i, j].ToString("0.000");
                        }
                    }
                }
            }     
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                label7.Text = "Fill all boxes!!!!";
            }
            else
            {
                label7.Text = "";
                label10.Text = "";
                double[,] matrix;

                try
                {
                    matrix = ParseMatrixB();
                }
                catch
                {
                    label7.Text = "Only numbers!!!";
                    return;
                }

                double det = 0;

                for (int i = 0; i < 3; i++)
                {
                    det += matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
                }

                if (det == 0)
                {
                    label9.Text = "Matrix B is not invertible";
                }
                else
                {
                    label9.Text = "";
                    double[,] invMatrix = new double[3, 3];

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            double cof = ((i + j) % 2 == 0 ? 1 : -1) * (
                                (matrix[(j + 1) % 3, (i + 1) % 3] * matrix[(j + 2) % 3, (i + 2) % 3]) -
                                (matrix[(j + 1) % 3, (i + 2) % 3] * matrix[(j + 2) % 3, (i + 1) % 3])
                            );
                            invMatrix[i, j] = cof / det;
                        }
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            this.Controls["textBox" + (i * 3 + j + 19)].Text = invMatrix[i, j].ToString("0.000");
                        }
                    }
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                label10.Text = "Fill all boxes!!!!";
            }
            else
            {
                label10.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                double[,] matrix1;
                double[,] matrix2;

                try
                {
                    matrix1 = ParseMatrixA();
                    matrix2 = ParseMatrixB();
                }
                catch
                {
                    label10.Text = "Only numbers!!!";
                    return;
                }

                double[,] result = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        this.Controls["textBox" + (i * 3 + j + 19)].Text = result[i, j].ToString();
                    }
                }  
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                label10.Text = "Fill all boxes!!!!";
            }
            else
            {
                label10.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                double[,] matrix1;
                double[,] matrix2;

                try
                {
                    matrix1 = ParseMatrixA();
                    matrix2 = ParseMatrixB();
                }
                catch
                {
                    label10.Text = "Only numbers!!!";
                    return;
                }

                double[,] result = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        this.Controls["textBox" + (i * 3 + j + 19)].Text = result[i, j].ToString();
                    }
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                label10.Text = "Fill all boxes!!!!";
            }
            else
            {
                label10.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                double[,] matrix1;
                double[,] matrix2;

                try
                {
                    matrix1 = ParseMatrixA();
                    matrix2 = ParseMatrixB();
                }
                catch
                {
                    label10.Text = "Only numbers!!!";
                    return;
                }

                double[,] result = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        this.Controls["textBox" + (i * 3 + j + 19)].Text = result[i, j].ToString();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 19; i <= 29; i++)
            {
                TextBox textBox = Controls.Find("textBox" + i.ToString(), true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.ReadOnly = true;
                }
            }
        }
    }
}
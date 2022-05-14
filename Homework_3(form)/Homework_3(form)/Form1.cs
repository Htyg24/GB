using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void coordA_TextChanged(object sender, EventArgs e)
        {

        }

        void coordB_TextChanged(object sender, EventArgs e)
        {

        }

        void label2_Click(object sender, EventArgs e)
        {

        }
        void button1_Click(object sender, EventArgs e)
        {
            Polindrom();
            GetCube();
            GetDistance();
        }

        void GetCube()
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int i = int.Parse(textBox1.Text);
                string f = "";
                for (int c = 1; c <= i; c++)
                {
                    f += $"{Math.Pow(c, 3)} \n";
                }
                cubes.Text = f;
            }
        }
        void GetDistance()
        {
            if (!string.IsNullOrEmpty(coordA.Text)||!string.IsNullOrEmpty(coordB.Text))
            {
                string[] Acoord = coordA.Text.Split(' ');
                string[] Bcoord = coordB.Text.Split(' ');
                double result = 0;
                for (int i = 0; i < Acoord.Length; i++)
                {
                    result += Math.Pow(int.Parse(Acoord[i]) - int.Parse(Bcoord[i]), 2);
                }
                range.Text = $"{Math.Sqrt(result):f2}";
            }
        }

        void Polindrom()
        {
            if (!string.IsNullOrEmpty(polindrom.Text))
            {
                bool c = true;
                for (int i = 0; i < polindrom.Text.Length; i++)
                    if (polindrom.Text[i] != polindrom.Text[polindrom.Text.Length - i - 1])
                        c = false;
                if (c)
                    answer.Text = "Число является полиндромом";
                else
                    answer.Text = "Число не является полиндромом";
            }
        }

        void label4_Click(object sender, EventArgs e)
        {
             
        }
        //

        void polindrom_TextChanged(object sender, EventArgs e)
        {

        }

        void answer_Click(object sender, EventArgs e)
        {

        }
    }
}

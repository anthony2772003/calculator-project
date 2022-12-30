using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// ---------- made by Anthony Nabil farag  ---------------------
// ---------- code: 20210065 -----------------------------------





namespace calculators
{
    public partial class Form1 : Form
    {
        // Creating button objects
        GuiButtons buttonvalue0 = new GuiButtons("0");
        GuiButtons buttonvalue1 = new GuiButtons("1");
        GuiButtons buttonvalue2 = new GuiButtons("2");
        GuiButtons buttonvalue3 = new GuiButtons("3");
        GuiButtons buttonvalue4 = new GuiButtons("4");
        GuiButtons buttonvalue5 = new GuiButtons("5");
        GuiButtons buttonvalue6 = new GuiButtons("6");
        GuiButtons buttonvalue7 = new GuiButtons("7");
        GuiButtons buttonvalue8 = new GuiButtons("8");
        GuiButtons buttonvalue9 = new GuiButtons("9");
        GuiButtons buttonvaluedot = new GuiButtons(".");
        GuiButtons buttonvalueEqual = new GuiButtons("=");
        GuiButtons buttonvalueplus = new GuiButtons("+");
        GuiButtons buttonvalueminus = new GuiButtons("-");
        GuiButtons buttonvaluetimes = new GuiButtons("x");
        GuiButtons buttonvaluedivision = new GuiButtons("/");


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue0.GetValue();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += buttonvaluedot.GetValue();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Screen.SetValue2(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = Screen.GetResult();
            Calculate.Setoperation("NULL");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue1.GetValue();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue2.GetValue();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue3.GetValue();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue4.GetValue();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue5.GetValue();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue6.GetValue();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue7.GetValue();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue8.GetValue();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonvalue9.GetValue();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Calculate.Setoperation("+");
            Screen.SetValue(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Calculate.Setoperation("-");
            Screen.SetValue(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Calculate.Setoperation("x");
            Screen.SetValue(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Calculate.Setoperation("/");
            Screen.SetValue2(textBox1.Text);
            textBox1.Clear();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Screen.ClearValue();
            textBox1.Clear();
        }
    }
}

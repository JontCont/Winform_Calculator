using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region num button
        private void Num1_Click(object sender, EventArgs e)
        {
            NewMethod("1");
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            NewMethod("2");

        }

        private void Num3_Click(object sender, EventArgs e)
        {
            NewMethod("3");

        }

        private void Num4_Click(object sender, EventArgs e)
        {
            NewMethod("4");
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            NewMethod("5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            NewMethod("6");

        }

        private void Num7_Click(object sender, EventArgs e)
        {
            NewMethod("7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            NewMethod("8");
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            NewMethod("9");
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            NewMethod("0");
        }

        private void NewMethod(string num)
        {
            if (label1.Text.Equals("0") ) label1.Text = num;
            else label1.Text += num;
            if (option.Equals("="))
            {
                label1.Text = num;
                option = "";
                label3.Text = "";
            }
        }
        #endregion

        private void Close_btn_Click(object sender, EventArgs e)
        {
            if (!option.Equals("=") )
             {
                if (!label1.Text.Equals("0"))
                {
                    int temp = label1.Text.ToString().Length;
                    label1.Text = label1.Text.ToString().Remove(temp - 1);
                }
            }
            else label3.Text = "";
            if (label1.Text == "") label1.Text = "0";

        }
        private void C_btn_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            doubleBtn = false;
        }        
        private void CE_btn_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label3.Text = "";
            doubleBtn = false;
        }


        #region Operation
        string option = "",Num1="";
        public void OptionSet(string Set) 
        {
            doubleBtn = false;
            if (option.Equals("=")) label3.Text = "";

            option = Set;
            Num1 = label1.Text;
            label3.Text += option + Num1;
            label1.Text = "";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            OptionSet("+");
        }

        private void Less_btn_Click(object sender, EventArgs e)
        {
            OptionSet("-");
        }

        private void Multiply_btn_Click(object sender, EventArgs e)
        {
            OptionSet("*");
        }

        private void Divide_btn_Click(object sender, EventArgs e)
        {
            OptionSet("/");
        }
        #endregion
        bool doubleBtn = false;
        private void Double_btn_Click(object sender, EventArgs e)
        {
            if (doubleBtn==false) 
            {
                label1.Text += ".";
                doubleBtn = true;
            }
        }

        private void Quotient_btn_Click(object sender, EventArgs e)
        {
            if (!option.Equals("=")) 
            {
                float perce = float.Parse(label1.Text) / 100;
                label1.Text = perce.ToString();
            }
        }

        private void Equal_btn_Click(object sender, EventArgs e)
        {
            OperationArithmetic operation = new OperationArithmetic();
            label3.Text = "=" +Num1 + option + label1.Text ;
            label1.Text = operation.Operation(Num1,option,label1.Text);
            option = "=";
        }
    }
}

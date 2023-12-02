using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double ilkDeger, ikinciDeger;
        String islem;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Hesap Makinası";
            this.Icon = new Icon("hesmak.ico");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void islemYap(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            islem = num.Text; 
            ilkDeger = Convert.ToDouble(textBox.Text);
            textBox.Text = num.Text;
        }

        private void esittir(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            ikinciDeger = Convert.ToDouble(textBox.Text);

            switch (islem)
            {
                case "+":
                    textBox.Text = Convert.ToString(ilkDeger + ikinciDeger);
                    break;
                case "-":
                    textBox.Text = Convert.ToString(ilkDeger - ikinciDeger);
                    break;
                case "*":
                    textBox.Text = Convert.ToString(ilkDeger * ikinciDeger);
                    break;
                case "/":
                    textBox.Text = Convert.ToString(ilkDeger / ikinciDeger);
                    break;
            }  
        }

        private void tusgeri_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 1)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
            else 
            {
                textBox.Text = "0";
            }
        }

        private void tusC_Click(object sender, EventArgs e)
        {
            ilkDeger = 0;
            ikinciDeger = 0;
            islem = "";
            textBox.Text = "0";
        }

        private void tusCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void tusartieksi_Click(object sender, EventArgs e)
        {
            double temp;
            temp = Convert.ToDouble(textBox.Text);
            temp = -1 * temp;
            textBox.Text = temp.ToString();
        }

        private void degerGir(object sender, EventArgs e)
        {
            Button num = sender as Button;

            if (num.Text == ",")
            {
                if (!textBox.Text.Contains(","))
                {
                    textBox.Text += ",";
                }
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = num.Text;
            }
            else if (textBox.Text != "+" && textBox.Text != "-" && textBox.Text != "*" && textBox.Text != "/")
            {
                textBox.Text += num.Text;
            }
            else 
            {
                textBox.Text = num.Text;
            }

        }


    }

}

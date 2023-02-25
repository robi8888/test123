using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random numbers = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            //int broj = numbers.Next();
            
            if (broj1.Text == "")
            {
                broj1.Text = Convert.ToString(numbers.Next(1, 37));
                return;
            }
                
            
            if (broj1.Text != "" && broj2.Text == "")
            {

                broj2.Text = Convert.ToString(numbers.Next(1, 37));
                if (broj2.Text == broj1.Text)
                    broj2.Text = Convert.ToString(numbers.Next(1, 37));
                return;
                
            }

            if (broj1.Text !="" && broj2.Text != "" && broj3.Text == "")
            {
                broj3.Text = Convert.ToString(numbers.Next(1, 37));
                if (broj3.Text == broj1.Text || broj3.Text == broj2.Text)
                    broj3.Text = Convert.ToString(numbers.Next(1, 37));
                return;
            }
            if (broj1.Text != "" && broj2.Text != "" && broj3.Text != "" && broj4.Text == "")
            {
                broj4.Text = Convert.ToString(numbers.Next(1, 37));
                if (broj4.Text == broj1.Text || broj4.Text == broj2.Text || broj4.Text == broj3.Text)
                    broj4.Text = Convert.ToString(numbers.Next(1, 37));
                return;
            }
            if (broj1.Text != "" && broj2.Text != "" && broj3.Text != "" && broj4.Text != "" && broj5.Text == "")
            {
                broj5.Text = Convert.ToString(numbers.Next(1, 37));
                if (broj5.Text == broj1.Text || broj5.Text == broj2.Text || broj5.Text == broj3.Text || broj5.Text == broj4.Text)
                    broj5.Text = Convert.ToString(numbers.Next(1, 37));
                return;
            }
            if (broj1.Text != "" && broj2.Text != "" && broj3.Text != "" && broj4.Text != "" && broj5.Text != "" && dodatni.Text == "")
            {

                dodatni.Text = Convert.ToString(numbers.Next(1, 37));
                if (dodatni.Text == broj1.Text || dodatni.Text == broj2.Text || dodatni.Text == broj3.Text || dodatni.Text == broj4.Text || dodatni.Text == broj5.Text)
                    dodatni.Text = Convert.ToString(numbers.Next(1, 37));
                return;
            }
            if (broj1.Text != "" && broj2.Text != "" && broj3.Text != "" && broj4.Text != "" && broj5.Text != "" && dodatni.Text != "")
            {
                broj.Text = broj1.Text+"   "+broj2.Text+"   "+broj3.Text+"   "+broj4.Text+"   "+ broj5.Text+"         "+ dodatni.Text;
                return;
            }


      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            broj1.Text = ""; broj2.Text = ""; broj3.Text = ""; broj4.Text = ""; broj5.Text = "";dodatni.Text = "";broj.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4___Part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked && radioButton4.Checked)
                {
                    BackColor = Color.Red;

                }
                else if (radioButton2.Checked && radioButton5.Checked)
                {
                    BackColor = Color.Blue;

                }
                else if (radioButton3.Checked && radioButton6.Checked)
                {
                    BackColor = Color.Yellow;

                }
                else if (radioButton1.Checked && radioButton5.Checked || radioButton2.Checked && radioButton4.Checked)
                {
                    BackColor = Color.Purple;

                }
                else if (radioButton1.Checked && radioButton6.Checked || radioButton6.Checked && radioButton1.Checked)
                {
                    BackColor = Color.Orange;

                }
                else if (radioButton2.Checked && radioButton6.Checked || radioButton6.Checked && radioButton2.Checked)
                {
                    BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Select color");
                    BackColor = SystemColors.Control;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

      
    }
}

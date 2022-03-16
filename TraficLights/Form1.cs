using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficLights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region variables
        int number1 = 0;
        bool number2 = true;
        #endregion

        #region strat buttun
        private void button4_Click(object sender, EventArgs e)
        {
            if (number2==true)
            {
                timer1.Enabled = true;
                button4.Text = "Stop";
                number2 = false;
            }
            else
            {
                button4.Text = "Start";
                timer1.Enabled = false;
                number2 = true;
                number1 = 0;
                label5.Text = number1.ToString();
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
        }
        #endregion

        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            number1++;
            label5.Text = number1.ToString();

            if (number1==10)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Yellow;
            }
            if (number1==13)
            {
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;
            }
            if (number1==23)
            {
                button3.BackColor = Color.Gray;
                button1.BackColor = Color.Red;
                number1 = 0;
            }
        }
        #endregion

        #region form
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
        }
    }
    #endregion
}

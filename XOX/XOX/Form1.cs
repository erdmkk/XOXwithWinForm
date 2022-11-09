using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0, o = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Sıra : X";
            label4.Text = "";      
            
        }

        private void text()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label2.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            
        }

        private void kontrol()
        {
            if((button1.Text == "X" && button2.Text == "X" && button3.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button1.Text == "O" && button2.Text == "O" && button3.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button4.Text == "X" && button5.Text == "X" && button6.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button4.Text == "O" && button5.Text == "O" && button6.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button7.Text == "X" && button8.Text == "X" && button9.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button7.Text == "O" && button8.Text == "O" && button9.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button1.Text == "X" && button4.Text == "X" && button7.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button1.Text == "O" && button4.Text == "O" && button7.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button2.Text == "X" && button5.Text == "X" && button8.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button2.Text == "O" && button5.Text == "O" && button8.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button3.Text == "X" && button6.Text == "X" && button9.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  0 : " + o;
            }
            else if((button3.Text == "O" && button6.Text == "O" && button9.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button1.Text == "X" && button5.Text == "X" && button9.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button1.Text == "O" && button5.Text == "O" && button9.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                label2.Text = "X KAZANDI !";
                x++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            else if((button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                label2.Text = "O KAZANDI !";
                o++;
                label4.Text = "X : " + x + "  /  O : " + o;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if ((label1.Text == "Sıra : X")){
                button1.Text = "X";
                label1.Text = "Sıra : O";
                
            }
            else
            {
                button1.Text = "O";
                label1.Text = "Sıra : X";
                
            }
            button1.Enabled = false;
            kontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button2.Text = "X";
                label1.Text = "Sıra : O";
                
            }
            else
            {
                button2.Text = "O";
                label1.Text = "Sıra : X";
                
            }
            button2.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button3.Text = "X";
                label1.Text = "Sıra : O";
               
            }
            else
            {
                button3.Text = "O";
                label1.Text = "Sıra : X";
                
            }
            button3.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button4.Text = "X";
                label1.Text = "Sıra : O";
            }
            else
            {
                button4.Text = "O";
                label1.Text = "Sıra : X";
            }
            button4.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button5.Text = "X";
                label1.Text = "Sıra : O";
            }
            else
            {
                button5.Text = "O";
                label1.Text = "Sıra : X";
            }
            button5.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button6.Text = "X";
                label1.Text = "Sıra : O";
            }
            else
            {
                button6.Text = "O";
                label1.Text = "Sıra : X";
            }
            button6.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button7.Text = "X";
                label1.Text = "Sıra : O";
            }
            else
            {
                button7.Text = "O";
                label1.Text = "Sıra : X";
            }
            button7.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button8.Text = "X";
                label1.Text = "Sıra : O";
            }
            else
            {
                button8.Text = "O";
                label1.Text = "Sıra : X";
            }
            button8.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "Sıra : X"))
            {
                button9.Text = "X";
                label1.Text = "Sıra : O";
            }
            else
            {
                button9.Text = "O";
                label1.Text = "Sıra : X";
            }
            button9.Enabled = false;
            this.ActiveControl = null;
            kontrol();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            text();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            x = 0;
            o = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appliedincap
{
    public partial class Form1 : Form
    {
       
        public int i = 0;
        
        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            
            
            {
                if (i == 0 || i == 2 || i == 4 || i == 6 || i == 8)
                {
                    button.Text = "X";
                    label2.Text = "Player 2";
                    ++i;
                   
                    if (i <= 5)
                    {
                        chkwin();
                    }
                }
                else if (i == 1 || i == 3 || i == 5 || i == 7)
                {
                    button.Text = "o";
                    label2.Text = "Player 1";
                    ++i;
                    if (i <= 5)
                    {
                        chkwin();
                    }
                   
                }
                if (i == 9)
                {
                    if (chk() && chkwin() == true)
                    {
                        MessageBox.Show("Match Draw.......");
                        this.Close();
                    }
                }
                if (chkwin()==false)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("Player 1 Won!!!!!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Won!!!!!");
                        this.Close();
                    }
                }
                
                

            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        bool chk()
        {
            if (i == 9)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        bool chkwin()
        {

            
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text == btn3.Text && btn2.Text == "X" || btn2.Text == "0" && btn2.Text == "X")
            {
                return false;
            }
            else if(btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text == btn6.Text && btn5.Text == "X" || btn5.Text == "0")
            {
                return false;
            }
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text == btn9.Text && btn7.Text == "X" || btn7.Text == "0")
            {
                return false;
            }
            else if (btn1.Text == btn4.Text && btn1.Text == btn7.Text && btn7.Text == btn4.Text && btn1.Text == "X" || btn1.Text == "0")
            {
                return false;
            }
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text == btn8.Text && btn5.Text == "X" || btn5.Text == "0")
            {
                return false;
            }
            else if (btn3.Text == btn6.Text && btn9.Text == btn6.Text && btn3.Text == btn9.Text && btn9.Text == "X" || btn9.Text == "0")
            {
                return false;
            }
            else if (btn1.Text == btn5.Text && btn1.Text == btn9.Text && btn5.Text == btn9.Text && btn1.Text == "X" || btn1.Text == "0")
            {
                return false;
            }
            else if (btn3.Text == btn5.Text && btn7.Text == btn3.Text && btn5.Text == btn7.Text && btn7.Text == "X" || btn7.Text == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

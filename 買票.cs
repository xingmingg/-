using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class 買票 : Form
    {
        public 買票()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTotal.Enabled = false;

        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(txtNum.Text, out userId) && int.TryParse(txtHeight.Text, out userId))
            {
               
                float height; 
                string total;
                 
                height = int.Parse(txtHeight.Text);
                if(height>1.40)
                {
                    //MessageBox.Show("Tryagain");
                   double num1 = Convert.ToInt32(txtNum.Text)*5;
                    txtTotal.Text = num1.ToString("$0.00");
                }
               // else if(height>1.40)
               // {
                    
               // }
                else
                {
                    double num2 = Convert.ToInt32(txtNum.Text)*5/2;
                    txtTotal.Text = num2.ToString("$0.00");

                    // MessageBox.Show("Try elseagain");
                }

            }
            else
            {
                MessageBox.Show("Please input something!!!");
            }
        }

        private void btnForeign_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(txtNum.Text, out userId) && int.TryParse(txtHeight.Text, out userId))
            {

                double height;
             //   string total;

                height = int.Parse(txtHeight.Text);
                if (height > 1.40)
                {
                    //MessageBox.Show("Tryagain");
                    double num1 = Convert.ToInt32(txtNum.Text) * 10;
                    txtTotal.Text = num1.ToString("$0.00");
                }
                // else if(height>1.40)
                // {

                // }
                else
                {
                    double num2 = Convert.ToInt32(txtNum.Text) * 10 / 2;
                    txtTotal.Text = num2.ToString("$00.00");

                    // MessageBox.Show("Try elseagain");
                }

            }
            else
            {
                MessageBox.Show("Please input something!!!");
            }
        }
    }
}

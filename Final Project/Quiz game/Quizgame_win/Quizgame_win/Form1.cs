using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizgame_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                I_Admin_Authent AA = new Authent_Admin();
                AA.com1_text = comboBox1.Text;
                AA.Login_ID = Convert.ToInt32(textBox1.Text);
                AA.Login_Pass = textBox2.Text;

                int check = AA.authentication();
                if (check == 1)
                {
                    MessageBox.Show("ADMIN SUCCESSFUL");
                    button3.Show();
                    button2.Hide();

                }
                else if (check == 2)
                {
                    MessageBox.Show("Admin Account Can't Accessable");
                }
                else if (check == 3)
                {
                    MessageBox.Show("Invalid ");
                }
                else if (check == 4)
                {
                    MessageBox.Show("Admin could not be a User");
                }
                else if (check == 5)
                {
                    MessageBox.Show("submitted");
                    button2.Show();
                    //Questions qs = new Questions();
                    //qs.Show();
                    //Form1 f = new Form1();
                    //f.Hide();

                }
                else if (check == 6)
                {
                    MessageBox.Show("invalid user password and User Already Exist ");

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("invalid user password and User Already Exist " + ex.ToString());

            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
         {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Maths")
            { 
            Questions qs = new Questions();
            qs.Show();
            }
            else if (comboBox2.Text == "English")
            {
                Eng_Questions eq = new Eng_Questions();
                eq.Show();
            }
            //Form2 f = new Form2();
            // f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();
            button2.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "ADMIN")
            {
                button3.Hide();
               // button2.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

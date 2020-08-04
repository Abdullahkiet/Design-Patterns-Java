using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizgame_win
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Admin_cls admin = new Admin_cls()
                {

                new_Question=Ques_txt.Text,
                a= txt_a.Text, 
                b =txt_b.Text ,
                c = txt_c.Text ,
                d = txt_d.Text ,
                Correct_ans = txt_correct.Text 
            };
                if (comboBox1.Text == "Maths")
                  admin.M_ADD();

                else if(comboBox1.Text == "English")
                    admin.E_ADD();

                MessageBox.Show("Question Added");
                Ques_txt.Text = "";
                txt_a.Text = "";
                txt_b.Text = "";
                txt_c.Text = "";
                txt_d.Text = "";
                txt_correct.Text = "";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q_no_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Q_no_txt.Text != "")
                {
                    Admin_cls b = new Admin_cls()
                    {
                        Q_no = Convert.ToInt32(Q_no_txt.Text)
                    };

                    if (comboBox1.Text == "Maths")
                    {
                        b.M_Search();     //searching Maths questions
                    }
                    else if (comboBox1.Text == "English")
                    {
                        b.E_Search();   //searching english questions
                    }



                    Ques_txt.Text = b.new_Question;
                    txt_a.Text = b.a;
                    txt_b.Text = b.b;
                    txt_c.Text = b.c;
                    txt_d.Text = b.d;
                    txt_correct.Text = b.Correct_ans;
                    button3.Enabled = false;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    //  button5.Enabled = false;



                }
                else
                {

                    MessageBox.Show("Enter Question Number");
                    Ques_txt.Text = "";
                    txt_a.Text = "";
                    txt_b.Text = "";
                    txt_c.Text = "";
                    txt_d.Text = "";
                    txt_correct.Text = "";
                    button3.Enabled = true;
                    button4.Enabled = false;
                    button5.Enabled = false;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q_no_txt_Enter(object sender, EventArgs e)
        {
           }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Admin_cls admin = new Admin_cls()
                {

                    new_Question = Ques_txt.Text,
                    a = txt_a.Text,
                    b = txt_b.Text,
                    c = txt_c.Text,
                    d = txt_d.Text,
                    Correct_ans = txt_correct.Text,
                    Q_no = Convert.ToInt32(Q_no_txt.Text)

                };
                if (comboBox1.Text == "Maths")
                {
                    admin.M_EDIT();

                }
                else if (comboBox1.Text == "English")
                {
                    admin.E_EDIT();
                }
                
                button3.Enabled = true;
                button5.Enabled = true;
                MessageBox.Show("Record Edited");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Question_sheet", Connection_cls.Get());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
           // Connection_cls.Get().Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adpt = new SqlDataAdapter("select * from English_Question_sheet", Connection_cls.Get());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                Admin_cls ad = new Admin_cls()
                {
                    Q_no = Convert.ToInt32(Q_no_txt.Text)
                };
                if (comboBox1.Text == "Maths")
                {
                    ad.M_Delete();
                }
                else if (comboBox1.Text == "English")
                {
                    ad.E_Delete();
                }               
                else
	            {
                    MessageBox.Show("Select in Combobox First");
                }
                MessageBox.Show("RECORD DELETED");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}

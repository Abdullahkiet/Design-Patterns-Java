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
    public partial class Eng_Questions : Form
    {
        public static int i = 0;
        int ms, s, m, h;


        int[] y = Questions_ran_cls.get();
        English_check_Score ck = new English_check_Score();
        public Eng_Questions()
        {
            InitializeComponent();
            ms = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                button2.Show();
                timer1.Enabled = true;
                button2.Enabled = true;
                label1.Show();
                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
                radioButton4.Show();
                button1.Text = "NEXT";
                button1.Enabled = false;

                ck.ques_count(y[i]); //show in radio buttons
                label1.Text = ck.Ques_label;
                radioButton1.Text = ck.radio_1;
                radioButton2.Text = ck.radio_2;
                radioButton3.Text = ck.radio_3;
                radioButton4.Text = ck.radio_4;
                i++;

            }
            catch (Exception ex)
            {

                //throw ex;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
                ck.ans = radioButton1.Text;

            else if (radioButton2.Checked == true)
                ck.ans = radioButton2.Text;

            else if (radioButton3.Checked == true)
                ck.ans = radioButton3.Text;

            else if (radioButton4.Checked == true)
                ck.ans = radioButton4.Text;

            ck.check();
            MessageBox.Show("Submited");
            button1.Enabled = true;
            button2.Enabled = false;
            if (i == 5)
            {
                MessageBox.Show("Your Total Score is " + ck.T_marks.ToString() + "\n Within " + lblmin.Text + ":" + lblsecond.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (i!=5)
            {
                MessageBox.Show("Your Total Score is " + ck.T_marks.ToString() + "\n Within " + lblmin.Text + ":" + lblsecond.Text);
            }
            Application.Exit();
            timer1.Enabled = false;
        }

        private void Eng_Questions_Load(object sender, EventArgs e)
        {
            button2.Hide();
            timer1.Enabled = true;
            lblhur.Text = timer1.ToString();

            ms = 0;
            h = 0;
            s = 0;
            m = 0;
            timer1.Enabled = false;
            lblhur.Hide();
            lblmin.Text = "00";
            lblsecond.Text = "00";
            lblmsec.Text = "00";

            // int[] y = rg.get();
            // Quiz_cls q = new Quiz_cls();

            // q.Question_num = y[0];

            //q.show_ques();
            label1.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms = ms + 1;
            if (ms == 9)
            {
                ms = 0;
                s = s + 1;
                lblsecond.Text = s.ToString();
                if (s == 59)
                {
                    s = 0;
                    m = m + 1;
                    lblmin.Text = m.ToString();
                    if (m == 59)
                    {
                        m = 0;
                        h = h + 1;
                        lblhur.Text = h.ToString();
                        {
                            lblmsec.Text = ms.ToString();
                        }
                    }
                }
            }
        }
    }
}

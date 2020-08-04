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
    public partial class Questions : Form
    {
        public static int i = 0;
        int ms, s, m, h;
        // Questions_ran_cls rg = new Questions_ran_cls();

        int[] y = Questions_ran_cls.get();
        check_Score_cls ck = new check_Score_cls();
        public Questions()
        {
            InitializeComponent();
            ms = 0;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Questions_Load(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblmsec_Click(object sender, EventArgs e)
        {

        }

        private void lblsecond_Click(object sender, EventArgs e)
        {

        }

        private void lblmin_Click(object sender, EventArgs e)
        {

        }

        private void lblhur_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

                throw ex;
               
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
                MessageBox.Show("Your Total Score is "+ck.T_marks.ToString());
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Total Score is " + ck.T_marks.ToString()+"\n Within " +lblmin.Text+ ":"+ lblsecond.Text);
            Application.Exit();
            timer1.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_win
{
    class Authent_Admin : I_Admin_Authent
    {
        

        public string com1_text { get; set; }
        public int Login_ID { get; set; }
        public string Login_Pass { get; set; }
        public int check { get; set; }


        public int authentication()
        {
            try
            {
                if (com1_text== "ADMIN")
                {

                    Admin_cls ad = new Admin_cls();
                    ad.Check_admin(Convert.ToInt32(Login_ID));
                    string pass = ad.Login_Pass.TrimEnd();
                    if (Login_ID == ad.Login_ID && Login_Pass == pass.Trim() && com1_text == ad.Type.Trim())
                    {
                        check = 1;    /// "ADMIN SUCCESSFUL";
                        return check;
                       
                    }
                    else if (Login_ID == ad.Login_ID && Login_Pass != pass.Trim() || com1_text == ad.Type.Trim())
                    {
                        check = 2;      //"Admin Account Can't Accessable";
                    }
                    else if (Login_ID != ad.Login_ID && Login_Pass != pass.Trim() || com1_text == ad.Type.Trim())
                    {
                        check = 3;
                    }

                }
                else if (com1_text == "USER")
                {
                    if (Login_ID.ToString() == "62908")
                    {
                        check = 4;                   // "Admin could not be a User";

                    }
                    else if (Login_ID.ToString() != "62908")
                    {
                        login_cls lg = new login_cls()
                        {
                            Login_ID = Convert.ToInt32(Login_ID),
                            Login_Pass = Convert.ToInt32(Login_Pass),
                            Type = com1_text,
                        };
                        lg.ADD();
                       return check = 5;                                 // MessageBox.Show("submitted");
                       
                    }

                }
            }
            catch (Exception)
            {
               return check = 6;                                           //"invalid user password"

            }
            return check;
        }

    }
}

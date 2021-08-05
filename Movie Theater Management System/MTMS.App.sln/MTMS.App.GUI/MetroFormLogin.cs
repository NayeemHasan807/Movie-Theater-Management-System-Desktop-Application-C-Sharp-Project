using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MTMS.App.Entity;
using MTMS.App.Repository;
using MTMS.App.FrameWork;


namespace MTMS.App.GUI
{
    public partial class MetroFormLogin : MetroForm
    {
        private User userLogin = new User();
        private UserRepo repoLogin = new UserRepo();

  
        public MetroFormLogin()
        {
            InitializeComponent();
        }

        private void metroButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.FillEntity();
                if (userLogin.UserId != null && userLogin.UserPassword != null)
                {
                    User user = repoLogin.GetUser(userLogin);
                    string userstatus = user.UserStatus;
                    string userid = user.UserId;

                    //MessageBox.Show(user.Id+" "+user.UserId+" "+user.UserPassword +" "+user.UserStatus);

                    if (user == null)
                    {
                        MessageBox.Show("Please,Input A Valid UserId & Password.");
                    }
                    else
                    {
                        this.Visible = false;
                        new MetroFormDashboard(userstatus,userid).Visible = true;
                    }
                }
                else
                    MessageBox.Show("Please, Enter Your UserId & Password To Login.");
                
            }
            catch //(Exception exception)
            {
               // MessageBox.Show("Error:" + exception.Message);
                MessageBox.Show("Please,Input A Valid UserId & Password.");
            }
            
                
        }

        private void FillEntity()
        {
            try
            {
                if (!IsValidToSave())
                {
                    userLogin.UserId = null;
                    userLogin.UserPassword = null;
                    return;
                }
                

                userLogin.UserId = this.metroTextBoxUserId.Text;
                userLogin.UserPassword = this.metroTextBoxPassword.Text;
            }
            catch //(Exception exception)
            {
                //MessageBox.Show("Error:" + exception.Message);
            }

        }

        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.metroTextBoxUserId.Text) && Validation.IsStringValid(this.metroTextBoxPassword.Text))
                return true;
            else
                return false;
        }

        private void MetroFormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

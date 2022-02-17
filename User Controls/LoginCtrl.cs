using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System.User_Controls
{
    public partial class LoginCtrl : UserControl
    {
        public LoginCtrl()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.FromArgb(57, 49, 38);
            BtnLogin.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.White;
            BtnLogin.BackColor = Color.FromArgb(57, 49, 38);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Trim() == "admin" && TxtPwd.Text.Trim() == "gamemode")
            {
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("wrong data intered");
            }
        }

        private void LoginCtrl_Load(object sender, EventArgs e)
        {

        }


        private void LoginCtrl_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}

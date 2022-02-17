using Library_Management_System.Classes;
using Library_Management_System.User_Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginCtrl1_VisibleChanged(object sender, EventArgs e)
        {
            MainCtrl mainCtrl = new MainCtrl();

            mainCtrl.Dock = DockStyle.Fill;

            this.Controls.Add(mainCtrl);
        }

        private void loginCtrl1_Load(object sender, EventArgs e)
        {
            Animator.ButtonBorderColorTransition(loginCtrl1.BtnLogin, Color.White, Color.Black, Animator.ColorTransitionSpeed.x1, 2);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

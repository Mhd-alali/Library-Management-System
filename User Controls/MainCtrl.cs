using System;
using System.Windows.Forms;

namespace Library_Management_System.User_Controls
{
    public partial class MainCtrl : UserControl
    {
        public MainCtrl()
        {
            InitializeComponent();
        }

        #region Methods




        #endregion

        #region Events
        private void MainCtrl_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainCtrl_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 1000)
            {
                tableLayoutPanel2.RowStyles[1].Height = 300;
            }
            if (this.Width < 1000)
            {
                tableLayoutPanel2.RowStyles[1].Height = 200;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

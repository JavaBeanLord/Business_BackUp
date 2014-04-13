using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_BackUp
{
    public partial class Main : Form
    {
         
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            StartBackgroundWork();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
           // e.Cancel = true;
           // base.OnFormClosing(e);
            this.Hide();
            Form1 LoginForm = new Form1();
            LoginForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (updateBar.Value < updateBar.Maximum)
                updateBar.Increment(5);
            else
                updateBar.Value = updateBar.Minimum;

        }


        private void StartBackgroundWork()
        {
            if (Application.RenderWithVisualStyles){
                //updateBar.Style = ProgressBarStyle.Marquee;
        }
            else
            {
                //updateBar.Style = ProgressBarStyle.Continuous;
                updateBar.Maximum = 100;
                updateBar.Value = 0;
                timer1.Enabled = true;
            }
            //Task
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (serverStatus.Text == ("Updating..."))
            {
                MessageBox.Show("I am updating your remote file system!"+"\n"+
                                "This could take awhile...");

            }
        }

        public void showUpgradeButton()
        {
            upGradeToolStripMenuItem.Visible = true;

        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFormNow AdminForm = new AdminFormNow();
            AdminForm.Show();

        }


    }
}

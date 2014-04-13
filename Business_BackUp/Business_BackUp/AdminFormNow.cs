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
    public partial class AdminFormNow : Form
    {
        public AdminFormNow()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                Main MainForm = new Main();
                MainForm.showUpgradeButton();

                MessageBox.Show("Test");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}

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

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
           // e.Cancel = true;
           // base.OnFormClosing(e);
            this.Hide();
            Form1 LoginForm = new Form1();
            LoginForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 LoginForm = new Form1();
            LoginForm.Show();
        }
    }
}

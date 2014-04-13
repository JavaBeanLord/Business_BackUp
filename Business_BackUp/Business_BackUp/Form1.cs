using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_BackUp{

    public partial class Form1 : Form 
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ("password"))
            {
                MessageBox.Show("You're Now Logged In As " + "\n" + "\n" + " User: DEMO " + "\n" + " Password: password ");
                textBox2.Text = ("");
                Main theMainForm = new Main();
                theMainForm.Show();
                this.Hide();


            }
            else 
            {
                MessageBox.Show("Password Could be Wrong or Null!");
                textBox2.Text = ("");
            }
        }
 
    }
}

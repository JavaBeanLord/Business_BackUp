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

        private void AdminFormNow_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;//Time1 On!

            comboBox1.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox2.Items.AddRange(new string[] { "00", "15", "30", "45" });
            comboBox5.Items.AddRange(new string[] { "AM", "PM" });
            //Break
            comboBox6.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox4.Items.AddRange(new string[] { "00", "15", "30", "45" });
            comboBox3.Items.AddRange(new string[] { "AM", "PM" });


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToShortDateString();
            textBox2.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It Look's like we are updating your Remote File System...");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't do that while I am updating your Remote File System...");

        }
    }
}

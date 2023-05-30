using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q
{
    public partial class newUser_form : Form
    {
        public newUser_form()
        {
            InitializeComponent();
        }

        internal string getName()
        {
           return this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //name needs to be one char or more 
            if (this.textBox1.Text.Length < 1)
            {
                MessageBox.Show("Name needs to be one char or more");
            }
            else
            {
                MessageBox.Show("Welcome " + this.textBox1.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //dialog return not  ok
            this.DialogResult = DialogResult.Cancel;
            MessageBox.Show("Canceled");
        }
    }
}

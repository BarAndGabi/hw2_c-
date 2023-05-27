using hw_2;
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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        //when pressed open db form
        private void DB_Click(object sender, EventArgs e)
        {
            DB_form db = new DB_form();
            db.ShowDialog();
        }

        private void E_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}

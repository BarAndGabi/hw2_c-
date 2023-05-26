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

    public partial class Form1 : Form
    {
        private ProductsDataContext db = new ProductsDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void q1Button(object sender, EventArgs e)
        {
            TblBindingSource.DataSource = db.TblProducts
                .OrderByDescending(p => p.Lenght)
                .FirstOrDefault();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TblBindingSource.DataSource = db.TblProducts;
            TblDataGridView.DataSource = TblBindingSource;
            TblBindingNavigator.BindingSource = TblBindingSource;
        }

        private void q2Button(object sender, EventArgs e)
        {
                var productsWithHighestPrice = db.TblProducts
                    .GroupBy(p => p.Name) 
                    .Select(g => new
                    {
                        Name = g.Key,
                        HighestLenght = g.Max(p => p.Lenght)
                    });

                TblBindingSource.DataSource = productsWithHighestPrice.ToList();
            }

        private void q3Button(object sender, EventArgs e)
        {
            TblBindingSource.DataSource = db.TblProducts.ToList();

        }
    }
    
}

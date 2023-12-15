using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDVHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal productPrice;
            int quantity;
            decimal price;
            
            productPrice = Convert.ToDecimal(txtProductPrice.Text);
            quantity = Convert.ToInt32(txtAdet.Text);

            price = productPrice * quantity;

            if (rdbKdv1.Checked)
            {
                price = price * Convert.ToDecimal(1.01);
            }
            else if (rdbKdv8.Checked)
            {
                price = price * Convert.ToDecimal(1.08);
            }
            else if (rdbKdv18.Checked)
            {
                price = price * Convert.ToDecimal(1.18);
            }
            else
            {
                MessageBox.Show("Lütfen KDV Değeri Seçiniz.");
            }

            lblPrice.Text = price + " TL";

        }
    }
}

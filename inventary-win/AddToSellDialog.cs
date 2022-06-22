using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventio_win
{
    public partial class AddToSellDialog : Form
    {
        public static String id;
        public static String name;
        public static String price;

        public AddToSellDialog()
        {
            InitializeComponent();
            ix.Text = id;
            pname.Text = name;
            price_in.Text = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellObj so = new SellObj();
            so.product_id = int.Parse(id);
            so.q = int.Parse(q.Text);
            SellObj.sell.Add(so);
            Dispose();
        }

        private void price_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void q_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

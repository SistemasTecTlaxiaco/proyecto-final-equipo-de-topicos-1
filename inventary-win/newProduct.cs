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
    public partial class newProduct : Form
    {
        public newProduct()
        {
            InitializeComponent();
        }

        private void newProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && price_in.Text != "" && price_out.Text != "")
            {
                Connection c = new Connection();
                c.execute("insert into product (name,price_in,price_out,unit) value(\""+name.Text+"\",\""+price_in.Text+"\",\""+price_out.Text+"\",\""+unit.Text+"\")");
                MessageBox.Show("Producto agregado exitosamente!");
                name.Text = price_in.Text = price_out.Text = unit.Text = "";

            }
            else {
                MessageBox.Show("Campos requeridos: Nombre, precio entrada, precio salida");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void unit_TextChanged(object sender, EventArgs e)
        {
             
            }

        private void price_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void price_out_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
    }
    }


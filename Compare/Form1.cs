using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clear() {
            bt_compare.UseVisualStyleBackColor = true;
            bt_compare.FlatStyle = FlatStyle.Standard;
            bt_compare.FlatAppearance.BorderSize = 0;
            bt_compare.ForeColor = Color.Black;
            bt_compare.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        public void tbcode1_KeyDown(object sender, KeyEventArgs e)
        {
            clear();
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            }
        }
        public void tbcode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comparar();
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
            }
        }
        public void comparar()
        {
            clear();

            if (tbcode1.Text == tbcode2.Text)
            { 
                bt_compare.BackColor = Color.LightGreen;
                bt_compare.FlatStyle = FlatStyle.Flat;
                bt_compare.FlatAppearance.BorderSize = 0;
                MessageBox.Show("Certo");
            }
            else
            {
                bt_compare.BackColor = Color.FromArgb(255, 33, 37);
                bt_compare.FlatStyle = FlatStyle.Flat;
                bt_compare.FlatAppearance.BorderSize = 0;
                MessageBox.Show("Errado");
            }
            tbcode1.Clear();
            tbcode2.Clear();
        }

        private void bt_compare_Click(object sender, EventArgs e)
        {
            comparar();
        }
    }
}

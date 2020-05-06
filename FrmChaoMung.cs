using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4_part1
{
    public partial class FrmChaoMung : Form
    {
        public FrmChaoMung()
        {
            InitializeComponent();
        }

        private void FrmChaoMung_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ban da bat form frmChaoMung");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("ban chua nhap ten");
                txtTen.Focus();
                return;
            }    
            if (txtLop.Text == "")
            {
                MessageBox.Show("ban chua nhap lop");
                txtLop.Focus();
                return;
            }
            MessageBox.Show("chao mung ban " + txtTen.Text + " hoc lop " + txtLop.Text);
        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

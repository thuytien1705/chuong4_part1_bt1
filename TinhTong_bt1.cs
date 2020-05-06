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
    public partial class TinhTong_bt1 : Form
    {
        public TinhTong_bt1()
        {
            InitializeComponent();
            
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
                || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;
            else e.Handled = true;
        }

        private void txtNhapB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
                || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;
            else e.Handled = true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(txtNhapA.Text);
            int b = Convert.ToInt32(txtNhapB.Text);
            int tong = 0;
            if (a<b)
            {
                for (int i = a;i <= b; i++)
                { tong = tong + i; }

            }
            if (a>b)
            {
                for (int i = b; i <= a; i++)
                { tong = tong + i; }
            }
            lbTinhTong.Text = "Tong cac so tu " + a + " den " + b + " = " + tong.ToString();

            
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            lbTinhTong.Text = "";
        }
    }
}

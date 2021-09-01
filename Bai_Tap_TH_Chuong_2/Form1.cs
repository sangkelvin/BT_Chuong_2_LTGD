using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_TH_Chuong_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtSothu1.Text.Equals("") || txtSothu2.Text.Equals("")) { MessageBox.Show("Hãy Nhập Số"); return; }
            else
            {
                int a = Convert.ToInt32(txtSothu1.Text);
                int b = Convert.ToInt32(txtSothu2.Text);

                txtKetqua.Text = Convert.ToString(a + b);
            }    
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtSothu1.Text.Equals("") || txtSothu2.Text.Equals("")) { MessageBox.Show("Hãy Nhập Số"); return; }
            else
            {
                int a = Convert.ToInt32(txtSothu1.Text);
                int b = Convert.ToInt32(txtSothu2.Text);
                txtKetqua.Text = Convert.ToString(a - b);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtSothu1.Text.Equals("") || txtSothu2.Text.Equals("")) { MessageBox.Show("Hãy Nhập Số"); return; }
            else
            {
                try
                {
                    int a = Convert.ToInt32(txtSothu1.Text);
                    int b = Convert.ToInt32(txtSothu2.Text);
                    txtKetqua.Text = Convert.ToString( checked (a * b));
                }
                catch (OverflowException)
                {
                    txtKetqua.Text = "Số quá lớn";
                }
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtSothu1.Text.Equals("") || txtSothu2.Text.Equals("")) { MessageBox.Show("Hãy Nhập Số"); return; }
            else
            {
                try
                {
                    int a = Convert.ToInt32(txtSothu1.Text);
                    int b = Convert.ToInt32(txtSothu2.Text);
                    txtKetqua.Text = String.Format("{0:0.00}", (double)a / b);
                }
                catch (DivideByZeroException)
                {
                    txtKetqua.Text = "Không chia cho 0";
                }
            }
        }

        private void txtSothu1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

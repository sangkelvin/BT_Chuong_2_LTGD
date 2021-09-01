using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        String pheptinh;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbn0_Click(object sender, EventArgs e)
        {
            if(txtShow.Text == "")
            {
                return;
            }
            txtShow.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                txtShow.Text = "";
            }
            txtShow.Text += "9";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if(txtShow.Text == "0")
            {
                txtShow.Text = "-";
            }
            if (txtShow.Text == "-")
            {
                MessageBox.Show("Loi Nhap!"); return;
            }
            txtShow.Text += "-";
            this.pheptinh = "-";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                MessageBox.Show("Loi Nhap!");return;
            }
            txtShow.Text += "+";
            this.pheptinh = "+";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                MessageBox.Show("Loi Nhap!");return;
            }
            txtShow.Text += "x";
            this.pheptinh = "x";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0")
            {
                MessageBox.Show("Loi Nhap!"); return;
            }
            txtShow.Text += "/";
            this.pheptinh = "/";
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            try { 
            int vitri = txtShow.Text.IndexOf(pheptinh);
            int so1 = Convert.ToInt32(txtShow.Text.Substring(0, vitri));
            int so2 = Convert.ToInt32(txtShow.Text.Substring(vitri+1));
            if(pheptinh == "+")
            {
                txtShow.Text += String.Format(" = {0}", so1 + so2);
            }
            else if(pheptinh == "-")
            {
                txtShow.Text += String.Format(" = {0}", so1 - so2);
            }
            else if(pheptinh == "x")
            {
                txtShow.Text += String.Format(" = {0}", so1 * so2);
            }
            else
            {
                txtShow.Text += String.Format(" = {0:0.00}", checked((double)so1/so2));
            }
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Không Được Chia Cho 0 !");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Số Quá Lớn !");
            }
            catch(FormatException)
            {
                MessageBox.Show("Nhập Lỗi !");
            }
        }
    }
}

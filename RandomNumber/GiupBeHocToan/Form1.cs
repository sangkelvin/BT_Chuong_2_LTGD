using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiupBeHocToan
{
    public partial class Form1 : Form
    {
        int So1, So2,chiso;
        String[] pheptinh = { "+", "-", "x", "/" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "0"; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text += ".";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                txtTraLoi.Text = txtTraLoi.Text.Substring(0, txtTraLoi.Text.Length - 1);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Trống Rỗng!\n Không Thể Xóa");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(txtTraLoi.Text.Equals(""))
            {
                MessageBox.Show("Chưa Nhập Kết Quả!");
                return;
            }
            if(chiso == 0)
            {
                if (Convert.ToInt32(lbSo1.Text) + Convert.ToInt32(lbSo2.Text) == Convert.ToInt32(txtTraLoi.Text))
                    lbKetqua.Text = String.Format("Giỏi Quá");
                else
                    lbKetqua.Text = String.Format("Sai Rồi! Kết Quả Là {0}", Convert.ToInt32(lbSo1.Text) + Convert.ToInt32(lbSo2.Text));
            }
            else if(chiso== 1)
            {
                if (Convert.ToInt32(lbSo1.Text) - Convert.ToInt32(lbSo2.Text) == Convert.ToInt32(txtTraLoi.Text))
                    lbKetqua.Text = String.Format("Giỏi Quá");
                else
                    lbKetqua.Text = String.Format("Sai Rồi! Kết Quả Là {0}", Convert.ToInt32(lbSo1.Text) - Convert.ToInt32(lbSo2.Text));
            }
            else if(chiso == 2)
            {
                if (Convert.ToInt32(lbSo1.Text) * Convert.ToInt32(lbSo2.Text) == Convert.ToInt32(txtTraLoi.Text))
                    lbKetqua.Text = String.Format("Giỏi Quá");
                else
                    lbKetqua.Text = String.Format("Sai Rồi! Kết Quả Là {0}", Convert.ToInt32(lbSo1.Text) * Convert.ToInt32(lbSo2.Text));
            }
            else
            {
                if ((double)(Convert.ToInt32(lbSo1.Text) / Convert.ToInt32(lbSo2.Text)) == (Convert.ToDouble(txtTraLoi.Text)))
                    lbKetqua.Text = String.Format("Giỏi Quá");
                else
                    lbKetqua.Text = String.Format("Sai Rồi! Kết Quả Là {0:0.00}", (double)Convert.ToInt32(lbSo1.Text) / Convert.ToInt32(lbSo2.Text));
            }


        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            Random rad = new Random();
            this.chiso = rad.Next(0, 4);
            lbPhepTinh.Text = pheptinh[chiso];
            if(chiso == 3)
            
                lbSo2.Text = Convert.ToString(rad.Next(1, 10));
            else lbSo2.Text = Convert.ToString(rad.Next(1, 10));
            lbSo1.Text = Convert.ToString(rad.Next(0, 10));
            lbKetqua.Text = "";
            txtTraLoi.Text = "";
        }
    }
}

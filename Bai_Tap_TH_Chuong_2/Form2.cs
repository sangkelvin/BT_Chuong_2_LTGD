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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(txtSothu1.Text.Equals("") || txtSothu2.Text.Equals(""))
            {
                MessageBox.Show("Chưa Nhập Số");
                return;
            }
            try
            {
                int a = Convert.ToInt32(txtSothu1.Text);
                int b = Convert.ToInt32(txtSothu2.Text);
                if (rbnCong.Checked)
                {
                    txtKetqua.Text = String.Format("{0}", checked(a + b));
                }
                else if (rbnTru.Checked)
                {
                    txtKetqua.Text = String.Format("{0}", a - b);
                }
                else if (rbnNhan.Checked)
                {
                    txtKetqua.Text = String.Format("{0}",checked( a * b));
                }
                else if (rbnChia.Checked)
                {
                    txtKetqua.Text = String.Format("{0:0.00}", (double)a / b);
                }
                else
                {
                    txtKetqua.Text = String.Format("{0}", a % b);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Bạn phải nhập hai số");
            }
            catch(DivideByZeroException)
            {
                txtKetqua.Text ="Lỗi chia cho 0";
            }
            catch(OverflowException)
            {
                txtKetqua.Text = "Số quá lớn!";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int diem = 0;
            int so1 = random.Next(1, 7);
            int so2 = random.Next(1, 7);
            int so3 = random.Next(1, 7);
            txtSo1.Text = so1.ToString();
            txtSo2.Text = so2.ToString();
            txtSo3.Text = so3.ToString();
            if(rbnf3t10.Checked)
            {
                if (so1 + so2 + so3 >= 3 && so1 + so2 + so3 <= 10)
                    diem += 10;
                else diem -= 10;
            }
            else
            {
                if (so1 + so2 + so3 >= 11 && so1 + so2 + so3 <= 18)
                    diem += 10;
                else diem -= 10;
            }
            txtDiem.Text = String.Format("{0}", diem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDiem.Text = "0";
            txtSo1.Text = txtSo2.Text = txtSo3.Text = "0";
        }
    }
}

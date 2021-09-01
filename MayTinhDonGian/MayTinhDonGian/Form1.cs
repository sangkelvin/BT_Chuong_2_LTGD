using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhDonGian
{
    public partial class Form1 : Form
    {
        private int Ketqua = 0;
        int KqTam = 0;
        double KqTamChia = 0;
        Boolean first = false;
        Boolean flag=true;
        Boolean isClickEqual = false;
        Boolean PhepTru = false;
        Boolean PhepCong = false;
        Boolean PhepNhan = false;
        Boolean PhepChia = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(lbShow.Text == "0")
            {
                return;
            }
            if(flag == true)
            {
                lbShow.Text += "0";
                
            }
            else
            {
                lbShow.Text = "0"; 

            }
            flag = true;
            lbShowPhepTinh.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
                
            }
            if (flag == true)
            {
                lbShow.Text += "1";
            }
            else
            {
                lbShow.Text = "1"; first = false;

            }
            if(lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "1";
            else { lbShowPhepTinh.Text += "1"; }
            flag = true;
            

            

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            
            if (flag == true)
            {
                lbShow.Text += "2";
                
            }
            else
            {
                lbShow.Text = "2"; first = false;

            }
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "2";
            else { lbShowPhepTinh.Text += "2"; }
            flag = true;
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            if (flag == true)
            {
                lbShow.Text += "3";
                
            }
            else
            {
                lbShow.Text = "3"; first = false;

            }
            flag = true;
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "3";
            else { lbShowPhepTinh.Text += "3"; }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
           
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            if (flag == true)
            {
                lbShow.Text += "4";

            }
            else
            {
                lbShow.Text = "4"; first = false;
            }
            flag = true;
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "4";
            else { lbShowPhepTinh.Text += "4"; }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
           
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            if (flag == true)
            {
                lbShow.Text += "5";
                
            }
            else
            {
                lbShow.Text = "5"; first = false;
            }
            flag = true;
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "5";
            else { lbShowPhepTinh.Text += "5"; }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            if (flag == true)
            {
                lbShow.Text += "6";

            }
            else
            {
                lbShow.Text = "6"; first = false;
            }
            flag = true;
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "6";
            else { lbShowPhepTinh.Text += "6"; }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            if (flag == true)
            {
                lbShow.Text += "7";
                
            }
            else
            {
                lbShow.Text = "7"; first = false;
            }
            flag = true;
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "7";
            else { lbShowPhepTinh.Text += "7"; }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
          
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            if (flag == true)
            {
                lbShow.Text += "8";
                
            }
            else
            {
                lbShow.Text = "8"; first = false;
            }
            flag = true;
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "8";
            else { lbShowPhepTinh.Text += "8"; }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
           
            if (lbShow.Text == "0")
            {
                lbShow.Text = "";
            }
            if (flag == true)
            {
                lbShow.Text += "9";
                
            }
            else
            {
                lbShow.Text = "9";
                first = false;
            }
            flag = true;
            if (lbShowPhepTinh.Text == "0")
                lbShowPhepTinh.Text = "9";
            else { lbShowPhepTinh.Text += "9"; }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            lbShow.Text = "0";
            this.Ketqua = 0;
            
            lbShowPhepTinh.Text += "";
            flag = true;
            lbShowPhepTinh.Text = "0";
            PhepCong = false;
            PhepTru = false;
            PhepNhan = false;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (isClickEqual)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                first = true;
                return;
            }
            if (PhepCong == false && PhepTru == false && PhepNhan == false && PhepChia == false)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                first = true;
            }
            if (PhepNhan == true)
            {
                if (first == true) { this.Ketqua *= Convert.ToInt32(lbShow.Text); lbShow.Text = String.Format("{0}", this.Ketqua); }
                else
                {
                    int tam = Convert.ToInt32(lbShow.Text) * this.KqTam;
                    lbShow.Text = String.Format("{0}", tam);
                }
                PhepNhan = false;
                first = false;

            }
            if (PhepChia == true)
            {
                if (first == true)
                    this.KqTamChia = this.Ketqua / Convert.ToDouble(lbShow.Text);
                else
                    this.KqTamChia = this.KqTamChia / Convert.ToDouble(lbShow.Text);
                lbShow.Text = String.Format("{0:0.00}", this.KqTamChia);
                
                PhepChia = false;
                first = false;
            }
            if (PhepTru == true)
            {
                this.Ketqua -= Convert.ToInt32(lbShow.Text);

                lbShow.Text = String.Format("{0}", this.Ketqua);
                PhepTru = false;
                
                first = false;
            }
            if (PhepCong == true)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                PhepCong = false;
                first = false;
            }
            lbShowPhepTinh.Text += "+";
            flag = false;
            PhepCong = true;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (isClickEqual)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                first = true;
                return;
            }
            if (PhepCong == false && PhepTru == false && PhepNhan == false && PhepChia == false)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                first = true;
            }
            if (PhepNhan == true)
            {
                if (first == true) { this.Ketqua *= Convert.ToInt32(lbShow.Text); lbShow.Text = String.Format("{0}", this.Ketqua); }
                else
                {
                    int tam = Convert.ToInt32(lbShow.Text) * this.KqTam;
                    lbShow.Text = String.Format("{0}", tam);
                }
                PhepNhan = false;
                first = false;

            }
             if (PhepChia == true)
            {
                if (first == true)
                    this.KqTamChia = this.Ketqua / Convert.ToDouble(lbShow.Text);
                else
                    this.KqTamChia = this.KqTamChia / Convert.ToDouble(lbShow.Text);
                lbShow.Text = String.Format("{0.00}", this.KqTamChia);
                PhepChia = false;
                first = false;
            }
            if (PhepTru == true)
            {
                this.Ketqua -= Convert.ToInt32(lbShow.Text);

                lbShow.Text = String.Format("{0}", this.Ketqua);
                first = false;

            }
            if(PhepCong == true)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                PhepCong = false;
                first = false;
            }
            


            
            flag = false;
            lbShowPhepTinh.Text += "-";
            PhepTru = true;

        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if(PhepNhan == true)
            {
                if (first == true) { this.Ketqua *= Convert.ToInt32(lbShow.Text); lbShow.Text = String.Format("{0}", this.Ketqua); }
                else
                {
                    int tam = Convert.ToInt32(lbShow.Text) * this.KqTam;
                    lbShow.Text = String.Format("{0}", tam);
                }
            }
             if (PhepChia == true)
            {
                if (first == true)
                    this.KqTamChia = this.Ketqua / Convert.ToDouble(lbShow.Text);
                else
                    this.KqTamChia = this.KqTamChia / Convert.ToDouble(lbShow.Text);
                lbShow.Text = String.Format("{0:0.00}", this.KqTamChia);
                
            }
            if (PhepTru == true)
            {
                this.Ketqua -= Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
            }
            if(PhepCong == true)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
            }

            this.Ketqua = 0;
            isClickEqual = true;
            PhepCong = false;
            PhepTru = false;
            PhepNhan = false;
            PhepChia = false;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            //Chua Nhap So
            if(lbShow.Text == "0")
            {
                MessageBox.Show("ERROR!!!"); return;
            }
            if(isClickEqual)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                first = true;
                return;
            }
            if (PhepCong == false && PhepTru == false && PhepNhan == false && PhepChia == false)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                first = true;
            }
            else if (PhepNhan == true)
            {
                this.KqTam *= Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.KqTam);
                first = false;
            }
            else if (PhepChia == true)
            {
                if(first == true )
                    this.KqTamChia = this.Ketqua / Convert.ToDouble(lbShow.Text);
                else 
                    this.KqTamChia = this.KqTamChia / Convert.ToDouble(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.KqTamChia);
                this.KqTam = this.KqTam + (int)this.KqTamChia;
                first = false;
                PhepChia = false;
            }
            else if(PhepTru == true)
            {
                this.KqTam = Convert.ToInt32(lbShow.Text);
                first = false;

            }
            else //Phep Cong
            {
                this.KqTam = Convert.ToInt32(lbShow.Text);
                first = false;
            }
            
            PhepNhan = true;
            lbShowPhepTinh.Text += "x";
            flag = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbShow.Text == "0" && lbShowPhepTinh.Text == "" || lbShow.Text == "")
                return;
            lbShow.Text = lbShow.Text.Substring(0, lbShow.Text.Length - 1);
            lbShowPhepTinh.Text = lbShowPhepTinh.Text.Substring(0, lbShowPhepTinh.Text.Length - 1);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            //Chua Nhap So
            if (lbShow.Text == "0")
            {
                MessageBox.Show("ERROR!!!"); return;
            }
            if (isClickEqual)
            {
                this.Ketqua += Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.Ketqua);
                return;
            }
            if (PhepCong == false && PhepTru == false && PhepNhan == false && PhepChia == false)
            {
                
                this.KqTamChia = Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.KqTamChia);
                first = true;
            }
            else if (PhepChia == true)
            {
                 this.KqTamChia = this.KqTamChia / Convert.ToDouble(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.KqTamChia);
                first = false;
            }
            else if (PhepNhan == true)
            {
                this.KqTamChia = this.KqTam * Convert.ToInt32(lbShow.Text);
                lbShow.Text = String.Format("{0}", this.KqTamChia);
                first = false;
            }
            else if (PhepTru == true)
            {
                this.KqTamChia = Convert.ToInt32(lbShow.Text);
                first = false;

            }
            else //Phep Cong
            {
                this.KqTamChia = Convert.ToInt32(lbShow.Text);
                first = false;
            }

            PhepChia = true;
            lbShowPhepTinh.Text += "/";
            flag = false;
        }
    }
}

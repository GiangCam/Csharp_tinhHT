using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhHT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double r, ketqua;
            r = Convert.ToDouble(txtR.Text);
            ketqua = r * 2 * Math.PI;
            txtKQ.Text = ketqua.ToString();

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndt_Click(object sender, EventArgs e)

        {
            Double r, ketqua;
            r = Convert.ToDouble(txtR.Text);
            ketqua = r * r * Math.PI;
            txtKQ.Text = ketqua.ToString();

        }

        private void rdbchuvi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (rdbdientich.Checked)
            {
                //tính chu vi
                lbltinh.Text = (txtKQ.Text);
                {
                    if (txtR.Text == "" || txtR.Text == "")
                    {
                        MessageBox.Show("phải nhập chiều dài và chiều rộng");
                        return;
                    }

                    Double r, ketqua;
                    r = Convert.ToDouble(txtR.Text);
                    ketqua = r * 2 * Math.PI;
                    txtKQ.Text = ketqua.ToString();

                }
                {
                    if (rdbchuvi.Checked)

                    {
                        //tính chu vi
                        lbltinh.Text = (txtKQ.Text);
                        {
                        
                            Double r, ketqua;
                            r = Convert.ToDouble(txtR.Text);
                            ketqua = r * r * Math.PI;
                            txtKQ.Text = ketqua.ToString();

                        }
                    }
                }
            }
        }
        private void rdbdientich_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double bk = Convert.ToDouble(txtR.Text);
            string thongbao = "";
            if (hkbdt.Checked)
            {
                double dientich = bk * bk * Math.PI;
                thongbao = thongbao + "diện tích" + Convert.ToString(dientich) + Environment.NewLine;
            }

            if (hkbcv.Checked)
            {

                double chuvi = bk * 2 * Math.PI;
                thongbao = thongbao + "chu vi" + Convert.ToString(chuvi) + Environment.NewLine;
            }



                if (thongbao.Length > 0)
            {     
                    MessageBox.Show(thongbao, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("vui lòng chọn chức năng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
        
    
    


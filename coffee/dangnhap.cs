using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;






namespace coffee
{
    public partial class dangnhap : Form
    {


        public dangnhap()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DucHao;Initial Catalog=Cafe;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtusername.Text;
                string mk = txtPassword.Text;
                string sql = "select *from dbo.account where TaiKhoan ='" + tk + "'and MatKhau ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {

                    //MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                    giaodien gt = new giaodien();
                    this.Visible = false;
                    gt.ShowDialog();
                    this.Visible = true;

                }



                else
                {

                    MessageBox.Show("Đăng nhập thất bại ", "Thông Báo");



                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

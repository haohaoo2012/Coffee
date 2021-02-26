using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace coffee
{
    public partial class nguyenvatlieu : Form
    {
        string kenoi = @"Data Source=DucHao;Initial Catalog = Cafe; Integrated Security = True";
        public nguyenvatlieu()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection con = new SqlConnection(kenoi);
            try
            {
                con.Open();
                string sql = "select* from nguyenvatlieu";
                SqlDataAdapter dta = new SqlDataAdapter(sql, con);
                DataTable tb = new DataTable();
                dta.Fill(tb);
                dataGridViewnvl.DataSource = tb;

            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
        }
        private void nguyenvatlieu_Load(object sender, EventArgs e)
        {


        }

        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(kenoi);
            try
            {
                if (txtnvl.Text != "" && txtsl.Text != "" && txtdv.Text != "" && txtdk.Text != "" && txtps.Text != "" && txtck.Text != "")
                {
                    con.Open();
                    string sql = "insert into nguyenvatlieu values('" + txtnvl.Text + "','" + txtsl.Text + "','" + txtdv.Text + "','" + txtdk.Text + "','" + txtps.Text + "','" + txtck.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thông tin kiểm kê nvl thành công", "Thông Báo");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm hông tin kiểm kê nvl thất bại", "Thông Báo");
                        con.Close();
                    }
                }
                else
                    MessageBox.Show("Chưa đủ thông tin cần thiết", "Thông Báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa thông tin nguyên vật liệu hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(kenoi);
                con.Open();
                {
                    string sql = "delete from nguyenvatlieu where NVL = '" + txtnvl.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thông tin kiểm kê nvl thành công");
                    load();
                }
                con.Close();
            }
        }



        private void btsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(kenoi);
            try
            {
                con.Open();
                string sql = "update  nguyenvatlieu set SoLuong = N'" + txtsl.Text + "', DonVi = N'" + txtdv.Text + "',  DauKi = N'" + txtdk.Text + "', Phatsinh = N'" + txtps.Text + "', CuoiKi= N'" + txtck.Text + "'where NVL= '" + txtnvl.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq >= 1)
                {
                    MessageBox.Show("Sửa thông tin kiểm kê nvl thành công", "Thông Báo");
                    load();
                }
                else
                    MessageBox.Show("Sửa thông tin kiểm kê nvl thất bại", "Thông Báo");

            }

            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
                con.Close();
            }
        }

        private void txtnvl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewnvl_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtnvl.Text = dataGridViewnvl.CurrentRow.Cells[0].Value.ToString();
            txtsl.Text = dataGridViewnvl.CurrentRow.Cells[1].Value.ToString();
            txtdv.Text = dataGridViewnvl.CurrentRow.Cells[2].Value.ToString();
            txtdk.Text = dataGridViewnvl.CurrentRow.Cells[3].Value.ToString();
            txtps.Text = dataGridViewnvl.CurrentRow.Cells[4].Value.ToString();
            txtck.Text = dataGridViewnvl.CurrentRow.Cells[5].Value.ToString();
        }
    }
}


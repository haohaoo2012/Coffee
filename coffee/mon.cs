using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee
{
    public partial class mon : Form
    {
        string kenoi = @"Data Source=DESKTOP-5LDMOIC;Initial Catalog=Cafe;Integrated Security=True";
        public mon()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection con = new SqlConnection(kenoi);
            try
            {
                con.Open();
                string sql = "select* from mon";
                SqlDataAdapter dta = new SqlDataAdapter(sql, con);
                DataTable tb = new DataTable();
                dta.Fill(tb);
                dataGridViewmon.DataSource = tb;

            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
        }

       

        private void mon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.cafeDataSet.mon);



        }

        private void button1_Click(object sender, EventArgs e) //thêm món
        {
            SqlConnection con = new SqlConnection(kenoi);
            try
            {
                if (txtmon.Text != "" && txtm.Text != "" && txtl.Text != "")
                {

                    con.Open();
                    string sql = "insert into mon values('" + txtmon.Text + "','" + txtm.Text + "','" + txtl.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông Báo");
                        load();

                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông Báo");
                        con.Close();
                    }
                }
           
                else

                    MessageBox.Show("Chưa đủ thông tin cần thiết","Thông Báo");
                      
               
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ");
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //xóa món
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa món hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(ThongBao==DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(kenoi);
                con.Open();
                {
                    string sql = "delete from mon where TenMon = '" + txtmon.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                con.Close();
            }    

        }

        private void dataGridViewmon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmon.Text = dataGridViewmon.CurrentRow.Cells[0].Value.ToString();
            txtm.Text = dataGridViewmon.CurrentRow.Cells[1].Value.ToString();
            txtl.Text = dataGridViewmon.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //sửa
        {
            SqlConnection con = new SqlConnection(kenoi);
            try
            {

                con.Open();
                    string sql = "update  mon set M= N'"+txtm.Text+"', L= N'"+txtl.Text+"'where TenMon ='" + txtmon.Text + "'";
                   
                SqlCommand cmd = new SqlCommand(sql, con);



            int kq = (int)cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                load();

            }
            else

                MessageBox.Show("Sửa thất bại", "Thông Báo");
            con.Close();


        }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi kết nối");
                }
}

        private void button1_Click_1(object sender, EventArgs e)
        {
            load();
        }
    }
}

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
    public partial class doanhthu : Form
    {
        string kenoi = @"Data Source=DESKTOP-5LDMOIC;Initial Catalog=Cafe;Integrated Security=True";
        public doanhthu()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection con = new SqlConnection(kenoi);
            try
            {
                con.Open();
                string sql = "select* from doanhthu";
                SqlDataAdapter dta = new SqlDataAdapter(sql, con);
                DataTable tb = new DataTable();
                dta.Fill(tb);
                dataGridViewdt.DataSource = tb;

            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
           

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void doanhthu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}

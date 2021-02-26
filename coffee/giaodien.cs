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
    public partial class giaodien : Form
    {
        public giaodien()
        {
            InitializeComponent();
        }

        private void giaodien_Load(object sender, EventArgs e)
        {

        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mon food = new mon();
            this.Visible = false;
            food.ShowDialog();
            this.Visible = true;
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhthu dt = new doanhthu();
            this.Visible = false;
            dt.ShowDialog();
            this.Visible = true;
        }

        private void nguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nguyenvatlieu nvl = new nguyenvatlieu();
            this.Visible = false;
            nvl.ShowDialog();
            this.Visible = true;
        }

       

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_net_TextChanged(object sender, EventArgs e)
        {

            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt32(txt_total.Text) - Convert.ToInt32(txt_discount.Text)).ToString();

            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void den_Click(object sender, EventArgs e)
        {
            den.Text = " CF Đen";
            if (szm.Checked)
            {
                txt_price.Text = "15000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "20000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void txt_price_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt32(txt_total.Text) - Convert.ToInt32(txt_discount.Text)).ToString();

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string discount = "", net = "", total = "";
            float discoun = 0, tota = 0, ne = 0;


            discount = txt_discount.Text;
            net = txt_net.Text;
            total = txt_total.Text;
            discoun = float.Parse(discount);
            tota = float.Parse(total);
            switch (net)
            {
                case "button1":
                    ne = discoun - tota;
                    break;
            }
            txt_net.Text = ne.ToString();
           

        }

        private void txt_qty_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)

            {
                txt_total.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString();
            }
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            //string gm = sua.Text.ToString();
            //gm = den.Text.ToString();
            //gm = st.Text.ToString();
            //gm = bx.Text.ToString();
            
            string[] arr = new string[3];

            arr[0] = den.ToString();
               
                arr[0] = txt_price.Text;
                arr[1] = txt_qty.Text;

                //if (txt_qty.Text.Length > 0)
                //{
                //    txt_total.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString();
                //}
                arr[2] = txt_total.Text.ToString();
                ListViewItem lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);
            szm.Checked = false;
            szl.Checked = false;
        }

            private void txt_total_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sua_Click(object sender, EventArgs e)
        {
            bx.Text = " CF Sữa";
            if (szm.Checked)
            {
                txt_price.Text = "17000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "23000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void bx_Click(object sender, EventArgs e)
        {
            bx.Text = " Bạc Xỉu";
            if (szm.Checked)
            {
                txt_price.Text = "17000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "23000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void st_Click(object sender, EventArgs e)
        {
            st.Text = " CF Sữa Tươi";
            if (szm.Checked)
            {
                txt_price.Text = "19000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "25000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void td_Click(object sender, EventArgs e)
        {
            td.Text = "Trà Đào";
            if (szm.Checked)
            {
                txt_price.Text = "20000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "27000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void tv_Click(object sender, EventArgs e)
        {
            tv.Text = "Trà Vải";
            if (szm.Checked)
            {
                txt_price.Text = "22000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "29000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void ep_Click(object sender, EventArgs e)
        {
            ep.Text = "Epresso";
            if (szm.Checked)
            {
                txt_price.Text = "17000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "23000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void eps_Click(object sender, EventArgs e)
        {
            eps.Text = "Epresso Sữa";
            if (szm.Checked)
            {
                txt_price.Text = "20000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "27000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void ts_Click(object sender, EventArgs e)
        {
            ts.Text = "Trà Sữa";
            if (szm.Checked)
            {
                txt_price.Text = "26000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "35000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void cc_Click(object sender, EventArgs e)
        {
            cc.Text = "Ca Cao";
            if (szm.Checked)
            {
                txt_price.Text = "19000";
            }
            else if (szl.Checked)
            {
                txt_price.Text = "25000";

            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
        {
            txt_price.Clear();
            txt_qty.Clear();
            txt_total.Clear();
            txt_discount.Clear();
            txt_net.Clear();

            //listView1.Items.Clear();
            listView1.Items.RemoveAt(0);
            szm.Checked = false;
            szl.Checked = false;
            

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lichsu ls = new lichsu();
            this.Visible = false;
            ls.ShowDialog();
            this.Visible = true;
        }
    }
}

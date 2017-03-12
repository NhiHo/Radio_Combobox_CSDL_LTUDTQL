using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace K48
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        string conmstring = @"Data Source=NHIHO-PC;Initial Catalog=K48;Integrated Security=True";
        string SQL;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoKhoa.Checked = true;
            LayDLKhoa();

        }

        private void LayDL()
        {
            cn = new SqlConnection(conmstring);
            da = new SqlDataAdapter(SQL, cn);
            ds = new DataSet("Khoa");
            da.Fill(ds, "Khoa");
            dgvKhoa.DataSource = ds;
            dgvKhoa.DataMember = "Khoa";
            cn.Close();
            cn.Dispose();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {

        }
        

        private void LayDLKhoa()
        {
            cn = new SqlConnection(conmstring);
            SQL = "SELECT * FROM Khoa";
            da = new SqlDataAdapter(SQL, cn); //lấy dữ liệu về
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboKhoa.DataSource = dt;//gán dữ liệu nguồn
            cboKhoa.ValueMember = "MaKhoa";//dùng để lọc dữ liệu
            cboKhoa.DisplayMember = "TenKhoa";//gán trường hiển thị trên combobox
            cn.Close();
            cn.Dispose();
        }

        private void LayDLLop()
        {
            cn = new SqlConnection(conmstring);
            SQL = "SELECT * FROM Lop WHERE MaKhoa = N'" + cboKhoa.SelectedValue.ToString() + "'";//dữ liệu           
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(SQL, cn);
            da.Fill(dt);
            cboLop.DataSource = dt;
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
            cn.Close();
            cn.Dispose();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDLLop();
        }

        private void btnHienthi_Click_1(object sender, EventArgs e)
        {
            cn = new SqlConnection(conmstring);
            SQL = "SELECT * FROM SV WHERE MaLop = N'" + cboLop.SelectedValue.ToString() + "'";//dữ liệu
            da = new SqlDataAdapter(SQL, cn);//cái lấy về
            ds = new DataSet("Khoa");
            da.Fill(ds, "Khoa");
            dgvKhoa.DataSource = ds;
            dgvKhoa.DataMember = "Khoa";
            cn.Close();
            cn.Dispose();
        }

        

        


    }
        
}

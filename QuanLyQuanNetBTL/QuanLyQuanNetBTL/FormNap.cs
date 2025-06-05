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


namespace QuanLyQuanNetBTL
{
    public partial class FormNap : Form
    {
        public FormNap(string tk)
        {
            taikhoan = tk;
            InitializeComponent();
        }
        private string taikhoan;
        string chuoiketnoi = "Data Source=HIZU\\SQLEXPRESS;Initial Catalog=quannet;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thucthi;
        SqlDataReader docdulieu;

        private void btFNOK_Click(object sender, EventArgs e)
        {
            try
            {
                int tienNap = int.Parse(txtTien.Text.Trim());
                double gioThem = tienNap / 10000;

                ketnoi.Open();
                string sql = "UPDATE nguoidung SET tien = tien + @tien, giochoi = giochoi + @gio WHERE taikhoan = @tk";
                thucthi = new SqlCommand(sql, ketnoi);
                thucthi.Parameters.AddWithValue("@tien", tienNap);
                thucthi.Parameters.AddWithValue("@gio", gioThem);
                thucthi.Parameters.AddWithValue("@tk", taikhoan);
                thucthi.ExecuteNonQuery();

                MessageBox.Show("Nạp tiền thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (ketnoi.State == ConnectionState.Open)
                    ketnoi.Close();
            }
        }
        
        

        private void FormNap_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }
    }
}

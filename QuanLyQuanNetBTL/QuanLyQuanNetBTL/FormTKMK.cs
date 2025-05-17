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
    public partial class FormTKMK : Form
    {
        string chuoiketnoi = "Data Source=HIZU\\SQLEXPRESS;Initial Catalog=quannet;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thucthi;
        SqlDataReader docdulieu;
        private string taikhoanCu = null; // Dùng để kiểm tra có phải đang sửa không
        private bool kiemtra = false; //Kiểm tra xem là đang sửa hay tạo
        public FormTKMK(string taikhoan, string matkhau)//sử dụng cho form sửa
        {
            InitializeComponent();
            taikhoanCu = taikhoan;
            txtTK.Text = taikhoan;
            txtMK.Text = matkhau;
            kiemtra = true; // Đánh dấu là đang sửa
            txtTK.Enabled = false; // Không cho sửa tài khoản
        }
        
        public FormTKMK()
        {
            InitializeComponent();
        }

        private void FormTKMK_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();

                if (kiemtra)
                {
                    // Cập nhật tài khoản
                    string sql = "UPDATE nguoidung SET matkhau = @mk WHERE taikhoan = @tk";
                    thucthi = new SqlCommand(sql, ketnoi);
                    thucthi.Parameters.AddWithValue("@mk", txtMK.Text.Trim());
                    thucthi.Parameters.AddWithValue("@tk", taikhoanCu);
                    thucthi.ExecuteNonQuery();
                    MessageBox.Show("✅ Cập nhật thành công!");
                }
                else
                {
                    // Tạo tài khoản mới
                    string sql = "INSERT INTO nguoidung(taikhoan, matkhau, tien, giochoi) VALUES(@tk, @mk, 0, 0)";
                    thucthi = new SqlCommand(sql, ketnoi);
                    thucthi.Parameters.AddWithValue("@tk", txtTK.Text.Trim());
                    thucthi.Parameters.AddWithValue("@mk", txtMK.Text.Trim());
                    thucthi.ExecuteNonQuery();
                    MessageBox.Show("✅ Tạo tài khoản thành công!");
                }

                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE KEY"))
                    MessageBox.Show("❌ Tài khoản đã tồn tại.");
                else
                    MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
            finally
            {
                if (ketnoi.State == ConnectionState.Open)
                    ketnoi.Close();
            }
        }
        

        private void btHUY_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

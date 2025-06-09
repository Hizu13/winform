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
    public partial class Form1 : Form
    {
        string chuoiketnoi = "Data Source=HIZU\\SQLEXPRESS;Initial Catalog=quannet;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thucthi;
        SqlDataReader docdulieu;
        public Form1()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            sql = "select * from nguoidung";
            thucthi = new SqlCommand(sql, ketnoi);
            docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                dataGridView1.Rows.Add(
                    docdulieu[0].ToString(),
                    docdulieu[1].ToString(),
                    docdulieu[2].ToString(),
                    docdulieu[4].ToString(),
                    docdulieu[3].ToString()
                    );
            }
            ketnoi.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    try
                    {
                        ketnoi.Open();
                        sql = "DELETE FROM nguoidung WHERE id = @id";
                        thucthi = new SqlCommand(sql, ketnoi);
                        thucthi.Parameters.AddWithValue("@id", id);
                        thucthi.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ketnoi.Close();
                    }

                    dataGridView1.Rows.Clear(); // Xóa hiển thị cũ
                    hienthi(); // Tải lại danh sách mới
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btTIm_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ketnoi.Open();
            sql = "select * from nguoidung where taikhoan like @taikhoan";
            thucthi = new SqlCommand(sql, ketnoi);
            thucthi.Parameters.AddWithValue("@taikhoan", "%" + txtTim.Text + "%");
            docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                dataGridView1.Rows.Add(
                    docdulieu[0].ToString(),
                    docdulieu[1].ToString(),
                    docdulieu[2].ToString(),
                    docdulieu[4].ToString(),
                    docdulieu[3].ToString()
                    );
            }
            ketnoi.Close();
        }
        FormTKMK fThem = new FormTKMK();
        private void btThem_Click(object sender, EventArgs e)
        {
            fThem.ShowDialog();
            dataGridView1.Rows.Clear(); // Xóa hiển thị cũ
            hienthi();
        }

        private void nạpTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string taikhoan = dataGridView1.CurrentRow.Cells["taikhoan"].Value.ToString();
                FormNap fNap = new FormNap(taikhoan);
                fNap.ShowDialog();
                dataGridView1.Rows.Clear();
                hienthi();
            }
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string tk = dataGridView1.CurrentRow.Cells["taikhoan"].Value.ToString();
                string mk = dataGridView1.CurrentRow.Cells["matkhau"].Value.ToString();

                FormTKMK formSua = new FormTKMK(tk, mk);
                formSua.ShowDialog();

                dataGridView1.Rows.Clear();
                hienthi(); // Load lại danh sách
            }
        }

        private void tênAzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ketnoi.Open();
            sql = "SELECT * FROM nguoidung ORDER BY taikhoan ASC";
            thucthi = new SqlCommand(sql, ketnoi);
            docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                dataGridView1.Rows.Add(
                    docdulieu[0].ToString(),
                    docdulieu[1].ToString(),
                    docdulieu[2].ToString(),
                    docdulieu[4].ToString(),
                    docdulieu[3].ToString()
                    );
            }
            docdulieu.Close();
            ketnoi.Close();
        }

        private void tênZaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ketnoi.Open();
            sql = "SELECT * FROM nguoidung ORDER BY taikhoan DESC";
            thucthi = new SqlCommand(sql, ketnoi);
            docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                dataGridView1.Rows.Add(
                    docdulieu[0].ToString(),
                    docdulieu[1].ToString(),
                    docdulieu[2].ToString(),
                    docdulieu[4].ToString(),
                    docdulieu[3].ToString()
                    );
            }
            docdulieu.Close();
            ketnoi.Close();
        }

        private void giờChơiBéĐếnLớnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ketnoi.Open();
            sql = "SELECT * FROM nguoidung ORDER BY giochoi ASC";
            thucthi = new SqlCommand(sql, ketnoi);
            docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                dataGridView1.Rows.Add(
                    docdulieu[0].ToString(),
                    docdulieu[1].ToString(),
                    docdulieu[2].ToString(),
                    docdulieu[4].ToString(),
                    docdulieu[3].ToString()
                    );
            }
            docdulieu.Close();
            ketnoi.Close();
        }

        private void giờChơiLớnĐếnBéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ketnoi.Open();
            sql = "SELECT * FROM nguoidung ORDER BY giochoi DESC";
            thucthi = new SqlCommand(sql, ketnoi);
            docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                dataGridView1.Rows.Add(
                    docdulieu[0].ToString(),
                    docdulieu[1].ToString(),
                    docdulieu[2].ToString(),
                    docdulieu[4].ToString(),
                    docdulieu[3].ToString()
                    );
            }
            docdulieu.Close();
            ketnoi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

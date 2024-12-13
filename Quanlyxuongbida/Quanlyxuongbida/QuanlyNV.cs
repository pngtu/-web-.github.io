using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyxuongbida
{
    public partial class QuanlyNV : Form
    {
        KetNoi kn=new KetNoi();
        public QuanlyNV()
        {
            InitializeComponent();
        }
        public void getdataNV()
        {
            string query = "select * from NhanVien ";
            DataSet ds = kn.laydulieu(query);
            dgv_nv.DataSource = ds.Tables[0];
        }
        public void clearNV()
        {
            txt_manv.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_ngaysinh.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_manv.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tennv.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tennv.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ngaysinh.Text) || !DateTime.TryParse(txt_ngaysinh.Text, out _))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng ngày.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ngaysinh.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_sdt.Text) || !txt_sdt.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_sdt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_diachi.Focus();
                return;
            }

            string GioiTinh = rad_nam.Checked ? "Nam" : (rad_nu.Checked ? "Nu" : "");
            string query = string.Format("insert into nhanvien values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                txt_manv.Text,
                txt_tennv.Text,
                txt_ngaysinh.Text,
                txt_sdt.Text,
                txt_diachi.Text,     
                GioiTinh
            );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Thêm thành công");
                btn_lammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void QuanlyNV_Load(object sender, EventArgs e)
        {
            getdataNV();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clearNV();
            getdataNV();
        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txt_manv.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;

                txt_manv.Text = dgv_nv.Rows[r].Cells["manv"].Value.ToString();
                txt_tennv.Text = dgv_nv.Rows[r].Cells["tennv"].Value.ToString();
                txt_ngaysinh.Text = dgv_nv.Rows[r].Cells["ngaysinh"].Value.ToString();
                txt_sdt.Text = dgv_nv.Rows[r].Cells["sdt"].Value.ToString();
                txt_diachi.Text = dgv_nv.Rows[r].Cells["diachi"].Value.ToString();
                string gioitinhValue = dgv_nv.Rows[r].Cells["gioitinh"].Value.ToString();
                if (gioitinhValue == "Nam")
                {
                    // Đặt RadioButton "Nam" (assumed radio button name)
                    rad_nam.Checked = true;
                    rad_nu.Checked = false;
                }
                else if (gioitinhValue == "Nu")
                {
                    // Đặt RadioButton "Nữ" (assumed radio button name)
                    rad_nam.Checked = false;
                    rad_nu.Checked = true;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string GioiTinh = rad_nam.Checked ? "Nam" : (rad_nu.Checked ? "Nu" : "");
            string query = string.Format("delete from nhanvien where manv =N'{0}'",
               txt_manv.Text,
                txt_tennv.Text,
                txt_ngaysinh.Text,
                txt_sdt.Text,
                txt_diachi.Text,
                GioiTinh
            );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Xóa thành công");
                btn_lammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string GioiTinh = rad_nam.Checked ? "Nam" : (rad_nu.Checked ? "Nu" : "");
            string query = string.Format("update nhanvien set tennv=N'{1}',ngaysinh= N'{2}',sdt=N'{3}',diachi=N'{4}',gioitinh=N'{5}' where manv=N'{0}';",
               txt_manv.Text,
                txt_tennv.Text,
                txt_ngaysinh.Text,
                txt_sdt.Text,
                txt_diachi.Text,
                GioiTinh
            );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                btn_lammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
           
        string query = string.Format("Select * from NhanVien where manv like N'%{0}%' or tennv like N'%{0}%' or ngaysinh like N'%{0}%'or sdt like N'%{0}%' or diachi like N'%{0}%' or gioitinh like N'%{0}%'",
        txt_timkiem.Text
        );
            DataSet ds = kn.laydulieu(query);
            dgv_nv.DataSource = ds.Tables[0];
        }
    }
}

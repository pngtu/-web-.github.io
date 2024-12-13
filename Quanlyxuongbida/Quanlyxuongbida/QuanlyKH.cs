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
    public partial class QuanlyKH : Form
    {
        KetNoi kn = new KetNoi();
        public QuanlyKH()
        {
            InitializeComponent();
        }
        public void getdataKH()
        {
            string query = "select * from khachhang ";
            DataSet ds = kn.laydulieu(query);
            dgv_kh.DataSource = ds.Tables[0];
        }
        public void clearKH()
        {
            txt_makh.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txt_makh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_makh.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tenkh.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tenkh.Focus();
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
            string query = string.Format("insert into khachhang values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",
                txt_makh.Text,
                txt_tenkh.Text,
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

        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txt_makh.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;

                txt_makh.Text = dgv_kh.Rows[r].Cells["makh"].Value.ToString();
                txt_tenkh.Text = dgv_kh.Rows[r].Cells["tenkh"].Value.ToString();
                txt_sdt.Text = dgv_kh.Rows[r].Cells["sdt"].Value.ToString();
                txt_diachi.Text = dgv_kh.Rows[r].Cells["diachi"].Value.ToString();
                string gioitinhValue = dgv_kh.Rows[r].Cells["gioitinh"].Value.ToString();
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

        private void QuanlyKH_Load_1(object sender, EventArgs e)
        {
            getdataKH();
        }

        private void btn_lammoi_Click_1(object sender, EventArgs e)
        {
            clearKH();
            getdataKH();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_makh.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_makh.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string GioiTinh = rad_nam.Checked ? "Nam" : (rad_nu.Checked ? "Nu" : "");
            string query = string.Format("update khachhang set tenkh=N'{1}',sdt=N'{2}',diachi=N'{3}',gioitinh=N'{4}' where makh=N'{0}';",
                txt_makh.Text,
                txt_tenkh.Text,
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string GioiTinh = rad_nam.Checked ? "Nam" : (rad_nu.Checked ? "Nu" : "");
            string query = string.Format("delete from khachhang where makh =N'{0}'",
                txt_makh.Text,
                txt_tenkh.Text,
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
        private void btn_tim_Click(object sender, EventArgs e)
        {
            string query = string.Format("Select * from khachhang where makh like N'%{0}%' or tenkh like N'%{0}%' or sdt like N'%{0}%' or diachi like N'%{0}%' or gioitinh like N'%{0}%'",
            txt_timkiem.Text
          );
            DataSet ds = kn.laydulieu(query);
            dgv_kh.DataSource = ds.Tables[0];
        }
    }
}

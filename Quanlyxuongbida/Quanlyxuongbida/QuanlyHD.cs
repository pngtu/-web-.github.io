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
    public partial class QuanlyHD : Form
    {
        KetNoi kn = new KetNoi();
        public QuanlyHD()
        {
            InitializeComponent();
        }
        public void getdataHD()
        {
            string query = "select * from hoadon";
            DataSet ds = kn.laydulieu(query);
            qlhd.DataSource = ds.Tables[0];
        }
        public void clearHD()
        {
            txt_mahd.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            txt_mahd.Text = "";
            txt_manv.Text = "";
            txt_maban.Text = "";
            txt_makh.Text = "";
            txt_ngaytt.Text = "";
            txt_tong.Text = "";
        }

        private void QuanlyHD_Load(object sender, EventArgs e)
        {
            getdataHD();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mahd.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mahd.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_manv.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ngaytt.Text) || !DateTime.TryParse(txt_ngaytt.Text, out _))
            {
                MessageBox.Show("Ngày thanh toán không hợp lệ. Vui lòng nhập đúng định dạng ngày.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ngaytt.Focus();
                return;
            }
            string query = string.Format("insert into hoadon values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                txt_mahd.Text,
                txt_manv.Text,
                txt_maban.Text,
                txt_makh.Text,
                txt_ngaytt.Text,
                txt_tong.Text
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
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update hoadon set manv=N'{1}',maban= N'{2}',makh=N'{3}',ngaytt=N'{4}',tong=N'{5}' where mahd=N'{0}';",
                txt_mahd.Text,
                txt_manv.Text,
                txt_maban.Text,
                txt_makh.Text,
                txt_ngaytt.Text,
                txt_tong.Text
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
            string query = string.Format("delete from hoadon where mahd =N'{0}'",
                txt_mahd.Text,
                txt_manv.Text,
                txt_maban.Text,
                txt_makh.Text,
                txt_ngaytt.Text,
                txt_tong.Text
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
            string query = string.Format("Select * from hoadon where mahd like N'%{0}%' or manv like N'%{0}%' or maban like N'%{0}%'or makh like N'%{0}%' or ngaytt like N'%{0}%' or tong like N'%{0}%'",
        txt_timkiem.Text
        );
            DataSet ds = kn.laydulieu(query);
            qlhd.DataSource = ds.Tables[0];
        }


        private void qlhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txt_mahd.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;

                txt_mahd.Text = qlhd.Rows[r].Cells["mahd"].Value.ToString();
                txt_manv.Text = qlhd.Rows[r].Cells["manv"].Value.ToString();
                txt_maban.Text = qlhd.Rows[r].Cells["maban"].Value.ToString();
                txt_makh.Text = qlhd.Rows[r].Cells["makh"].Value.ToString();
                txt_ngaytt.Text = qlhd.Rows[r].Cells["ngaytt"].Value.ToString();
                txt_tong.Text = qlhd.Rows[r].Cells["tong"].Value.ToString();
            }
        }
    }
}

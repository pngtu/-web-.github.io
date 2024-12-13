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
    public partial class Form1 : Form
    {
        KetNoi kn=new KetNoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            string query = string.Format("Select*from NguoiDung where Taikhoan='{0}' and Matkhau='{1}'",
            txt_taikhoan.Text, txt_matkhau.Text);
            DataSet ds = kn.laydulieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                Hethong ht = new Hethong();
                this.Hide();
                ht.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!!");
            }

    
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

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
    public partial class Hethong : Form
    {
        public Hethong()
        {
            InitializeComponent();
        }

        private void Hethong_Load(object sender, EventArgs e)
        {

        }



        private void btn_qlb_Click(object sender, EventArgs e)
        {
            QuanLyBan quanLyBan = new QuanLyBan();
            quanLyBan.TopLevel = false;
            panel_show.Controls.Clear();
            panel_show.Controls.Add(quanLyBan);
            quanLyBan.Show();
        }
        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            QuanlyNV quanlyNV = new QuanlyNV();
            quanlyNV.TopLevel = false;
            panel_show.Controls.Clear();
            panel_show.Controls.Add(quanlyNV);
            quanlyNV.Show();
        }

        private void btn_menu_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.TopLevel = false;
            panel_show.Controls.Clear();
            panel_show.Controls.Add(menu);
            menu.Show();
        }

        private void btn_qlhd_Click_1(object sender, EventArgs e)
        {
            QuanlyHD quanlyHD = new QuanlyHD();
            quanlyHD.TopLevel = false;
            panel_show.Controls.Clear();
            panel_show.Controls.Add(quanlyHD);
            quanlyHD.Show();
        }

        private void btn_qlkh_Click_1(object sender, EventArgs e)
        {
            QuanlyKH quanlyKH = new QuanlyKH();
            quanlyKH.TopLevel = false;
            panel_show.Controls.Clear();
            panel_show.Controls.Add(quanlyKH);
            quanlyKH.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

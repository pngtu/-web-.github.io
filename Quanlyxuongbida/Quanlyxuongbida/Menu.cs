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
    public partial class Menu : Form
    {
        KetNoi kn = new KetNoi();
        Dictionary<string, ListView> listViewDictionary = new Dictionary<string, ListView>();
        private Dictionary<string, Color> defaultButtonColors = new Dictionary<string, Color>();
        //private Dictionary<string, List<OrderItem>> ordersByTable = new Dictionary<string, List<OrderItem>>();
        private Dictionary<int, List<string>> tableFoodItems = new Dictionary<int, List<string>>();
        private Timer tableTimer = new Timer();
        private Dictionary<string, DateTime> tableOpenTimes = new Dictionary<string, DateTime>();
        private Label timeLabel;
        public Menu()
        {
            InitializeComponent();
            getdataDV();
            getdv();
            Controls.Add(panel_timer);
            timeLabel = new Label();
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(10, 10);
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            panel_timer.Controls.Add(timeLabel);

            timer.Interval = 1000; // Update every 1 second
            timer.Tick += timer_Tick;
            timer.Start();
        }
        public void getdataDV()
        {
            string query = "select * from dichvu";
            DataSet ds = kn.laydulieu(query);
            cmbDV.DataSource = ds.Tables[0];
            cmbDV.DisplayMember = "tendv"; // Hiển thị Tên hàng trong ComboBox
            cmbDV.ValueMember = "tendv";
        }
        public void getdv()
        {

            DataSet dsMonAn = kn.LayDudichvu();
            if (dsMonAn != null && dsMonAn.Tables.Count > 0)
            {
                // Đặt nguồn dữ liệu cho ComboBox cb_monan
                cmbDV.DataSource = dsMonAn.Tables[0];
                cmbDV.ValueMember = "tendv"; // Cột chứa giá trị thực sự của mỗi mục trong ComboBox
                cmbDV.DisplayMember = "tendv"; // Cột chứa dữ liệu để hiển thị trong ComboBox

                // Đặt nguồn dữ liệu cho TextBox để hiển thị đơn giá
                txtDongia.DataBindings.Clear();
                txtDongia.DataBindings.Add("Text", dsMonAn.Tables[0], "giadv");
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu hoặc có lỗi xảy ra
                MessageBox.Show("Không thể lấy dữ liệu dịch vụ.");
            }

        }
        private void Menu_Load(object sender, EventArgs e)
        {
            txtDongia.Enabled = false;
        }

        private void cmbDV_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            if (cmbDV.SelectedIndex >= 0)
            {
                string dongia = ((DataRowView)cmbDV.SelectedItem)["giadv"].ToString();
                txtDongia.Text = dongia;
            }*/
        }
        private void SwitchToTable(string tenBan)
        {
            // Kiểm tra xem ListView cho bàn này đã tồn tại chưa
            if (!listViewDictionary.ContainsKey(tenBan))
            {
                // Nếu chưa tồn tại, tạo một ListView mới
                ListView listView = new ListView();
                listView.Columns.Add("Bàn");
                listView.Columns.Add("Tên dịch vụ");
                listView.Columns.Add("Số lượng");
                listView.Columns.Add("Đơn giá");

                // Thêm ListView vào danh sách
                listViewDictionary[tenBan] = listView;

                // Đặt layout và hiển thị ListView
                listView.Dock = DockStyle.Fill;
                listView.View = View.Details;
                list_ban.Controls.Add(listView);
            }

            // Ẩn tất cả các ListView và chỉ hiển thị ListView cho bàn hiện tại
            foreach (var listViewPair in listViewDictionary)
            {
                if (listViewPair.Key == tenBan)
                {
                    listViewPair.Value.Visible = true;
                }
                else
                {
                    listViewPair.Value.Visible = false;
                }
            }
        }
        private void btn_ban1_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 1");
            ListViewItem item = new ListViewItem("Ban 1");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban2_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 2");
            ListViewItem item = new ListViewItem("Ban 2");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban3_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 3");
            ListViewItem item = new ListViewItem("Ban 3");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban4_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 4");
            ListViewItem item = new ListViewItem("Ban 4");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban5_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 5");
            ListViewItem item = new ListViewItem("Ban 5");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban6_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 6");
            ListViewItem item = new ListViewItem("Ban 6");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban7_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 7");
            ListViewItem item = new ListViewItem("Ban 7");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban8_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 8");
            ListViewItem item = new ListViewItem("Ban 8");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban9_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 9");
            ListViewItem item = new ListViewItem("Ban 9");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban10_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 10");
            ListViewItem item = new ListViewItem("Ban 10");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban11_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 11");
            ListViewItem item = new ListViewItem("Ban 11");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_ban12_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 12");
            ListViewItem item = new ListViewItem("Ban 12");
            list_ban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.DodgerBlue;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cmbDV.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);

            if (string.IsNullOrEmpty(tenBanHienTai))
            {
                // Nếu không có bàn hiện tại, không thể thêm món
                MessageBox.Show("Vui lòng chọn một bàn trước khi thêm món.");
                return;
            }

            // Lấy thông tin món ăn và số lượng từ ComboBox và NumberUpDown
            string tendichvu = cmbDV.Text;
            int soLuong = (int)number_SoLuong.Value;
            float donGia = float.Parse(txtDongia.Text);
            // Điền giá trị đơn giá ở đây nếu cần

            // Lấy ListView tương ứng với bàn hiện tại và thêm thông tin món vào đó
            ListView listView = listViewDictionary[tenBanHienTai];

            // Hiển thị thông tin món vào ListView
            ListViewItem item = new ListViewItem(tenBanHienTai);
            item.SubItems.Add(tendichvu);
            item.SubItems.Add(soLuong.ToString());
            item.SubItems.Add(donGia.ToString());

            // Thêm item vào ListView
            listView.Items.Add(item);

            // Xóa nội dung ComboBox và thiết lập lại giá trị mặc định cho NumberUpDown
            cmbDV.Text = "";
            number_SoLuong.Value = 1;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);

            if (!string.IsNullOrEmpty(tenBanHienTai))
            {
                // Lấy ListView tương ứng với bàn hiện tại
                ListView listView = listViewDictionary[tenBanHienTai];

                // Duyệt qua tất cả các mục được chọn trong ListView
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    listView.Items.Remove(item); // Xóa mục được chọn
                }
            }
        }

        private void list_ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_ban.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = list_ban.SelectedItems[0];

                // Hiển thị thông tin món và ghi chú được chọn trong các điều khiển
                string tenMonAn = selectedItem.SubItems[1].Text;

                // Tìm và đặt giá trị của ComboBox dựa trên tên món ăn
                cmbDV.SelectedItem = tenMonAn;

                // Hiển thị thông tin ghi chú
                string ghiChu = selectedItem.SubItems[4].Text;
            }
        }
        private int PromptForNewQuantity(int currentQuantity)
        {
            // Display a dialog for entering a new quantity
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 150;
            prompt.Text = "Sửa số lượng";

            Label lblQuantity = new Label() { Left = 50, Top = 20, Text = "Nhập số lượng mới:" };
            NumericUpDown numericUpDown = new NumericUpDown() { Left = 50, Top = 40, Width = 300 };
            numericUpDown.Minimum = 0;
            numericUpDown.Value = currentQuantity;

            Button confirmation = new Button() { Text = "OK", Left = 250, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(lblQuantity);
            prompt.Controls.Add(numericUpDown);
            prompt.Controls.Add(confirmation);

            DialogResult dialogResult = prompt.ShowDialog();

            int newQuantity = (int)numericUpDown.Value;

            return newQuantity;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);

            if (!string.IsNullOrEmpty(tenBanHienTai))
            {
                ListView listView = listViewDictionary[tenBanHienTai];

                if (listView.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView.SelectedItems[0];

                    if (selectedItem.SubItems.Count >= 3) // Make sure there's at least 3 subitems
                    {
                        int soLuongHienTai = int.Parse(selectedItem.SubItems[2].Text);

                        // Hiển thị hộp thoại để người dùng chỉnh sửa số lượng
                        int soLuongMoi = PromptForNewQuantity(soLuongHienTai);

                        // Update the selected item with the new quantity
                        selectedItem.SubItems[2].Text = soLuongMoi.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Mục này không có đủ thông tin để sửa số lượng.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một mục để sửa số lượng.");
                }
            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (var tenBan in listViewDictionary.Keys)
            {
                if (tableOpenTimes.ContainsKey(tenBan))
                {
                    DateTime openTime = tableOpenTimes[tenBan];
                    DateTime currentTime = DateTime.Now;
                    TimeSpan elapsedTime = currentTime - openTime;

                    // Find the existing panel for the table by its name
                    Panel tablePanel = Controls.Find($"panel_{tenBan}", true).FirstOrDefault() as Panel;

                    if (tablePanel != null)
                    {
                        // Update the panel's content to display the elapsed time
                        Label timeLabel = new Label();
                        timeLabel.Text = $"Bàn {tenBan}: {elapsedTime.Hours} giờ {elapsedTime.Minutes} phút {elapsedTime.Seconds} giây";
                        timeLabel.Dock = DockStyle.Fill;

                        // Clear existing controls in the panel and add the new timeLabel
                        tablePanel.Controls.Clear();
                        tablePanel.Controls.Add(timeLabel);
                    }
                }
            }
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

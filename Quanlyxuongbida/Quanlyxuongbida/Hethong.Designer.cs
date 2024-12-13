namespace Quanlyxuongbida
{
    partial class Hethong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_show = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_qlhd = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_qlkh = new System.Windows.Forms.Button();
            this.btn_qlnv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel_show);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 544);
            this.panel1.TabIndex = 0;
            // 
            // panel_show
            // 
            this.panel_show.BackgroundImage = global::Quanlyxuongbida.Properties.Resources._209488275_124544493167120_4580349109106941573_n;
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(193, 140);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(783, 404);
            this.panel_show.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btn_qlhd);
            this.panel3.Controls.Add(this.btn_menu);
            this.panel3.Controls.Add(this.btn_qlkh);
            this.panel3.Controls.Add(this.btn_qlnv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 404);
            this.panel3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(6, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_qlhd
            // 
            this.btn_qlhd.FlatAppearance.BorderSize = 0;
            this.btn_qlhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlhd.Location = new System.Drawing.Point(6, 223);
            this.btn_qlhd.Name = "btn_qlhd";
            this.btn_qlhd.Size = new System.Drawing.Size(181, 56);
            this.btn_qlhd.TabIndex = 3;
            this.btn_qlhd.Text = "Quản lý hóa đơn";
            this.btn_qlhd.UseVisualStyleBackColor = true;
            this.btn_qlhd.Click += new System.EventHandler(this.btn_qlhd_Click_1);
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(6, 149);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(181, 56);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "Quản lý bàn";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click_1);
            // 
            // btn_qlkh
            // 
            this.btn_qlkh.FlatAppearance.BorderSize = 0;
            this.btn_qlkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlkh.Location = new System.Drawing.Point(6, 78);
            this.btn_qlkh.Name = "btn_qlkh";
            this.btn_qlkh.Size = new System.Drawing.Size(181, 56);
            this.btn_qlkh.TabIndex = 1;
            this.btn_qlkh.Text = "Quản lý khách hàng";
            this.btn_qlkh.UseVisualStyleBackColor = true;
            this.btn_qlkh.Click += new System.EventHandler(this.btn_qlkh_Click_1);
            // 
            // btn_qlnv
            // 
            this.btn_qlnv.FlatAppearance.BorderSize = 0;
            this.btn_qlnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlnv.Location = new System.Drawing.Point(3, 6);
            this.btn_qlnv.Name = "btn_qlnv";
            this.btn_qlnv.Size = new System.Drawing.Size(184, 56);
            this.btn_qlnv.TabIndex = 0;
            this.btn_qlnv.Text = "Quản lý nhân viên";
            this.btn_qlnv.UseVisualStyleBackColor = true;
            this.btn_qlnv.Click += new System.EventHandler(this.btn_qlnv_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 140);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(193, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(783, 140);
            this.panel6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ XƯỞNG BILLIARDS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Quanlyxuongbida.Properties.Resources._349342333_950943772818898_5398354289256832057_n;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 140);
            this.panel5.TabIndex = 0;
            // 
            // Hethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 544);
            this.Controls.Add(this.panel1);
            this.Name = "Hethong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hethong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hethong_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_qlhd;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_qlkh;
        private System.Windows.Forms.Button btn_qlnv;
    }
}
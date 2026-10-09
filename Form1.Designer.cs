namespace EFcore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSinhVien = new DataGridView();
            btnTaiLai = new Button();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTrangThai = new Label();
            btnLocDat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(54, 231);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(673, 188);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(489, 166);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 29);
            btnTaiLai.TabIndex = 1;
            btnTaiLai.Text = "Tai Lai";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(201, 118);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(174, 27);
            txtHoTen.TabIndex = 2;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(454, 118);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(50, 27);
            txtDiem.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(351, 166);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(201, 166);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 166);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(54, 422);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 7;
            lblTrangThai.Text = "Tinh Trang";
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(633, 166);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(94, 29);
            btnLocDat.TabIndex = 8;
            btnLocDat.Text = "Loc";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(154, 29);
            label1.Name = "label1";
            label1.Size = new Size(405, 46);
            label1.TabIndex = 9;
            label1.Text = "Quản Lý Sinh Viên (CRUD)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 121);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 121);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Điểm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLocDat);
            Controls.Add(lblTrangThai);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(btnTaiLai);
            Controls.Add(dgvSinhVien);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Button btnTaiLai;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblTrangThai;
        private Button btnLocDat;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

namespace DATN2023FINAL.Views
{
    partial class ThemThuocVaoHDNForm
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAndContinue = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaNT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTPC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHamLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDongGoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLo = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtQuyDoi = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDinhMucTon = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.btnAddAndExit = new DevExpress.XtraEditors.SimpleButton();
            this.cmbM_ID = new System.Windows.Forms.ComboBox();
            this.txtDVNhap = new System.Windows.Forms.TextBox();
            this.txtDVTCB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Cancel;
            this.btnExit.Location = new System.Drawing.Point(570, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddAndContinue
            // 
            this.btnAddAndContinue.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAndContinue.Appearance.Options.UseFont = true;
            this.btnAddAndContinue.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Create;
            this.btnAddAndContinue.Location = new System.Drawing.Point(121, 313);
            this.btnAddAndContinue.Name = "btnAddAndContinue";
            this.btnAddAndContinue.Size = new System.Drawing.Size(121, 23);
            this.btnAddAndContinue.TabIndex = 17;
            this.btnAddAndContinue.Text = "Thêm và tiếp tục";
            this.btnAddAndContinue.Click += new System.EventHandler(this.btnAddAndContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã nhóm thuốc (*)";
            // 
            // cmbMaNT
            // 
            this.cmbMaNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNT.FormattingEnabled = true;
            this.cmbMaNT.Location = new System.Drawing.Point(121, 3);
            this.cmbMaNT.Name = "cmbMaNT";
            this.cmbMaNT.Size = new System.Drawing.Size(190, 21);
            this.cmbMaNT.TabIndex = 25;
            this.cmbMaNT.SelectedIndexChanged += new System.EventHandler(this.cmbMaNT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã thuốc (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên thuốc (*)";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(121, 71);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(190, 21);
            this.txtTen.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số đăng ký (*)";
            // 
            // txtSDK
            // 
            this.txtSDK.Location = new System.Drawing.Point(121, 104);
            this.txtSDK.Name = "txtSDK";
            this.txtSDK.Size = new System.Drawing.Size(190, 21);
            this.txtSDK.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "TP chính (*)";
            // 
            // txtTPC
            // 
            this.txtTPC.Location = new System.Drawing.Point(121, 139);
            this.txtTPC.Name = "txtTPC";
            this.txtTPC.Size = new System.Drawing.Size(190, 21);
            this.txtTPC.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hàm lượng (*)";
            // 
            // txtHamLuong
            // 
            this.txtHamLuong.Location = new System.Drawing.Point(121, 172);
            this.txtHamLuong.Name = "txtHamLuong";
            this.txtHamLuong.Size = new System.Drawing.Size(190, 21);
            this.txtHamLuong.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Đóng gói (*)";
            // 
            // txtDongGoi
            // 
            this.txtDongGoi.Location = new System.Drawing.Point(121, 204);
            this.txtDongGoi.Name = "txtDongGoi";
            this.txtDongGoi.Size = new System.Drawing.Size(190, 21);
            this.txtDongGoi.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Nước SX (*)";
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(121, 236);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(190, 21);
            this.txtNuocSX.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(350, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "ĐVT cơ bản (*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(350, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Số lô (*)";
            // 
            // txtSoLo
            // 
            this.txtSoLo.Location = new System.Drawing.Point(465, 36);
            this.txtSoLo.Name = "txtSoLo";
            this.txtSoLo.Size = new System.Drawing.Size(190, 21);
            this.txtSoLo.TabIndex = 27;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(465, 104);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(190, 21);
            this.txtSoLuong.TabIndex = 27;
            // 
            // txtQuyDoi
            // 
            this.txtQuyDoi.Location = new System.Drawing.Point(465, 172);
            this.txtQuyDoi.Name = "txtQuyDoi";
            this.txtQuyDoi.Size = new System.Drawing.Size(190, 21);
            this.txtQuyDoi.TabIndex = 27;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(465, 204);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(190, 21);
            this.txtGiaBan.TabIndex = 27;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(465, 236);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(190, 21);
            this.txtGiaNhap.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(350, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Hạn sử dụng (*)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(350, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Số lượng (*)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(350, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Đơn vị nhập (*)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(350, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Giá trị quy đổi (*)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(350, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Giá bán (*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(350, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Giá nhập (*)";
            // 
            // txtDinhMucTon
            // 
            this.txtDinhMucTon.Location = new System.Drawing.Point(305, 274);
            this.txtDinhMucTon.Name = "txtDinhMucTon";
            this.txtDinhMucTon.Size = new System.Drawing.Size(190, 21);
            this.txtDinhMucTon.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(190, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Định mức tồn (*)";
            // 
            // dtpHSD
            // 
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSD.Location = new System.Drawing.Point(465, 71);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(190, 21);
            this.dtpHSD.TabIndex = 29;
            // 
            // btnAddAndExit
            // 
            this.btnAddAndExit.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAndExit.Appearance.Options.UseFont = true;
            this.btnAddAndExit.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.OK;
            this.btnAddAndExit.Location = new System.Drawing.Point(341, 313);
            this.btnAddAndExit.Name = "btnAddAndExit";
            this.btnAddAndExit.Size = new System.Drawing.Size(122, 23);
            this.btnAddAndExit.TabIndex = 17;
            this.btnAddAndExit.Text = "Thêm và đóng";
            this.btnAddAndExit.Click += new System.EventHandler(this.btnAddAndExit_Click);
            // 
            // cmbM_ID
            // 
            this.cmbM_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM_ID.FormattingEnabled = true;
            this.cmbM_ID.Location = new System.Drawing.Point(121, 36);
            this.cmbM_ID.Name = "cmbM_ID";
            this.cmbM_ID.Size = new System.Drawing.Size(190, 21);
            this.cmbM_ID.TabIndex = 25;
            this.cmbM_ID.SelectedIndexChanged += new System.EventHandler(this.cmbM_ID_SelectedIndexChanged);
            // 
            // txtDVNhap
            // 
            this.txtDVNhap.Location = new System.Drawing.Point(465, 139);
            this.txtDVNhap.Name = "txtDVNhap";
            this.txtDVNhap.Size = new System.Drawing.Size(190, 21);
            this.txtDVNhap.TabIndex = 27;
            // 
            // txtDVTCB
            // 
            this.txtDVTCB.Location = new System.Drawing.Point(465, 3);
            this.txtDVTCB.Name = "txtDVTCB";
            this.txtDVTCB.Size = new System.Drawing.Size(190, 21);
            this.txtDVTCB.TabIndex = 27;
            // 
            // ThemThuocVaoHDNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 361);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDinhMucTon);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtDongGoi);
            this.Controls.Add(this.txtDVNhap);
            this.Controls.Add(this.txtQuyDoi);
            this.Controls.Add(this.txtHamLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTPC);
            this.Controls.Add(this.txtSDK);
            this.Controls.Add(this.txtDVTCB);
            this.Controls.Add(this.txtSoLo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbM_ID);
            this.Controls.Add(this.cmbMaNT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddAndExit);
            this.Controls.Add(this.btnAddAndContinue);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = global::DATN2023FINAL.Properties.Resources.medicine;
            this.Name = "ThemThuocVaoHDNForm";
            this.Text = "THÊM THUỐC VÀO HOÁ ĐƠN NHẬP";
            this.Load += new System.EventHandler(this.ThemThuocVaoHDNForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnExit;
        public DevExpress.XtraEditors.SimpleButton btnAddAndContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDinhMucTon;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ComboBox cmbMaNT;
        public System.Windows.Forms.TextBox txtTen;
        public System.Windows.Forms.TextBox txtSDK;
        public System.Windows.Forms.TextBox txtTPC;
        public System.Windows.Forms.TextBox txtHamLuong;
        public System.Windows.Forms.TextBox txtDongGoi;
        public System.Windows.Forms.TextBox txtNuocSX;
        public System.Windows.Forms.TextBox txtSoLo;
        public System.Windows.Forms.TextBox txtSoLuong;
        public System.Windows.Forms.TextBox txtQuyDoi;
        public System.Windows.Forms.TextBox txtGiaBan;
        public System.Windows.Forms.TextBox txtGiaNhap;
        public System.Windows.Forms.DateTimePicker dtpHSD;
        public DevExpress.XtraEditors.SimpleButton btnAddAndExit;
        public System.Windows.Forms.ComboBox cmbM_ID;
        public System.Windows.Forms.TextBox txtDVNhap;
        public System.Windows.Forms.TextBox txtDVTCB;
    }
}
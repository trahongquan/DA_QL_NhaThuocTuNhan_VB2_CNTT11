namespace DATN2023FINAL.Views
{
    partial class MedicineForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtDMT = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.M_IDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_SDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_TPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_HL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_NuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_BasicUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_ImPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_DMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(172, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH THUỐC";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtTenThuoc);
            this.panel2.Controls.Add(this.txtDMT);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.txtMaThuoc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaNT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 120);
            this.panel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Create;
            this.btnAdd.Location = new System.Drawing.Point(122, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(269, 37);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(186, 21);
            this.txtTenThuoc.TabIndex = 2;
            // 
            // txtDMT
            // 
            this.txtDMT.Location = new System.Drawing.Point(615, 37);
            this.txtDMT.Name = "txtDMT";
            this.txtDMT.Size = new System.Drawing.Size(130, 21);
            this.txtDMT.TabIndex = 4;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(480, 37);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 21);
            this.txtGiaBan.TabIndex = 3;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(139, 37);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(100, 21);
            this.txtMaThuoc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Định mức tồn \r\ntheo ĐVT cơ bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên thuốc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giá bán:";
            // 
            // txtMaNT
            // 
            this.txtMaNT.Location = new System.Drawing.Point(15, 37);
            this.txtMaNT.Name = "txtMaNT";
            this.txtMaNT.Size = new System.Drawing.Size(100, 21);
            this.txtMaNT.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã thuốc:";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Redo;
            this.btnCancel.Location = new System.Drawing.Point(415, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhóm thuốc:";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(509, 83);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.No_entry;
            this.btnDel.Location = new System.Drawing.Point(321, 83);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Xoá";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Modify;
            this.btnEdit.Location = new System.Drawing.Point(227, 83);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(285, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(228, 21);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm thuốc:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 46);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMedicine);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 183);
            this.panel3.TabIndex = 10;
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_IDG,
            this.M_ID,
            this.M_Name,
            this.M_SDK,
            this.M_TPC,
            this.M_HL,
            this.M_Package,
            this.M_NuocSX,
            this.M_BasicUnit,
            this.M_Batch,
            this.M_Dat,
            this.M_Quantity,
            this.M_Price,
            this.M_ImPrice,
            this.M_DMT});
            this.dgvMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicine.Location = new System.Drawing.Point(0, 0);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicine.Size = new System.Drawing.Size(806, 183);
            this.dgvMedicine.TabIndex = 0;
            this.dgvMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicine_CellClick);
            // 
            // M_IDG
            // 
            this.M_IDG.DataPropertyName = "M_IDG";
            this.M_IDG.HeaderText = "Mã nhóm thuốc";
            this.M_IDG.Name = "M_IDG";
            // 
            // M_ID
            // 
            this.M_ID.DataPropertyName = "M_ID";
            this.M_ID.HeaderText = "Mã thuốc";
            this.M_ID.Name = "M_ID";
            // 
            // M_Name
            // 
            this.M_Name.DataPropertyName = "M_Name";
            this.M_Name.HeaderText = "Tên thuốc";
            this.M_Name.Name = "M_Name";
            // 
            // M_SDK
            // 
            this.M_SDK.DataPropertyName = "M_SDK";
            this.M_SDK.HeaderText = "Số ĐK";
            this.M_SDK.Name = "M_SDK";
            // 
            // M_TPC
            // 
            this.M_TPC.DataPropertyName = "M_TPC";
            this.M_TPC.HeaderText = "Thành phần chính";
            this.M_TPC.Name = "M_TPC";
            // 
            // M_HL
            // 
            this.M_HL.DataPropertyName = "M_HL";
            this.M_HL.HeaderText = "Hàm lượng";
            this.M_HL.Name = "M_HL";
            // 
            // M_Package
            // 
            this.M_Package.DataPropertyName = "M_Package";
            this.M_Package.HeaderText = "Đóng gói";
            this.M_Package.Name = "M_Package";
            // 
            // M_NuocSX
            // 
            this.M_NuocSX.DataPropertyName = "M_NuocSX";
            this.M_NuocSX.HeaderText = "Nước SX";
            this.M_NuocSX.Name = "M_NuocSX";
            // 
            // M_BasicUnit
            // 
            this.M_BasicUnit.DataPropertyName = "M_BasicUnit";
            this.M_BasicUnit.HeaderText = "ĐVT cơ bản";
            this.M_BasicUnit.Name = "M_BasicUnit";
            // 
            // M_Batch
            // 
            this.M_Batch.DataPropertyName = "M_Batch";
            this.M_Batch.HeaderText = "Số lô";
            this.M_Batch.Name = "M_Batch";
            // 
            // M_Dat
            // 
            this.M_Dat.DataPropertyName = "M_Dat";
            this.M_Dat.HeaderText = "Hạn SD";
            this.M_Dat.Name = "M_Dat";
            // 
            // M_Quantity
            // 
            this.M_Quantity.DataPropertyName = "M_Quantity";
            this.M_Quantity.HeaderText = "Số lượng";
            this.M_Quantity.Name = "M_Quantity";
            // 
            // M_Price
            // 
            this.M_Price.DataPropertyName = "M_Price";
            this.M_Price.HeaderText = "Giá bán";
            this.M_Price.Name = "M_Price";
            // 
            // M_ImPrice
            // 
            this.M_ImPrice.DataPropertyName = "M_ImPrice";
            this.M_ImPrice.HeaderText = "Giá nhập";
            this.M_ImPrice.Name = "M_ImPrice";
            // 
            // M_DMT
            // 
            this.M_DMT.DataPropertyName = "M_DMT";
            this.M_DMT.HeaderText = "Định mức tồn";
            this.M_DMT.Name = "M_DMT";
            // 
            // MedicineForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 369);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.Text = "QUẢN LÝ THUỐC";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtDMT;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_IDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_SDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_TPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_HL;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_NuocSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_BasicUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_ImPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_DMT;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}
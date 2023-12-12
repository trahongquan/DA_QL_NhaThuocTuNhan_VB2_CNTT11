namespace DATN2023FINAL.Views
{
    partial class ChangePassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.ckbOld = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.ckbNew = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubmit = new System.Windows.Forms.TextBox();
            this.ckbSubmit = new System.Windows.Forms.CheckBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(46, 70);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(227, 21);
            this.txtOld.TabIndex = 1;
            // 
            // ckbOld
            // 
            this.ckbOld.AutoSize = true;
            this.ckbOld.BackColor = System.Drawing.Color.Transparent;
            this.ckbOld.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckbOld.Location = new System.Drawing.Point(279, 74);
            this.ckbOld.Name = "ckbOld";
            this.ckbOld.Size = new System.Drawing.Size(49, 19);
            this.ckbOld.TabIndex = 6;
            this.ckbOld.Text = "Hiện";
            this.ckbOld.UseVisualStyleBackColor = false;
            this.ckbOld.CheckedChanged += new System.EventHandler(this.ckbOld_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(46, 138);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(227, 21);
            this.txtNew.TabIndex = 2;
            // 
            // ckbNew
            // 
            this.ckbNew.AutoSize = true;
            this.ckbNew.BackColor = System.Drawing.Color.Transparent;
            this.ckbNew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckbNew.Location = new System.Drawing.Point(279, 142);
            this.ckbNew.Name = "ckbNew";
            this.ckbNew.Size = new System.Drawing.Size(49, 19);
            this.ckbNew.TabIndex = 6;
            this.ckbNew.Text = "Hiện";
            this.ckbNew.UseVisualStyleBackColor = false;
            this.ckbNew.CheckedChanged += new System.EventHandler(this.ckbNew_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác nhận MK mới:";
            // 
            // txtSubmit
            // 
            this.txtSubmit.Location = new System.Drawing.Point(46, 211);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(227, 21);
            this.txtSubmit.TabIndex = 3;
            // 
            // ckbSubmit
            // 
            this.ckbSubmit.AutoSize = true;
            this.ckbSubmit.BackColor = System.Drawing.Color.Transparent;
            this.ckbSubmit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckbSubmit.Location = new System.Drawing.Point(279, 215);
            this.ckbSubmit.Name = "ckbSubmit";
            this.ckbSubmit.Size = new System.Drawing.Size(49, 19);
            this.ckbSubmit.TabIndex = 6;
            this.ckbSubmit.Text = "Hiện";
            this.ckbSubmit.UseVisualStyleBackColor = false;
            this.ckbSubmit.CheckedChanged += new System.EventHandler(this.ckbSubmit_CheckedChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(198, 275);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.OK;
            this.btnSubmit.Location = new System.Drawing.Point(46, 275);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::DATN2023FINAL.Properties.Resources.backgroundChangePass;
            this.ClientSize = new System.Drawing.Size(366, 338);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ckbSubmit);
            this.Controls.Add(this.ckbNew);
            this.Controls.Add(this.ckbOld);
            this.Controls.Add(this.txtSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.label1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ChangePassForm.IconOptions.LargeImage")));
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.ChangePassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.CheckBox ckbOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.CheckBox ckbNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubmit;
        private System.Windows.Forms.CheckBox ckbSubmit;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}
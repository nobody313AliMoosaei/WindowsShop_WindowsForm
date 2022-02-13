
namespace WindowsShop
{
    partial class LoginForm
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
            this.linklbl_ChangePassword = new System.Windows.Forms.LinkLabel();
            this.btn_ShowFactor = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_NumberPhone = new System.Windows.Forms.Label();
            this.lbl_NationalCode = new System.Windows.Forms.Label();
            this.DG_Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl_ChangePassword
            // 
            this.linklbl_ChangePassword.AutoSize = true;
            this.linklbl_ChangePassword.Location = new System.Drawing.Point(12, 9);
            this.linklbl_ChangePassword.Name = "linklbl_ChangePassword";
            this.linklbl_ChangePassword.Size = new System.Drawing.Size(61, 28);
            this.linklbl_ChangePassword.TabIndex = 1;
            this.linklbl_ChangePassword.TabStop = true;
            this.linklbl_ChangePassword.Text = "تغییر رمز";
            this.linklbl_ChangePassword.Click += new System.EventHandler(this.linklbl_ChangePassword_Click);
            // 
            // btn_ShowFactor
            // 
            this.btn_ShowFactor.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ShowFactor.Enabled = false;
            this.btn_ShowFactor.Location = new System.Drawing.Point(425, 388);
            this.btn_ShowFactor.Name = "btn_ShowFactor";
            this.btn_ShowFactor.Size = new System.Drawing.Size(242, 41);
            this.btn_ShowFactor.TabIndex = 5;
            this.btn_ShowFactor.Text = "مشاهده فاکتور";
            this.btn_ShowFactor.UseVisualStyleBackColor = false;
            this.btn_ShowFactor.Click += new System.EventHandler(this.btn_ShowFactor_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(47, 388);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(218, 41);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "برگشت";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشخصات : ";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(628, 9);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_FullName.Size = new System.Drawing.Size(55, 28);
            this.lbl_FullName.TabIndex = 0;
            this.lbl_FullName.Text = "نام کامل";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(474, 9);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Email.Size = new System.Drawing.Size(40, 28);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "ایمیل";
            // 
            // lbl_NumberPhone
            // 
            this.lbl_NumberPhone.AutoSize = true;
            this.lbl_NumberPhone.Location = new System.Drawing.Point(297, 9);
            this.lbl_NumberPhone.Name = "lbl_NumberPhone";
            this.lbl_NumberPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_NumberPhone.Size = new System.Drawing.Size(71, 28);
            this.lbl_NumberPhone.TabIndex = 0;
            this.lbl_NumberPhone.Text = "شماره تلفن";
            // 
            // lbl_NationalCode
            // 
            this.lbl_NationalCode.AutoSize = true;
            this.lbl_NationalCode.Location = new System.Drawing.Point(166, 9);
            this.lbl_NationalCode.Name = "lbl_NationalCode";
            this.lbl_NationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_NationalCode.Size = new System.Drawing.Size(46, 28);
            this.lbl_NationalCode.TabIndex = 0;
            this.lbl_NationalCode.Text = "کدملی";
            // 
            // DG_Entity
            // 
            this.DG_Entity.HeaderText = "موجودی";
            this.DG_Entity.Name = "DG_Entity";
            this.DG_Entity.ReadOnly = true;
            // 
            // DG_Price
            // 
            this.DG_Price.HeaderText = "قیمت";
            this.DG_Price.Name = "DG_Price";
            this.DG_Price.ReadOnly = true;
            // 
            // DG_Description
            // 
            this.DG_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DG_Description.HeaderText = "توضیحات";
            this.DG_Description.Name = "DG_Description";
            this.DG_Description.ReadOnly = true;
            // 
            // DG_Name
            // 
            this.DG_Name.HeaderText = "نام کالا";
            this.DG_Name.Name = "DG_Name";
            this.DG_Name.ReadOnly = true;
            // 
            // DG_Id
            // 
            this.DG_Id.FillWeight = 150F;
            this.DG_Id.Frozen = true;
            this.DG_Id.HeaderText = "شماره";
            this.DG_Id.Name = "DG_Id";
            this.DG_Id.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_Id,
            this.DG_Name,
            this.DG_Description,
            this.DG_Price,
            this.DG_Entity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 308);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 441);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ShowFactor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linklbl_ChangePassword);
            this.Controls.Add(this.lbl_NationalCode);
            this.Controls.Add(this.lbl_NumberPhone);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "ا";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linklbl_ChangePassword;
        private System.Windows.Forms.Button btn_ShowFactor;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_NumberPhone;
        private System.Windows.Forms.Label lbl_NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Id;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
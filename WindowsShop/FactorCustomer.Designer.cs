
namespace WindowsShop
{
    partial class FactorCustomer
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DG_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_factorId = new System.Windows.Forms.Label();
            this.lbl_NumberPhone_factor = new System.Windows.Forms.Label();
            this.lbl_TotalPrice_Factor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit_Factor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_FullName_Factor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_Id,
            this.DG_Name,
            this.DG_Description,
            this.DG_Price,
            this.DG_Entity});
            this.dataGridView.Location = new System.Drawing.Point(12, 107);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(801, 308);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // DG_Id
            // 
            this.DG_Id.FillWeight = 150F;
            this.DG_Id.Frozen = true;
            this.DG_Id.HeaderText = "شماره";
            this.DG_Id.Name = "DG_Id";
            this.DG_Id.ReadOnly = true;
            // 
            // DG_Name
            // 
            this.DG_Name.HeaderText = "نام کالا";
            this.DG_Name.Name = "DG_Name";
            this.DG_Name.ReadOnly = true;
            // 
            // DG_Description
            // 
            this.DG_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DG_Description.HeaderText = "توضیحات";
            this.DG_Description.Name = "DG_Description";
            this.DG_Description.ReadOnly = true;
            // 
            // DG_Price
            // 
            this.DG_Price.HeaderText = "قیمت";
            this.DG_Price.Name = "DG_Price";
            this.DG_Price.ReadOnly = true;
            // 
            // DG_Entity
            // 
            this.DG_Entity.HeaderText = "تعداد";
            this.DG_Entity.Name = "DG_Entity";
            this.DG_Entity.ReadOnly = true;
            // 
            // lbl_factorId
            // 
            this.lbl_factorId.AutoSize = true;
            this.lbl_factorId.Location = new System.Drawing.Point(58, 43);
            this.lbl_factorId.Name = "lbl_factorId";
            this.lbl_factorId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_factorId.Size = new System.Drawing.Size(49, 27);
            this.lbl_factorId.TabIndex = 3;
            this.lbl_factorId.Text = "کدملی";
            // 
            // lbl_NumberPhone_factor
            // 
            this.lbl_NumberPhone_factor.AutoSize = true;
            this.lbl_NumberPhone_factor.Location = new System.Drawing.Point(249, 43);
            this.lbl_NumberPhone_factor.Name = "lbl_NumberPhone_factor";
            this.lbl_NumberPhone_factor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_NumberPhone_factor.Size = new System.Drawing.Size(91, 27);
            this.lbl_NumberPhone_factor.TabIndex = 4;
            this.lbl_NumberPhone_factor.Text = "شماره فاکتور : ";
            // 
            // lbl_TotalPrice_Factor
            // 
            this.lbl_TotalPrice_Factor.AutoSize = true;
            this.lbl_TotalPrice_Factor.Location = new System.Drawing.Point(517, 452);
            this.lbl_TotalPrice_Factor.Name = "lbl_TotalPrice_Factor";
            this.lbl_TotalPrice_Factor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_TotalPrice_Factor.Size = new System.Drawing.Size(58, 27);
            this.lbl_TotalPrice_Factor.TabIndex = 6;
            this.lbl_TotalPrice_Factor.Text = "نام کامل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 452);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "جمع کل : ";
            // 
            // btn_Exit_Factor
            // 
            this.btn_Exit_Factor.BackColor = System.Drawing.Color.Red;
            this.btn_Exit_Factor.Location = new System.Drawing.Point(12, 455);
            this.btn_Exit_Factor.Name = "btn_Exit_Factor";
            this.btn_Exit_Factor.Size = new System.Drawing.Size(121, 32);
            this.btn_Exit_Factor.TabIndex = 9;
            this.btn_Exit_Factor.Text = "برگشت";
            this.btn_Exit_Factor.UseVisualStyleBackColor = false;
            this.btn_Exit_Factor.Click += new System.EventHandler(this.btn_Exit_Factor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 43);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام مشتری : ";
            // 
            // lbl_FullName_Factor
            // 
            this.lbl_FullName_Factor.AutoSize = true;
            this.lbl_FullName_Factor.Location = new System.Drawing.Point(517, 43);
            this.lbl_FullName_Factor.Name = "lbl_FullName_Factor";
            this.lbl_FullName_Factor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_FullName_Factor.Size = new System.Drawing.Size(58, 27);
            this.lbl_FullName_Factor.TabIndex = 6;
            this.lbl_FullName_Factor.Text = "نام کامل";
            // 
            // FactorCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 499);
            this.Controls.Add(this.btn_Exit_Factor);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbl_factorId);
            this.Controls.Add(this.lbl_NumberPhone_factor);
            this.Controls.Add(this.lbl_FullName_Factor);
            this.Controls.Add(this.lbl_TotalPrice_Factor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("2  Roya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FactorCustomer";
            this.Text = "FactorCustomer";
            this.Load += new System.EventHandler(this.FactorCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbl_factorId;
        private System.Windows.Forms.Label lbl_NumberPhone_factor;
        private System.Windows.Forms.Label lbl_TotalPrice_Factor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Entity;
        private System.Windows.Forms.Button btn_Exit_Factor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_FullName_Factor;
    }
}
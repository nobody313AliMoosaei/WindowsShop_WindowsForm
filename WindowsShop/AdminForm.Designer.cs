
namespace WindowsShop
{
    partial class AdminForm
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
            this.btn_Save_CP = new System.Windows.Forms.Button();
            this.txt_PasswordAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserNameAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save_CP
            // 
            this.btn_Save_CP.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Save_CP.Location = new System.Drawing.Point(170, 208);
            this.btn_Save_CP.Name = "btn_Save_CP";
            this.btn_Save_CP.Size = new System.Drawing.Size(102, 41);
            this.btn_Save_CP.TabIndex = 9;
            this.btn_Save_CP.Text = "تائید";
            this.btn_Save_CP.UseVisualStyleBackColor = false;
            this.btn_Save_CP.Click += new System.EventHandler(this.btn_Save_CP_Click);
            // 
            // txt_PasswordAdmin
            // 
            this.txt_PasswordAdmin.Location = new System.Drawing.Point(128, 107);
            this.txt_PasswordAdmin.Name = "txt_PasswordAdmin";
            this.txt_PasswordAdmin.PasswordChar = '*';
            this.txt_PasswordAdmin.Size = new System.Drawing.Size(254, 35);
            this.txt_PasswordAdmin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "رمز ادمین : ";
            // 
            // txt_UserNameAdmin
            // 
            this.txt_UserNameAdmin.Location = new System.Drawing.Point(128, 52);
            this.txt_UserNameAdmin.Name = "txt_UserNameAdmin";
            this.txt_UserNameAdmin.Size = new System.Drawing.Size(254, 35);
            this.txt_UserNameAdmin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام کاربری ادمین : ";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 334);
            this.Controls.Add(this.btn_Save_CP);
            this.Controls.Add(this.txt_PasswordAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserNameAdmin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save_CP;
        private System.Windows.Forms.TextBox txt_PasswordAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserNameAdmin;
        private System.Windows.Forms.Label label1;
    }
}
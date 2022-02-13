
namespace WindowsShop
{
    partial class ChangePassword_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OldPassword_CP = new System.Windows.Forms.TextBox();
            this.txt_NewPassword_CP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save_CP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "رمز قبلی : ";
            // 
            // txt_OldPassword_CP
            // 
            this.txt_OldPassword_CP.Location = new System.Drawing.Point(84, 28);
            this.txt_OldPassword_CP.Name = "txt_OldPassword_CP";
            this.txt_OldPassword_CP.Size = new System.Drawing.Size(224, 30);
            this.txt_OldPassword_CP.TabIndex = 1;
            // 
            // txt_NewPassword_CP
            // 
            this.txt_NewPassword_CP.Location = new System.Drawing.Point(84, 86);
            this.txt_NewPassword_CP.Name = "txt_NewPassword_CP";
            this.txt_NewPassword_CP.Size = new System.Drawing.Size(224, 30);
            this.txt_NewPassword_CP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "رمز فعلی : ";
            // 
            // btn_Save_CP
            // 
            this.btn_Save_CP.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Save_CP.Location = new System.Drawing.Point(120, 165);
            this.btn_Save_CP.Name = "btn_Save_CP";
            this.btn_Save_CP.Size = new System.Drawing.Size(102, 41);
            this.btn_Save_CP.TabIndex = 4;
            this.btn_Save_CP.Text = "تائید";
            this.btn_Save_CP.UseVisualStyleBackColor = false;
            this.btn_Save_CP.Click += new System.EventHandler(this.btn_Save_CP_Click);
            // 
            // ChangePassword_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 266);
            this.Controls.Add(this.btn_Save_CP);
            this.Controls.Add(this.txt_NewPassword_CP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OldPassword_CP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("2  Koodak", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ChangePassword_Form";
            this.Text = "ChangePassword_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_OldPassword_CP;
        private System.Windows.Forms.TextBox txt_NewPassword_CP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save_CP;
    }
}
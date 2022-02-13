
namespace WindowsShop
{
    partial class CustomerForm
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
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.btnEnter_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfullName_Login = new System.Windows.Forms.TextBox();
            this.groupBox_Creat = new System.Windows.Forms.GroupBox();
            this.btnCreatNewAccount_Creat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumberPhone_Creat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNationalCode_Creat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword_Creat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail_Creat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName_Creat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCreatNewAccouunt = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox_Login.SuspendLayout();
            this.groupBox_Creat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.btnEnter_login);
            this.groupBox_Login.Controls.Add(this.label2);
            this.groupBox_Login.Controls.Add(this.txtPassword_Login);
            this.groupBox_Login.Controls.Add(this.label1);
            this.groupBox_Login.Controls.Add(this.txtfullName_Login);
            this.groupBox_Login.Enabled = false;
            this.groupBox_Login.Location = new System.Drawing.Point(142, 12);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(306, 335);
            this.groupBox_Login.TabIndex = 0;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Login";
            // 
            // btnEnter_login
            // 
            this.btnEnter_login.BackColor = System.Drawing.Color.Chartreuse;
            this.btnEnter_login.Font = new System.Drawing.Font("2  Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEnter_login.Location = new System.Drawing.Point(56, 250);
            this.btnEnter_login.Name = "btnEnter_login";
            this.btnEnter_login.Size = new System.Drawing.Size(212, 57);
            this.btnEnter_login.TabIndex = 4;
            this.btnEnter_login.Text = "ورود";
            this.btnEnter_login.UseVisualStyleBackColor = false;
            this.btnEnter_login.Click += new System.EventHandler(this.btnEnter_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "رمز : ";
            // 
            // txtPassword_Login
            // 
            this.txtPassword_Login.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword_Login.Location = new System.Drawing.Point(121, 69);
            this.txtPassword_Login.Name = "txtPassword_Login";
            this.txtPassword_Login.PasswordChar = '*';
            this.txtPassword_Login.Size = new System.Drawing.Size(179, 35);
            this.txtPassword_Login.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ایمیل یا شماره تلفن : ";
            // 
            // txtfullName_Login
            // 
            this.txtfullName_Login.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfullName_Login.Location = new System.Drawing.Point(133, 28);
            this.txtfullName_Login.Name = "txtfullName_Login";
            this.txtfullName_Login.Size = new System.Drawing.Size(167, 35);
            this.txtfullName_Login.TabIndex = 0;
            // 
            // groupBox_Creat
            // 
            this.groupBox_Creat.Controls.Add(this.btnCreatNewAccount_Creat);
            this.groupBox_Creat.Controls.Add(this.label9);
            this.groupBox_Creat.Controls.Add(this.txtNumberPhone_Creat);
            this.groupBox_Creat.Controls.Add(this.label8);
            this.groupBox_Creat.Controls.Add(this.txtNationalCode_Creat);
            this.groupBox_Creat.Controls.Add(this.label7);
            this.groupBox_Creat.Controls.Add(this.txtPassword_Creat);
            this.groupBox_Creat.Controls.Add(this.label6);
            this.groupBox_Creat.Controls.Add(this.txtEmail_Creat);
            this.groupBox_Creat.Controls.Add(this.label5);
            this.groupBox_Creat.Controls.Add(this.txtFullName_Creat);
            this.groupBox_Creat.Enabled = false;
            this.groupBox_Creat.Location = new System.Drawing.Point(458, 12);
            this.groupBox_Creat.Name = "groupBox_Creat";
            this.groupBox_Creat.Size = new System.Drawing.Size(357, 335);
            this.groupBox_Creat.TabIndex = 1;
            this.groupBox_Creat.TabStop = false;
            this.groupBox_Creat.Text = "Creat New Account";
            // 
            // btnCreatNewAccount_Creat
            // 
            this.btnCreatNewAccount_Creat.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCreatNewAccount_Creat.Font = new System.Drawing.Font("2  Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCreatNewAccount_Creat.Location = new System.Drawing.Point(72, 250);
            this.btnCreatNewAccount_Creat.Name = "btnCreatNewAccount_Creat";
            this.btnCreatNewAccount_Creat.Size = new System.Drawing.Size(212, 57);
            this.btnCreatNewAccount_Creat.TabIndex = 12;
            this.btnCreatNewAccount_Creat.Text = "ساخت اکانت";
            this.btnCreatNewAccount_Creat.UseVisualStyleBackColor = false;
            this.btnCreatNewAccount_Creat.Click += new System.EventHandler(this.btnCreatNewAccount_Creat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(18, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "شماره تلفن : ";
            // 
            // txtNumberPhone_Creat
            // 
            this.txtNumberPhone_Creat.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumberPhone_Creat.Location = new System.Drawing.Point(134, 188);
            this.txtNumberPhone_Creat.Name = "txtNumberPhone_Creat";
            this.txtNumberPhone_Creat.Size = new System.Drawing.Size(179, 35);
            this.txtNumberPhone_Creat.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(18, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "کد ملی : ";
            // 
            // txtNationalCode_Creat
            // 
            this.txtNationalCode_Creat.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNationalCode_Creat.Location = new System.Drawing.Point(134, 147);
            this.txtNationalCode_Creat.Name = "txtNationalCode_Creat";
            this.txtNationalCode_Creat.Size = new System.Drawing.Size(179, 35);
            this.txtNationalCode_Creat.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(18, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "رمز : ";
            // 
            // txtPassword_Creat
            // 
            this.txtPassword_Creat.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword_Creat.Location = new System.Drawing.Point(134, 106);
            this.txtPassword_Creat.Name = "txtPassword_Creat";
            this.txtPassword_Creat.PasswordChar = '*';
            this.txtPassword_Creat.Size = new System.Drawing.Size(179, 35);
            this.txtPassword_Creat.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(18, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "ایمیل : ";
            // 
            // txtEmail_Creat
            // 
            this.txtEmail_Creat.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail_Creat.Location = new System.Drawing.Point(134, 65);
            this.txtEmail_Creat.Name = "txtEmail_Creat";
            this.txtEmail_Creat.Size = new System.Drawing.Size(179, 35);
            this.txtEmail_Creat.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(18, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "نام و نام خانوادگی : ";
            // 
            // txtFullName_Creat
            // 
            this.txtFullName_Creat.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullName_Creat.Location = new System.Drawing.Point(134, 19);
            this.txtFullName_Creat.Name = "txtFullName_Creat";
            this.txtFullName_Creat.Size = new System.Drawing.Size(179, 35);
            this.txtFullName_Creat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "یکی از گزینه های ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("2  Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = " : زیر را انتخاب کنید";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("2  Mah", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEnter.Location = new System.Drawing.Point(35, 116);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 34);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "ورود";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCreatNewAccouunt
            // 
            this.btnCreatNewAccouunt.Font = new System.Drawing.Font("2  Mah", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCreatNewAccouunt.Location = new System.Drawing.Point(12, 166);
            this.btnCreatNewAccouunt.Name = "btnCreatNewAccouunt";
            this.btnCreatNewAccouunt.Size = new System.Drawing.Size(124, 34);
            this.btnCreatNewAccouunt.TabIndex = 3;
            this.btnCreatNewAccouunt.Text = "ساخت حساب جدید";
            this.btnCreatNewAccouunt.UseVisualStyleBackColor = true;
            this.btnCreatNewAccouunt.Click += new System.EventHandler(this.btnCreatNewAccouunt_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("2  Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(17, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "بازگشت";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 359);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCreatNewAccouunt);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox_Creat);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.RightToLeftLayout = true;
            this.Text = "CustomerForm";
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.groupBox_Creat.ResumeLayout(false);
            this.groupBox_Creat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfullName_Login;
        private System.Windows.Forms.GroupBox groupBox_Creat;
        private System.Windows.Forms.Button btnEnter_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword_Login;
        private System.Windows.Forms.Button btnCreatNewAccount_Creat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumberPhone_Creat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNationalCode_Creat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword_Creat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail_Creat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName_Creat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCreatNewAccouunt;
        private System.Windows.Forms.Button button4;
    }
}
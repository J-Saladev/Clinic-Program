namespace Clinic_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtusererror = new Label();
            txtpassworderror = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(258, 19);
            label1.Name = "label1";
            label1.Size = new Size(279, 49);
            label1.TabIndex = 0;
            label1.Text = "Antwort Clinic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(255, 68);
            label2.Name = "label2";
            label2.Size = new Size(282, 23);
            label2.TabIndex = 1;
            label2.Text = "We appreciate all your hard work!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(487, 124);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(487, 200);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(509, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 28);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(509, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 28);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(509, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 53);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtusererror
            // 
            txtusererror.AutoSize = true;
            txtusererror.BackColor = SystemColors.Control;
            txtusererror.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtusererror.ForeColor = Color.Red;
            txtusererror.Location = new Point(487, 181);
            txtusererror.Name = "txtusererror";
            txtusererror.Size = new Size(195, 20);
            txtusererror.TabIndex = 8;
            txtusererror.Text = "Please enter your username";
            txtusererror.Visible = false;
            // 
            // txtpassworderror
            // 
            txtpassworderror.AutoSize = true;
            txtpassworderror.BackColor = SystemColors.Control;
            txtpassworderror.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassworderror.ForeColor = Color.Red;
            txtpassworderror.Location = new Point(487, 257);
            txtpassworderror.Name = "txtpassworderror";
            txtpassworderror.Size = new Size(191, 20);
            txtpassworderror.TabIndex = 9;
            txtpassworderror.Text = "Please enter your password";
            txtpassworderror.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpassworderror);
            Controls.Add(txtusererror);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label txtusererror;
        private Label txtpassworderror;
    }
}
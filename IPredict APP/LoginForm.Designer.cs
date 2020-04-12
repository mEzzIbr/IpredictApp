namespace IPredict_APP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(564, 232);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 26);
            this.txtPhone.TabIndex = 0;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(564, 310);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(265, 26);
            this.TxtPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(406, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PhoneNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(430, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Maroon;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogin.Location = new System.Drawing.Point(649, 399);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(115, 37);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.txtPhone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
    }
}
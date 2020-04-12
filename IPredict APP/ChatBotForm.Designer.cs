namespace IPredict_APP
{
    partial class ChatBotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBotForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserTextbox = new System.Windows.Forms.RichTextBox();
            this.AppTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserTextbox
            // 
            this.UserTextbox.Location = new System.Drawing.Point(12, 301);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(332, 96);
            this.UserTextbox.TabIndex = 1;
            this.UserTextbox.Text = "";
            // 
            // AppTextBox
            // 
            this.AppTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTextBox.Location = new System.Drawing.Point(12, 131);
            this.AppTextBox.Name = "AppTextBox";
            this.AppTextBox.Size = new System.Drawing.Size(332, 143);
            this.AppTextBox.TabIndex = 2;
            this.AppTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(321, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ask";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(408, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AppTextBox);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChatBotForm";
            this.Text = "ChatBotForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox UserTextbox;
        private System.Windows.Forms.RichTextBox AppTextBox;
        private System.Windows.Forms.Button button1;
    }
}
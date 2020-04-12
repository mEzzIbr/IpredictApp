namespace IPredict_APP
{
    partial class PointsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.userpointsform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Currently Points is :";
            // 
            // userpointsform
            // 
            this.userpointsform.AutoSize = true;
            this.userpointsform.Location = new System.Drawing.Point(338, 97);
            this.userpointsform.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.userpointsform.Name = "userpointsform";
            this.userpointsform.Size = new System.Drawing.Size(75, 25);
            this.userpointsform.TabIndex = 1;
            this.userpointsform.Text = "label2";
            // 
            // PointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 332);
            this.Controls.Add(this.userpointsform);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PointsForm";
            this.Text = "PointsForm";
            this.Load += new System.EventHandler(this.PointsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label userpointsform;
    }
}
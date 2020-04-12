namespace IPredict_APP
{
    partial class WithDrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithDrawForm));
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.boxwithdraw = new System.Windows.Forms.TextBox();
            this.btnconverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnwithdraw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnwithdraw.Location = new System.Drawing.Point(491, 245);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(115, 35);
            this.btnwithdraw.TabIndex = 0;
            this.btnwithdraw.Text = "WithDraw";
            this.btnwithdraw.UseVisualStyleBackColor = true;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // boxwithdraw
            // 
            this.boxwithdraw.Location = new System.Drawing.Point(213, 82);
            this.boxwithdraw.Name = "boxwithdraw";
            this.boxwithdraw.Size = new System.Drawing.Size(202, 27);
            this.boxwithdraw.TabIndex = 1;
            // 
            // btnconverter
            // 
            this.btnconverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconverter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnconverter.Location = new System.Drawing.Point(54, 245);
            this.btnconverter.Name = "btnconverter";
            this.btnconverter.Size = new System.Drawing.Size(115, 35);
            this.btnconverter.TabIndex = 2;
            this.btnconverter.Text = "Count First";
            this.btnconverter.UseVisualStyleBackColor = true;
            this.btnconverter.Click += new System.EventHandler(this.btnconverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Points";
            // 
            // WithDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(43)))), ((int)(((byte)(37)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconverter);
            this.Controls.Add(this.boxwithdraw);
            this.Controls.Add(this.btnwithdraw);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WithDrawForm";
            this.Text = "WithDrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.TextBox boxwithdraw;
        private System.Windows.Forms.Button btnconverter;
        private System.Windows.Forms.Label label1;
    }
}
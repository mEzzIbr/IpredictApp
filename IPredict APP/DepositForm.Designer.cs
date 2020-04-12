namespace IPredict_APP
{
    partial class DepositForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositBox = new System.Windows.Forms.TextBox();
            this.PotentialBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TheShownOdds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Trade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stake ( Put Your Points)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potenial Winning Points";
            // 
            // DepositBox
            // 
            this.DepositBox.Location = new System.Drawing.Point(305, 36);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(178, 33);
            this.DepositBox.TabIndex = 3;
            // 
            // PotentialBox
            // 
            this.PotentialBox.Location = new System.Drawing.Point(305, 113);
            this.PotentialBox.Name = "PotentialBox";
            this.PotentialBox.ReadOnly = true;
            this.PotentialBox.Size = new System.Drawing.Size(178, 33);
            this.PotentialBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(104, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "The Odds : ";
            // 
            // TheShownOdds
            // 
            this.TheShownOdds.AutoSize = true;
            this.TheShownOdds.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TheShownOdds.Location = new System.Drawing.Point(363, 182);
            this.TheShownOdds.Name = "TheShownOdds";
            this.TheShownOdds.Size = new System.Drawing.Size(62, 25);
            this.TheShownOdds.TabIndex = 6;
            this.TheShownOdds.Text = "odds";
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(588, 316);
            this.Controls.Add(this.TheShownOdds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PotentialBox);
            this.Controls.Add(this.DepositBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DepositBox;
        public System.Windows.Forms.TextBox PotentialBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TheShownOdds;
    }
}
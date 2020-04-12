namespace IPredict_APP
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.TxtPointAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTransfer.Location = new System.Drawing.Point(138, 253);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(156, 45);
            this.BtnTransfer.TabIndex = 0;
            this.BtnTransfer.Text = "Transfer";
            this.BtnTransfer.UseVisualStyleBackColor = false;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(138, 92);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(156, 31);
            this.txtMemberID.TabIndex = 1;
            // 
            // TxtPointAmount
            // 
            this.TxtPointAmount.Location = new System.Drawing.Point(138, 167);
            this.TxtPointAmount.Name = "TxtPointAmount";
            this.TxtPointAmount.Size = new System.Drawing.Size(156, 31);
            this.TxtPointAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(29, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPointAmount);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.BtnTransfer);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTransfer;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox TxtPointAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
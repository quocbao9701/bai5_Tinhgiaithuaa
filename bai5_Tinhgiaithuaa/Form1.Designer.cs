namespace bai5_Tinhgiaithuaa
{
    partial class Form1
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.Tinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trbSo = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbSo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(110, 27);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 20);
            this.txtSo.TabIndex = 0;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(110, 70);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 20);
            this.txtKq.TabIndex = 0;
            // 
            // Tinh
            // 
            this.Tinh.Location = new System.Drawing.Point(54, 136);
            this.Tinh.Name = "Tinh";
            this.Tinh.Size = new System.Drawing.Size(156, 23);
            this.Tinh.TabIndex = 1;
            this.Tinh.Text = "Tinh Giai Thua";
            this.Tinh.UseVisualStyleBackColor = true;
            this.Tinh.Click += new System.EventHandler(this.Tinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // trbSo
            // 
            this.trbSo.Location = new System.Drawing.Point(251, 27);
            this.trbSo.Maximum = 50;
            this.trbSo.Name = "trbSo";
            this.trbSo.Size = new System.Drawing.Size(206, 45);
            this.trbSo.TabIndex = 4;
            this.trbSo.Scroll += new System.EventHandler(this.trbSo_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 345);
            this.Controls.Add(this.trbSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tinh);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtSo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button Tinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbSo;
    }
}


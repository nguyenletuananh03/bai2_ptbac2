namespace bai2_ptbac2
{
    partial class btntinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.bnttinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhap a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhap b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "KQ";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(273, 61);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 1;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(273, 97);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(273, 129);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 1;
            // 
            // bnttinh
            // 
            this.bnttinh.Location = new System.Drawing.Point(286, 164);
            this.bnttinh.Name = "bnttinh";
            this.bnttinh.Size = new System.Drawing.Size(75, 23);
            this.bnttinh.TabIndex = 2;
            this.bnttinh.Text = "tính";
            this.bnttinh.UseVisualStyleBackColor = true;
            this.bnttinh.Click += new System.EventHandler(this.bnttinh_Click);
            // 
            // btntinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnttinh);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btntinh";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button bnttinh;
    }
}


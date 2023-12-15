namespace KDVHesap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbKdv1 = new System.Windows.Forms.RadioButton();
            this.rdbKdv8 = new System.Windows.Forms.RadioButton();
            this.rdbKdv18 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Fiyatı";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(99, 18);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(141, 20);
            this.txtProductPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(98, 66);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(142, 20);
            this.txtAdet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "KDV";
            // 
            // rdbKdv1
            // 
            this.rdbKdv1.AutoSize = true;
            this.rdbKdv1.Location = new System.Drawing.Point(95, 108);
            this.rdbKdv1.Name = "rdbKdv1";
            this.rdbKdv1.Size = new System.Drawing.Size(39, 17);
            this.rdbKdv1.TabIndex = 5;
            this.rdbKdv1.TabStop = true;
            this.rdbKdv1.Text = "%1";
            this.rdbKdv1.UseVisualStyleBackColor = true;
            // 
            // rdbKdv8
            // 
            this.rdbKdv8.AutoSize = true;
            this.rdbKdv8.Location = new System.Drawing.Point(140, 108);
            this.rdbKdv8.Name = "rdbKdv8";
            this.rdbKdv8.Size = new System.Drawing.Size(39, 17);
            this.rdbKdv8.TabIndex = 6;
            this.rdbKdv8.TabStop = true;
            this.rdbKdv8.Text = "%8";
            this.rdbKdv8.UseVisualStyleBackColor = true;
            // 
            // rdbKdv18
            // 
            this.rdbKdv18.AutoSize = true;
            this.rdbKdv18.Location = new System.Drawing.Point(193, 108);
            this.rdbKdv18.Name = "rdbKdv18";
            this.rdbKdv18.Size = new System.Drawing.Size(45, 17);
            this.rdbKdv18.TabIndex = 7;
            this.rdbKdv18.TabStop = true;
            this.rdbKdv18.Text = "%18";
            this.rdbKdv18.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ödenecek Tutar:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(138, 184);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 9;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(165, 140);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 213);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbKdv18);
            this.Controls.Add(this.rdbKdv8);
            this.Controls.Add(this.rdbKdv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbKdv1;
        private System.Windows.Forms.RadioButton rdbKdv8;
        private System.Windows.Forms.RadioButton rdbKdv18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnHesapla;
    }
}


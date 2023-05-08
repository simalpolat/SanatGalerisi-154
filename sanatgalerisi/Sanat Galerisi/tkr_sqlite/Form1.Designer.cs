namespace tkr_sqlite
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnarama = new System.Windows.Forms.Button();
			this.btnkapat = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(390, 78);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ana Menü";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(45, 277);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(268, 67);
			this.button1.TabIndex = 1;
			this.button1.Text = "İşlemler";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnarama
			// 
			this.btnarama.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnarama.Location = new System.Drawing.Point(45, 350);
			this.btnarama.Name = "btnarama";
			this.btnarama.Size = new System.Drawing.Size(268, 67);
			this.btnarama.TabIndex = 5;
			this.btnarama.Text = "Eser Arama";
			this.btnarama.UseVisualStyleBackColor = true;
			this.btnarama.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnkapat
			// 
			this.btnkapat.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnkapat.Location = new System.Drawing.Point(45, 423);
			this.btnkapat.Name = "btnkapat";
			this.btnkapat.Size = new System.Drawing.Size(268, 67);
			this.btnkapat.TabIndex = 6;
			this.btnkapat.Text = "Kapat";
			this.btnkapat.UseVisualStyleBackColor = true;
			this.btnkapat.Click += new System.EventHandler(this.button6_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::tkr_sqlite.Properties.Resources._19_04_23;
			this.pictureBox1.Location = new System.Drawing.Point(384, -27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(624, 792);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(973, 551);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnkapat);
			this.Controls.Add(this.btnarama);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Personel Takip Programı";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.Button btnkapat;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}


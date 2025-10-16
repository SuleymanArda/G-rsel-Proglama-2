namespace gp2_16_10_örn3
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
            this.components = new System.ComponentModel.Container();
            this.pnlOyunAlani = new System.Windows.Forms.Panel();
            this.listBoxGecmis = new System.Windows.Forms.ListBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlOyunAlani
            // 
            this.pnlOyunAlani.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlOyunAlani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOyunAlani.Location = new System.Drawing.Point(105, 2);
            this.pnlOyunAlani.Name = "pnlOyunAlani";
            this.pnlOyunAlani.Size = new System.Drawing.Size(520, 612);
            this.pnlOyunAlani.TabIndex = 0;
            // 
            // listBoxGecmis
            // 
            this.listBoxGecmis.FormattingEnabled = true;
            this.listBoxGecmis.ItemHeight = 16;
            this.listBoxGecmis.Location = new System.Drawing.Point(631, 5);
            this.listBoxGecmis.Name = "listBoxGecmis";
            this.listBoxGecmis.Size = new System.Drawing.Size(227, 484);
            this.listBoxGecmis.TabIndex = 1;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(719, 518);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(58, 16);
            this.lblSure.TabIndex = 2;
            this.lblSure.Text = "Süre : 60";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(12, 265);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 64);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Oyuna Başla !";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 618);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.listBoxGecmis);
            this.Controls.Add(this.pnlOyunAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOyunAlani;
        private System.Windows.Forms.ListBox listBoxGecmis;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer gameTimer;
    }
}


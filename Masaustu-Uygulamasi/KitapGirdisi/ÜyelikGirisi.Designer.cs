
namespace KitapGirdisi
{
    partial class UyelikGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyelikGirisi));
            this.btn_grs = new System.Windows.Forms.Button();
            this.text_sfr = new System.Windows.Forms.TextBox();
            this.text_kllncı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_grs
            // 
            this.btn_grs.BackColor = System.Drawing.Color.White;
            this.btn_grs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grs.ImageIndex = 0;
            this.btn_grs.ImageList = this.ımageList1;
            this.btn_grs.Location = new System.Drawing.Point(71, 271);
            this.btn_grs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_grs.Name = "btn_grs";
            this.btn_grs.Size = new System.Drawing.Size(134, 39);
            this.btn_grs.TabIndex = 12;
            this.btn_grs.Text = "Giriş Yap";
            this.btn_grs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_grs.UseVisualStyleBackColor = false;
            this.btn_grs.Click += new System.EventHandler(this.btn_grs_Click);
            // 
            // text_sfr
            // 
            this.text_sfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_sfr.Location = new System.Drawing.Point(50, 214);
            this.text_sfr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_sfr.Name = "text_sfr";
            this.text_sfr.PasswordChar = '*';
            this.text_sfr.Size = new System.Drawing.Size(178, 24);
            this.text_sfr.TabIndex = 11;
            // 
            // text_kllncı
            // 
            this.text_kllncı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_kllncı.Location = new System.Drawing.Point(50, 162);
            this.text_kllncı.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_kllncı.Name = "text_kllncı";
            this.text_kllncı.Size = new System.Drawing.Size(178, 24);
            this.text_kllncı.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KitapGirdisi.Properties.Resources.yoneticiler;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login.png");
            // 
            // UyelikGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(275, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_grs);
            this.Controls.Add(this.text_sfr);
            this.Controls.Add(this.text_kllncı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UyelikGirisi";
            this.Text = "Giriş Yap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UyelikGirisi_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_grs;
        private System.Windows.Forms.TextBox text_sfr;
        private System.Windows.Forms.TextBox text_kllncı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}


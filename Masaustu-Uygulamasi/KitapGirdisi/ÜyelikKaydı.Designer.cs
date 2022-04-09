
namespace KitapGirdisi
{
    partial class ÜyelikKaydı
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜyelikKaydı));
            this.Grup = new System.Windows.Forms.GroupBox();
            this.textsfrtkrr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_sfr = new System.Windows.Forms.TextBox();
            this.text_kllncı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kydt = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Grup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grup
            // 
            this.Grup.Controls.Add(this.textsfrtkrr);
            this.Grup.Controls.Add(this.label4);
            this.Grup.Controls.Add(this.pictureBox1);
            this.Grup.Controls.Add(this.btn_kydt);
            this.Grup.Controls.Add(this.text_sfr);
            this.Grup.Controls.Add(this.text_kllncı);
            this.Grup.Controls.Add(this.label3);
            this.Grup.Controls.Add(this.label2);
            this.Grup.Controls.Add(this.label1);
            this.Grup.Location = new System.Drawing.Point(1, -2);
            this.Grup.Name = "Grup";
            this.Grup.Size = new System.Drawing.Size(305, 411);
            this.Grup.TabIndex = 23;
            this.Grup.TabStop = false;
            this.Grup.Enter += new System.EventHandler(this.Grup_Enter);
            // 
            // textsfrtkrr
            // 
            this.textsfrtkrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsfrtkrr.Location = new System.Drawing.Point(121, 265);
            this.textsfrtkrr.Name = "textsfrtkrr";
            this.textsfrtkrr.PasswordChar = '*';
            this.textsfrtkrr.Size = new System.Drawing.Size(153, 24);
            this.textsfrtkrr.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Şifre Tekrar :";
            // 
            // text_sfr
            // 
            this.text_sfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_sfr.Location = new System.Drawing.Point(121, 216);
            this.text_sfr.Name = "text_sfr";
            this.text_sfr.PasswordChar = '*';
            this.text_sfr.Size = new System.Drawing.Size(153, 24);
            this.text_sfr.TabIndex = 27;
            // 
            // text_kllncı
            // 
            this.text_kllncı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_kllncı.Location = new System.Drawing.Point(121, 167);
            this.text_kllncı.Name = "text_kllncı";
            this.text_kllncı.Size = new System.Drawing.Size(153, 24);
            this.text_kllncı.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Üyelik Kaydı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KitapGirdisi.Properties.Resources.yoneticiler;
            this.pictureBox1.Location = new System.Drawing.Point(73, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kydt
            // 
            this.btn_kydt.BackColor = System.Drawing.Color.White;
            this.btn_kydt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_kydt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kydt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kydt.ImageIndex = 0;
            this.btn_kydt.ImageList = this.ımageList1;
            this.btn_kydt.Location = new System.Drawing.Point(88, 316);
            this.btn_kydt.Name = "btn_kydt";
            this.btn_kydt.Size = new System.Drawing.Size(126, 44);
            this.btn_kydt.TabIndex = 28;
            this.btn_kydt.Text = "Kaydet";
            this.btn_kydt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kydt.UseVisualStyleBackColor = false;
            this.btn_kydt.Click += new System.EventHandler(this.btn_kydt_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "signup.png");
            // 
            // ÜyelikKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 409);
            this.Controls.Add(this.Grup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜyelikKaydı";
            this.Text = "Kaydol";
            this.Load += new System.EventHandler(this.ÜyelikKaydı_Load);
            this.Grup.ResumeLayout(false);
            this.Grup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grup;
        private System.Windows.Forms.TextBox textsfrtkrr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_kydt;
        private System.Windows.Forms.TextBox text_sfr;
        private System.Windows.Forms.TextBox text_kllncı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}
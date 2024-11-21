namespace KullaniciKayitDosyaIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.tb_bolum = new System.Windows.Forms.TextBox();
            this.tb_ogrencino = new System.Windows.Forms.TextBox();
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.lb_kayitliOgrenciler = new System.Windows.Forms.ListBox();
            this.btn_bilgiGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gb_ogrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_bolum = new System.Windows.Forms.Label();
            this.lbl_ogrencino = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_ogrenciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_telefon);
            this.groupBox1.Controls.Add(this.tb_ogrencino);
            this.groupBox1.Controls.Add(this.tb_bolum);
            this.groupBox1.Controls.Add(this.tb_soyisim);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.btn_kayit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kayıt Formu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon :";
            // 
            // btn_kayit
            // 
            this.btn_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.Location = new System.Drawing.Point(29, 185);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(191, 27);
            this.btn_kayit.TabIndex = 5;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(82, 38);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(138, 20);
            this.tb_isim.TabIndex = 6;
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(82, 64);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(138, 20);
            this.tb_soyisim.TabIndex = 7;
            // 
            // tb_bolum
            // 
            this.tb_bolum.Location = new System.Drawing.Point(82, 90);
            this.tb_bolum.Name = "tb_bolum";
            this.tb_bolum.Size = new System.Drawing.Size(138, 20);
            this.tb_bolum.TabIndex = 8;
            // 
            // tb_ogrencino
            // 
            this.tb_ogrencino.Location = new System.Drawing.Point(82, 117);
            this.tb_ogrencino.Name = "tb_ogrencino";
            this.tb_ogrencino.Size = new System.Drawing.Size(138, 20);
            this.tb_ogrencino.TabIndex = 9;
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(82, 143);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(138, 20);
            this.mtb_telefon.TabIndex = 10;
            // 
            // lb_kayitliOgrenciler
            // 
            this.lb_kayitliOgrenciler.FormattingEnabled = true;
            this.lb_kayitliOgrenciler.Location = new System.Drawing.Point(26, 38);
            this.lb_kayitliOgrenciler.Name = "lb_kayitliOgrenciler";
            this.lb_kayitliOgrenciler.Size = new System.Drawing.Size(169, 303);
            this.lb_kayitliOgrenciler.TabIndex = 1;
            // 
            // btn_bilgiGetir
            // 
            this.btn_bilgiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bilgiGetir.Location = new System.Drawing.Point(26, 354);
            this.btn_bilgiGetir.Name = "btn_bilgiGetir";
            this.btn_bilgiGetir.Size = new System.Drawing.Size(169, 28);
            this.btn_bilgiGetir.TabIndex = 2;
            this.btn_bilgiGetir.Text = "Bilgi Getir";
            this.btn_bilgiGetir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.lb_kayitliOgrenciler);
            this.groupBox2.Controls.Add(this.btn_bilgiGetir);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 432);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Öğrenciler";
            // 
            // gb_ogrenciBilgileri
            // 
            this.gb_ogrenciBilgileri.Controls.Add(this.lbl_telefon);
            this.gb_ogrenciBilgileri.Controls.Add(this.lbl_bolum);
            this.gb_ogrenciBilgileri.Controls.Add(this.lbl_ogrencino);
            this.gb_ogrenciBilgileri.Controls.Add(this.lbl_isim);
            this.gb_ogrenciBilgileri.Controls.Add(this.lbl_soyisim);
            this.gb_ogrenciBilgileri.Controls.Add(this.label7);
            this.gb_ogrenciBilgileri.Controls.Add(this.label8);
            this.gb_ogrenciBilgileri.Controls.Add(this.label9);
            this.gb_ogrenciBilgileri.Controls.Add(this.label11);
            this.gb_ogrenciBilgileri.Controls.Add(this.label10);
            this.gb_ogrenciBilgileri.Location = new System.Drawing.Point(12, 263);
            this.gb_ogrenciBilgileri.Name = "gb_ogrenciBilgileri";
            this.gb_ogrenciBilgileri.Size = new System.Drawing.Size(243, 181);
            this.gb_ogrenciBilgileri.TabIndex = 4;
            this.gb_ogrenciBilgileri.TabStop = false;
            this.gb_ogrenciBilgileri.Text = "Öğrenci Bilgileri";
            this.gb_ogrenciBilgileri.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefon :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bölüm :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Öğrenci No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Soyisim :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "İsim :";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(99, 144);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefon.TabIndex = 20;
            this.lbl_telefon.Text = "Telefon :";
            // 
            // lbl_bolum
            // 
            this.lbl_bolum.AutoSize = true;
            this.lbl_bolum.Location = new System.Drawing.Point(99, 91);
            this.lbl_bolum.Name = "lbl_bolum";
            this.lbl_bolum.Size = new System.Drawing.Size(42, 13);
            this.lbl_bolum.TabIndex = 19;
            this.lbl_bolum.Text = "Bölüm :";
            // 
            // lbl_ogrencino
            // 
            this.lbl_ogrencino.AutoSize = true;
            this.lbl_ogrencino.Location = new System.Drawing.Point(99, 118);
            this.lbl_ogrencino.Name = "lbl_ogrencino";
            this.lbl_ogrencino.Size = new System.Drawing.Size(67, 13);
            this.lbl_ogrencino.TabIndex = 18;
            this.lbl_ogrencino.Text = "Öğrenci No :";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(99, 39);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(31, 13);
            this.lbl_isim.TabIndex = 16;
            this.lbl_isim.Text = "İsim :";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(99, 65);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(48, 13);
            this.lbl_soyisim.TabIndex = 17;
            this.lbl_soyisim.Text = "Soyisim :";
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.Brown;
            this.btn_sil.Location = new System.Drawing.Point(26, 388);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(169, 28);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 506);
            this.Controls.Add(this.gb_ogrenciBilgileri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gb_ogrenciBilgileri.ResumeLayout(false);
            this.gb_ogrenciBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.TextBox tb_ogrencino;
        private System.Windows.Forms.TextBox tb_bolum;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_kayitliOgrenciler;
        private System.Windows.Forms.Button btn_bilgiGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_ogrenciBilgileri;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_bolum;
        private System.Windows.Forms.Label lbl_ogrencino;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_sil;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciKayitDosyaIslemleri
{
    public partial class Form1 : Form
    {
        string directoryPath = @"C:\Users\doga\Desktop\Ogrenciler";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_kayitliOgrenciler.Items.Clear();
            ListBoxaVeriCek();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (DoluMu())
            {
                //Öğrenci nesnesi oluştur.
                Ogrenci o = new Ogrenci();
                o.Isim = tb_isim.Text;
                o.Soyisim = tb_soyisim.Text;
                o.Bolum = tb_bolum.Text;
                o.Telefon = mtb_telefon.Text;
                o.OgrenciNo = tb_ogrencino.Text;

                //Klasör oluşturma işlemleri
                string directoryPath = @"C:\Users\doga\Desktop\Ogrenciler";
                DirectoryInfo di = new DirectoryInfo(directoryPath);
                if (!di.Exists)
                {
                    di.Create();
                }

                //Dosya oluşturma ve yazma işlemleri 
                string fileName = o.OgrenciNo;
                string filePath = directoryPath + "/" + fileName + ".txt";
                StreamWriter writer = new StreamWriter(filePath);
                writer.WriteLine(o.Isim);
                writer.WriteLine(o.Soyisim);
                writer.WriteLine(o.Bolum);
                writer.WriteLine(o.OgrenciNo);
                writer.WriteLine(o.Telefon);
                writer.Close();
                lb_kayitliOgrenciler.Items.Clear();
                ListBoxaVeriCek(); //Yeni veri eklendikten sonra listeyi sıfırla bir daha oluştur.
                MessageBox.Show("Kayıt işlemi başarılı");

                //Kayıt işleminden sonra textboxları temizle.
                tb_isim.Text = "";
                tb_soyisim.Text = "";
                tb_bolum.Text = "";
                tb_ogrencino.Text = "";
                mtb_telefon.Text = "";
            }
            else
            {
                MessageBox.Show("Bilgi alanları boş bırakılamaz.");
            }
        }

        private void btn_bilgiGetir_Click(object sender, EventArgs e)
        {
            string[] ogrenciDosyalari = Directory.GetFiles(directoryPath); //Klasördeki dosyaları al.

            foreach (string dosyaAdi in ogrenciDosyalari)
            {
                string[] satirlar = File.ReadAllLines(dosyaAdi);
                string ogrAdSoyad = satirlar[0] + " " + satirlar[1];
                string secili = lb_kayitliOgrenciler.SelectedItem.ToString();
                if (secili == ogrAdSoyad)
                {
                    gb_ogrenciBilgileri.Visible = true;
                    lbl_isim.Text = satirlar[0];
                    lbl_soyisim.Text = satirlar[1];
                    lbl_bolum.Text = satirlar[2];
                    lbl_ogrencino.Text = satirlar[3];
                    lbl_telefon.Text = satirlar[4];
                }
            }
        }

        private bool DoluMu()
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                if (!string.IsNullOrEmpty(tb_soyisim.Text))
                {
                    if (!string.IsNullOrEmpty(tb_bolum.Text))
                    {
                        if (!string.IsNullOrEmpty(tb_ogrencino.Text))
                        {
                            if (!string.IsNullOrEmpty(mtb_telefon.Text))
                            {
                                return true;
                            }
                            else { return false; }
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            else { return false; }
        }

        private void ListBoxaVeriCek()
        {
            string[] ogrenciDosyalari = Directory.GetFiles(directoryPath); //Klasördeki dosyaları al.

            foreach (string dosyaAdi in ogrenciDosyalari)
            {
                StreamReader sr = new StreamReader(dosyaAdi);
                string ogrenciAdi = sr.ReadLine();
                string ogrenciSoyadi = sr.ReadLine();
                string ogrAdSoyad = ogrenciAdi + " " + ogrenciSoyadi;
                lb_kayitliOgrenciler.Items.Add(ogrAdSoyad);
            }
        }
    }
}

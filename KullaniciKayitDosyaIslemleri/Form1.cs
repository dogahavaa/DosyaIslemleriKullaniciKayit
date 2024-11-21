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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (DoluMu())
            {
                Ogrenci o = new Ogrenci();
                o.Isim = tb_isim.Text;
                o.Soyisim = tb_soyisim.Text;
                o.Bolum = tb_bolum.Text;
                o.Telefon = mtb_telefon.Text;
                o.OgrenciNo = tb_ogrencino.Text;

                string directoryPath = @"C:\Users\doga\Desktop\Ogrenciler";
                DirectoryInfo di = new DirectoryInfo(directoryPath);
                if (!di.Exists)
                {
                    di.Create();
                }

                string fileName = o.OgrenciNo;
                string filePath = directoryPath + "/" + fileName + ".txt";
                StreamWriter writer = new StreamWriter(filePath);
                writer.WriteLine(o.Isim);
                writer.WriteLine(o.Soyisim);
                writer.WriteLine(o.Bolum);
                writer.WriteLine(o.OgrenciNo);
                writer.WriteLine(o.Telefon);
                writer.Close();
                MessageBox.Show("Kayıt işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Bilgi alanları boş bırakılamaz.");
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


    }
}

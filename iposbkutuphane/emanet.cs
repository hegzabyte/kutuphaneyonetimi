using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneSistemi
{
    public partial class emanet : Form
    {
        private const string BAGLANTI = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Kutuphane.mdb;Persist Security Info=False;";
        private const int SATIR_YUKSEKLIGI = 110;

        private const string SORGU_EMANETLER = @"
            SELECT 
                E.EmanetID, 
                K.KitapID, 
                (O.Ad + ' ' + O.Soyad) AS [Öğrenci], 
                K.KitapAdi AS [Kitap], 
                E.VerilisTarihi, 
                E.TeslimTarihi
            FROM (Emanetler E 
            INNER JOIN Ogrenciler O ON E.OgrenciID = O.OgrenciID)
            INNER JOIN Kitaplar K ON E.KitapID = K.KitapID 
            WHERE E.Durum = 0";

        private const string SORGU_OGRENCILER = "SELECT OgrenciID, (Ad + ' ' + Soyad) AS TamAd FROM Ogrenciler";
        private const string SORGU_KITAPLAR = "SELECT KitapID, KitapAdi FROM Kitaplar WHERE StokSayisi > 0";
        private const string SORGU_EMANET_EKLE = "INSERT INTO Emanetler (OgrenciID, KitapID, VerilisTarihi, TeslimTarihi, Durum) VALUES (@p1, @p2, @p3, @p4, 0)";
        private const string SORGU_IADE_GUNCELLE = "UPDATE Emanetler SET Durum=1, IadeTarihi=@tarih WHERE EmanetID=";
        private const string SORGU_STOK_AZALT = "UPDATE Kitaplar SET StokSayisi = StokSayisi - 1 WHERE KitapID=";
        private const string SORGU_STOK_ARTIR = "UPDATE Kitaplar SET StokSayisi = StokSayisi + 1 WHERE KitapID=";

        private readonly OleDbConnection baglanti;
        private bool iadeModu = false;
        private int secilenEmanetId = 0;
        private int secilenKitapId = 0;

        public emanet()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(BAGLANTI);
        }

        private void EmanetForm_Load(object sender, EventArgs e)
        {
            TabloAyarla();
            VerileriYukle();
            ModuAyarla(false);
            ComboBoxlariTemizle();
        }

        private void TabloAyarla()
        {
            Tablo();
        }

        private void Tablo()
        {
            gridEmanetler.ColumnHeadersVisible = false;
            gridEmanetler.RowHeadersVisible = false;
            gridEmanetler.RowTemplate.Height = SATIR_YUKSEKLIGI;
            gridEmanetler.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridEmanetler.AllowUserToAddRows = false;
            gridEmanetler.AllowUserToResizeRows = false;
            gridEmanetler.AllowUserToResizeColumns = false;
            gridEmanetler.AllowUserToOrderColumns = false;
            gridEmanetler.ReadOnly = true;
            gridEmanetler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEmanetler.MultiSelect = false;
            gridEmanetler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridEmanetler.EnableHeadersVisualStyles = false;
        }

        private void VerileriYukle()
        {
            OgrencileriGetir();
            KitaplariGetir();
            ListeyiYenile();
        }

        private void ComboBoxlariTemizle()
        {
            comboOgrenci.SelectedIndex = -1;
            comboKitap.SelectedIndex = -1;
        }

        private void ListeyiYenile()
        {
            try
            {
                DataTable veriTablosu = EmanetGetir();
                VeriBagla(veriTablosu);
                TabloSutunlariniAyarla();
                SatirYukseklikleriniAyarla();
            }
            catch (Exception ex)
            {
                HataMesajiGoster("Listeleme Hatası: " + ex.Message);
            }
        }

        private DataTable EmanetGetir()
        {
            DataTable veriTablosu = new DataTable();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(SORGU_EMANETLER, baglanti))
            {
                adaptor.Fill(veriTablosu);
            }
            return veriTablosu;
        }

        private void VeriBagla(DataTable veriTablosu)
        {
            gridEmanetler.DataSource = veriTablosu;
            gridEmanetler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TabloSutunlariniAyarla()
        {
            SutunGizle("EmanetID");
            SutunGizle("KitapID");
        }

        private void SutunGizle(string sutunAdi)
        {
            if (gridEmanetler.Columns.Contains(sutunAdi))
            {
                gridEmanetler.Columns[sutunAdi].Visible = false;
            }
        }

        private void SatirYukseklikleriniAyarla()
        {
            foreach (DataGridViewRow satir in gridEmanetler.Rows)
            {
                satir.Height = SATIR_YUKSEKLIGI;
            }
        }

        private void OgrencileriGetir()
        {
            DataTable veriTablosu = new DataTable();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(SORGU_OGRENCILER, baglanti))
            {
                adaptor.Fill(veriTablosu);
            }

            comboOgrenci.ValueMember = "OgrenciID";
            comboOgrenci.DisplayMember = "TamAd";
            comboOgrenci.DataSource = veriTablosu;
        }

        private void KitaplariGetir()
        {
            DataTable veriTablosu = new DataTable();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(SORGU_KITAPLAR, baglanti))
            {
                adaptor.Fill(veriTablosu);
            }

            comboKitap.ValueMember = "KitapID";
            comboKitap.DisplayMember = "KitapAdi";
            comboKitap.DataSource = veriTablosu;
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                if (iadeModu)
                {
                    IadeIsleminiGerceklestir();
                }
                else
                {
                    EmanetIsleminiGerceklestir();
                }

                baglanti.Close();
                Temizle();
            }
            catch (Exception ex)
            {
                BaglantiKapat();
                HataMesajiGoster(ex.Message);
            }
        }

        private void EmanetIsleminiGerceklestir()
        {
            if (!SecimYapildiMi())
            {
                HataMesajiGoster("Lütfen öğrenci ve kitap seçiniz");
                baglanti.Close();
                return;
            }

            EmanetOlustur();
            KitapStogunuAzalt();
            BasariMesajiGoster("Verildi");
        }

        private bool SecimYapildiMi()
        {
            return comboOgrenci.SelectedValue != null && comboKitap.SelectedValue != null;
        }

        private void EmanetOlustur()
        {
            using (OleDbCommand komut = new OleDbCommand(SORGU_EMANET_EKLE, baglanti))
            {
                komut.Parameters.AddWithValue("@p1", comboOgrenci.SelectedValue);
                komut.Parameters.AddWithValue("@p2", comboKitap.SelectedValue);
                komut.Parameters.AddWithValue("@p3", dateVerilis.Value.ToShortDateString());
                komut.Parameters.AddWithValue("@p4", dateTeslim.Value.ToShortDateString());
                komut.ExecuteNonQuery();
            }
        }

        private void KitapStogunuAzalt()
        {
            string sorgu = SORGU_STOK_AZALT + comboKitap.SelectedValue;
            using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
            {
                komut.ExecuteNonQuery();
            }
        }

        private void IadeIsleminiGerceklestir()
        {
            IadeKaydiGuncelle();
            KitapStogunuArtir();
            BasariMesajiGoster("İade Alındı");
        }

        private void IadeKaydiGuncelle()
        {
            string sorgu = SORGU_IADE_GUNCELLE + secilenEmanetId;
            using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());
                komut.ExecuteNonQuery();
            }
        }

        private void KitapStogunuArtir()
        {
            string sorgu = SORGU_STOK_ARTIR + secilenKitapId;
            using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
            {
                komut.ExecuteNonQuery();
            }
        }

        private void gridEmanetler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GecerliSatirSecildiMi(e))
            {
                SeciliSatirBilgileriniAl(e.RowIndex);
            }
        }

        private bool GecerliSatirSecildiMi(DataGridViewCellEventArgs e)
        {
            return e.RowIndex != -1 && e.RowIndex < gridEmanetler.Rows.Count;
        }

        private void SeciliSatirBilgileriniAl(int satirIndeksi)
        {
            var emanetIdDegeri = gridEmanetler.Rows[satirIndeksi].Cells["EmanetID"].Value;
            var kitapIdDegeri = gridEmanetler.Rows[satirIndeksi].Cells["KitapID"].Value;

            if (DegerlerGecerliMi(emanetIdDegeri, kitapIdDegeri))
            {
                secilenEmanetId = Convert.ToInt32(emanetIdDegeri);
                secilenKitapId = Convert.ToInt32(kitapIdDegeri);
                ModuAyarla(true);
            }
        }

        private bool DegerlerGecerliMi(object emanetId, object kitapId)
        {
            return emanetId != null && emanetId != DBNull.Value &&
                   kitapId != null && kitapId != DBNull.Value;
        }

        private void ModuAyarla(bool iadeMi)
        {
            iadeModu = iadeMi;

            if (iadeMi)
            {
                Iade();
            }
            else
            {
                Emanet();
            }
        }

        private void Emanet()
        {
            btnIslemYap.Text = "EMANET VER";
            comboOgrenci.Enabled = true;
            btnIslemYap.FillColor = Color.FromArgb(94, 148, 255);
        }

        private void Iade()
        {
            btnIslemYap.Text = "İADE AL";
            comboOgrenci.Enabled = false;
            btnIslemYap.FillColor = Color.FromArgb(39, 174, 96);
        }

        private void Temizle()
        {
            ComboBoxlariTemizle();
            secilenEmanetId = 0;
            secilenKitapId = 0;
            ModuAyarla(false);
            KitaplariGetir();
            ListeyiYenile();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridEmanetler_Paint(object sender, PaintEventArgs e)
        {
            if (gridEmanetler.Rows.Count == 0)
            {
                BosTabloMesajiGoster(e);
            }
        }

        private void BosTabloMesajiGoster(PaintEventArgs e)
        {
            string mesaj = "Henüz Emanet Kitap Yok";
            Font yazi = new Font("Segoe UI", 16, FontStyle.Bold);
            SizeF metinBoyutu = e.Graphics.MeasureString(mesaj, yazi);

            float x = (gridEmanetler.Width - metinBoyutu.Width) / 2;
            float y = (gridEmanetler.Height - metinBoyutu.Height) / 2;

            e.Graphics.DrawString(mesaj, yazi, Brushes.DodgerBlue, x, y);
        }

        private void BaglantiKapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void HataMesajiGoster(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void BasariMesajiGoster(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
    }
}
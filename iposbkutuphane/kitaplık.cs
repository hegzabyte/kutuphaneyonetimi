using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace iposbkutuphane
{
    public partial class kitaplık : Form
    {
        private const string BAGLANTI = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Kutuphane.mdb;Persist Security Info=False;";
        private const int SATIR_YUKSEKLIGI = 100;
        private const string SORGU_TUMUNU_GETIR = "SELECT * FROM Kitaplar ORDER BY KitapID DESC";
        private const string SORGU_BILGI_GETIR = "SELECT * FROM Kitaplar WHERE KitapID=@id";
        private const string SORGU_EKLE = "INSERT INTO Kitaplar (KitapAdi, YazarAdi, Yayinevi, SayfaSayisi, YayinTarihi, KapakResmi, StokSayisi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
        private const string SORGU_GUNCELLE = "UPDATE Kitaplar SET KitapAdi=@p1, YazarAdi=@p2, Yayinevi=@p3, SayfaSayisi=@p4, YayinTarihi=@p5, KapakResmi=@p6, StokSayisi=@p7 WHERE KitapID=";
        private const string SORGU_SIL = "DELETE FROM Kitaplar WHERE KitapID=";
        private const string GOOGLE_API_URL = "https://www.googleapis.com/books/v1/volumes?q=";

        private const int KAPAK_RESMI_GENISLIK = 70;
        private const int SAYFA_SAYISI_GENISLIK = 60;
        private const int STOK_SAYISI_GENISLIK = 60;
        private const int YAYIN_TARIHI_GENISLIK = 110;

        private readonly OleDbConnection baglanti;
        private int guncellenecekKitapId = 0;
        private byte[] kapakResmiBytes = null;

        public kitaplık()
        {
            InitializeComponent();
            baglanti = new OleDbConnection(BAGLANTI);
        }

        private void kitaplık_Load(object sender, EventArgs e)
        {
            Listele();
            pnlKayit.Visible = false;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                Listele();
            }
        }

        private void Listele()
        {
            try
            {
                BaglantiKapat();
                DataTable veriTablosu = KitaplariGetir();
                VeriyiBagla(veriTablosu);
                TabloTasariminiYap();
            }
            catch (Exception ex)
            {
                Hatamesaji("Hata: " + ex.Message);
            }
        }

        private void BaglantiKapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private DataTable KitaplariGetir()
        {
            baglanti.Open();
            DataTable veriTablosu = new DataTable();
            using (OleDbDataAdapter adaptor = new OleDbDataAdapter(SORGU_TUMUNU_GETIR, baglanti))
            {
                adaptor.Fill(veriTablosu);
            }
            baglanti.Close();
            return veriTablosu;
        }

        private void VeriyiBagla(DataTable veriTablosu)
        {
            dgvListe.DataSource = veriTablosu;
        }

        private void TabloTasariminiYap()
        {
            if (dgvListe.Columns.Count == 0)
            {
                return;
            }

            TabloAyarla();
            SutunlariAyarla();
            dgvListe.ClearSelection();
        }

        private void TabloAyarla()
        {
            dgvListe.AllowUserToAddRows = false;
            dgvListe.ReadOnly = true;
            dgvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListe.MultiSelect = false;
            dgvListe.AllowUserToResizeColumns = false;
            dgvListe.AllowUserToResizeRows = false;
            dgvListe.AllowUserToOrderColumns = false;
            dgvListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListe.RowHeadersVisible = false;
            dgvListe.ColumnHeadersVisible = false;
            dgvListe.RowTemplate.Height = SATIR_YUKSEKLIGI;
            dgvListe.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            SatirYukseklikleriniAyarla();
        }

        private void SatirYukseklikleriniAyarla()
        {
            foreach (DataGridViewRow satir in dgvListe.Rows)
            {
                satir.Height = SATIR_YUKSEKLIGI;
            }
        }


        private void SutunlariAyarla()
        {
            KapakResmiSutunuAyarla();
            SayfaSayisiSutunuAyarla();
            StokSayisiSutunuAyarla();
            YayinTarihiSutunuAyarla();
            KitapAdiSutunuAyarla();
            YazarAdiSutunuAyarla();
            YayineviSutunuAyarla();
            IdSutunuGizle();
        }

        private void KapakResmiSutunuAyarla()
        {
            if (!dgvListe.Columns.Contains("KapakResmi"))
            {
                return;
            }

            dgvListe.Columns["KapakResmi"].DisplayIndex = 0;
            dgvListe.Columns["KapakResmi"].Width = KAPAK_RESMI_GENISLIK;
            dgvListe.Columns["KapakResmi"].MinimumWidth = KAPAK_RESMI_GENISLIK;
            dgvListe.Columns["KapakResmi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            if (dgvListe.Columns["KapakResmi"] is DataGridViewImageColumn resimSutunu)
            {
                resimSutunu.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void SayfaSayisiSutunuAyarla()
        {
            if (!dgvListe.Columns.Contains("SayfaSayisi"))
            {
                return;
            }

            dgvListe.Columns["SayfaSayisi"].DisplayIndex = 4;
            dgvListe.Columns["SayfaSayisi"].Width = SAYFA_SAYISI_GENISLIK;
            dgvListe.Columns["SayfaSayisi"].MinimumWidth = SAYFA_SAYISI_GENISLIK;
            dgvListe.Columns["SayfaSayisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvListe.Columns["SayfaSayisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void StokSayisiSutunuAyarla()
        {
            if (!dgvListe.Columns.Contains("StokSayisi"))
            {
                return;
            }

            dgvListe.Columns["StokSayisi"].DisplayIndex = 5;
            dgvListe.Columns["StokSayisi"].Width = STOK_SAYISI_GENISLIK;
            dgvListe.Columns["StokSayisi"].MinimumWidth = STOK_SAYISI_GENISLIK;
            dgvListe.Columns["StokSayisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvListe.Columns["StokSayisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void YayinTarihiSutunuAyarla()
        {
            if (!dgvListe.Columns.Contains("YayinTarihi"))
            {
                return;
            }

            dgvListe.Columns["YayinTarihi"].DisplayIndex = 6;
            dgvListe.Columns["YayinTarihi"].Width = YAYIN_TARIHI_GENISLIK;
            dgvListe.Columns["YayinTarihi"].MinimumWidth = YAYIN_TARIHI_GENISLIK;
            dgvListe.Columns["YayinTarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvListe.Columns["YayinTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvListe.Columns["YayinTarihi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void KitapAdiSutunuAyarla()
        {
            if (!dgvListe.Columns.Contains("KitapAdi"))
            {
                return;
            }

            dgvListe.Columns["KitapAdi"].DisplayIndex = 1;
            dgvListe.Columns["KitapAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListe.Columns["KitapAdi"].FillWeight = 40;
            dgvListe.Columns["KitapAdi"].MinimumWidth = 100;
        }

        private void YazarAdiSutunuAyarla()
        {
            if (!dgvListe.Columns.Contains("YazarAdi"))
            {
                return;
            }

            dgvListe.Columns["YazarAdi"].DisplayIndex = 2;
            dgvListe.Columns["YazarAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListe.Columns["YazarAdi"].FillWeight = 30;
            dgvListe.Columns["YazarAdi"].MinimumWidth = 80;
        }

        private void YayineviSutunuAyarla()
        {
            if (!dgvListe.Columns.Contains("Yayinevi"))
            {
                return;
            }

            dgvListe.Columns["Yayinevi"].DisplayIndex = 3;
            dgvListe.Columns["Yayinevi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListe.Columns["Yayinevi"].FillWeight = 30;
            dgvListe.Columns["Yayinevi"].MinimumWidth = 80;
        }

        private void IdSutunuGizle()
        {
            if (dgvListe.Columns.Contains("KitapID"))
            {
                dgvListe.Columns["KitapID"].Visible = false;
            }
        }

        private void Temizle()
        {
            AlanlariTemizle();
            ResmiTemizle();
        }

        private void AlanlariTemizle()
        {
            txtAd.Text = "";
            txtYazar.Text = "";
            txtYayinevi.Text = "";
            numSayfa.Value = 0;
            numStok.Value = 1;
            dtpTarih.Value = DateTime.Now;
        }



        private void ResmiTemizle()
        {
            pbResim.Image = null;
            pbResim.Visible = false;
            kapakResmiBytes = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (pnlKayit.Visible)
            {
                KayitPanelGizle();
            }
            else
            {
                YeniKayit();
            }
        }

        private void KayitPanelGizle()
        {
            guna2Transition1.HideSync(pnlKayit);
        }

        private void YeniKayit()
        {
            Temizle();
            guncellenecekKitapId = 0;
            btnKaydet.Text = "KAYDET";
            guna2Transition1.ShowSync(pnlKayit);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!SatirSecilmisMi())
            {
                Hatamesaji("Seçim Yapınız");
                return;
            }

            Guncelle();
        }

        private bool SatirSecilmisMi()
        {
            return dgvListe.SelectedRows.Count > 0;
        }

        private void Guncelle()
        {
            guncellenecekKitapId = SeciliKitap();
            btnKaydet.Text = "GÜNCELLE";
            KitapBilgileriniPaneleGetir();

            if (!pnlKayit.Visible)
            {
                guna2Transition1.ShowSync(pnlKayit);
            }
        }

        private int SeciliKitap()
        {
            return Convert.ToInt32(dgvListe.CurrentRow.Cells["KitapID"].Value);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            KayitPanelGizle();
        }

        private void KitapBilgileriniPaneleGetir()
        {
            try
            {
                AcikDegilseBaglan();
                KitapVerileri();
            }
            catch
            {
                baglanti.Close();
            }
        }

        private void AcikDegilseBaglan()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        private void KitapVerileri()
        {
            using (OleDbCommand komut = BilgiGetir())
            using (OleDbDataReader okuyucu = komut.ExecuteReader())
            {
                if (okuyucu.Read())
                {
                    FormAlanlari(okuyucu);
                }
            }
            baglanti.Close();
        }

        private OleDbCommand BilgiGetir()
        {
            OleDbCommand komut = new OleDbCommand(SORGU_BILGI_GETIR, baglanti);
            komut.Parameters.AddWithValue("@id", guncellenecekKitapId);
            return komut;
        }

        private void FormAlanlari(OleDbDataReader okuyucu)
        {
            txtAd.Text = okuyucu["KitapAdi"].ToString();
            txtYazar.Text = okuyucu["YazarAdi"].ToString();
            txtYayinevi.Text = okuyucu["Yayinevi"].ToString();
            numSayfa.Value = Convert.ToInt32(okuyucu["SayfaSayisi"]);
            dtpTarih.Value = Convert.ToDateTime(okuyucu["YayinTarihi"]);
            numStok.Value = Convert.ToInt32(okuyucu["StokSayisi"]);

            KapakResmiYukle(okuyucu);
        }

        private void KapakResmiYukle(OleDbDataReader okuyucu)
        {
            if (okuyucu["KapakResmi"] != DBNull.Value)
            {
                kapakResmiBytes = (byte[])okuyucu["KapakResmi"];
                ResimArray(kapakResmiBytes);
            }
            else
            {
                ResmiTemizle();
            }
        }

        private void ResimArray(byte[] resimVerisi)
        {
            using (MemoryStream bellekAkisi = new MemoryStream(resimVerisi))
            {
                pbResim.Image = Image.FromStream(bellekAkisi);
            }
            pbResim.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (KitapAdiBos())
            {
                return;
            }

            try
            {
                KitapKaydetVeyaGuncelle();
                IslemBasarili();
                Yenile();
            }
            catch (Exception ex)
            {
                VeriTabani(ex);
            }
        }

        private bool KitapAdiBos()
        {
            return string.IsNullOrWhiteSpace(txtAd.Text);
        }

        private void KitapKaydetVeyaGuncelle()
        {
            baglanti.Open();
            using (OleDbCommand komut = KayitOlustur())
            {
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }

        private OleDbCommand KayitOlustur()
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;

            if (guncellenecekKitapId == 0)
            {
                komut.CommandText = SORGU_EKLE;
            }
            else
            {
                komut.CommandText = SORGU_GUNCELLE + guncellenecekKitapId;
            }

            Parametreler(komut);
            return komut;
        }

        private void Parametreler(OleDbCommand komut)
        {
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@p4", numSayfa.Value.ToString());
            komut.Parameters.AddWithValue("@p5", dtpTarih.Value.ToShortDateString());
            ResimParametresi(komut);
            komut.Parameters.AddWithValue("@p7", numStok.Value.ToString());
        }

        private void ResimParametresi(OleDbCommand komut)
        {
            if (kapakResmiBytes != null)
            {
                komut.Parameters.Add("@p6", OleDbType.LongVarBinary).Value = kapakResmiBytes;
            }
            else
            {
                komut.Parameters.Add("@p6", OleDbType.LongVarBinary).Value = DBNull.Value;
            }
        }

        private void IslemBasarili()
        {
            MessageBox.Show("İşlem Tamam");
        }

        private void Yenile()
        {
            Listele();
            Temizle();
            KayitPanelGizle();
        }

        private void VeriTabani(Exception ex)
        {
            baglanti.Close();
            Hatamesaji(ex.Message);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!SatirSecilmisMi())
            {
                return;
            }

            if (SilmeOnayi())
            {
                SeciliKitabiSil();
            }
        }

        private bool SilmeOnayi()
        {
            return MessageBox.Show("Silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void SeciliKitabiSil()
        {
            try
            {
                int kitapId = SeciliKitap();
                baglanti.Open();
                KitapSil(kitapId);
                baglanti.Close();
                Listele();
            }
            catch
            {
                baglanti.Close();
            }
        }

        private void KitapSil(int kitapId)
        {
            string silmeSorgusu = SORGU_SIL + kitapId;
            using (OleDbCommand komut = new OleDbCommand(silmeSorgusu, baglanti))
            {
                komut.ExecuteNonQuery();
            }
        }

        private void btnWebdenBul_Click(object sender, EventArgs e)
        {
            if (KitapAdiBos())
            {
                Hatamesaji("Önce kitap adını yazmalısın");
                return;
            }

            try
            {
                GoogledanKitapBilgisiGetir(txtAd.Text);
            }
            catch (Exception ex)
            {
                WebHatasi(ex);
            }
        }

        private void GoogledanKitapBilgisiGetir(string arananKitap)
        {
            ResmiTemizle();
            GuvenlikProtokol();

            try
            {
                string jsonVerisi = GoogleApiCagir(arananKitap);
                Json(jsonVerisi);
            }
            catch (Exception ex)
            {
                Hatamesaji("Hata: " + ex.Message);
                pbResim.Visible = false;
            }
        }

        private void GuvenlikProtokol()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private string GoogleApiCagir(string arananKitap)
        {
            string apiUrl = GOOGLE_API_URL + arananKitap;

            using (WebClient webIstemci = new WebClient())
            {
                WebAyarları(webIstemci);
                return webIstemci.DownloadString(apiUrl);
            }
        }

        private void WebAyarları(WebClient webIstemci)
        {
            webIstemci.Encoding = Encoding.UTF8;
            webIstemci.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
        }

        private void Json(string jsonVerisi)
        {
            JObject jsonNesnesi = JObject.Parse(jsonVerisi);

            if (Kitapbulunamadi(jsonNesnesi))
            {
                Hatamesaji("Google'da bu isimle kitap bulunamadı");
                return;
            }

            KitapBilgileri(jsonNesnesi);
        }

        private bool Kitapbulunamadi(JObject jsonNesnesi)
        {
            return jsonNesnesi["items"] == null || !jsonNesnesi["items"].HasValues;
        }

        private void KitapBilgileri(JObject jsonNesnesi)
        {
            var kitapBilgisi = jsonNesnesi["items"][0]["volumeInfo"];

            Yazar(kitapBilgisi);
            Sayfa(kitapBilgisi);
            YayinEvi(kitapBilgisi);
            KapakResmi(kitapBilgisi);
        }

        private void Yazar(JToken kitapBilgisi)
        {
            if (kitapBilgisi["authors"] != null)
            {
                txtYazar.Text = kitapBilgisi["authors"][0].ToString();
            }
        }

        private void Sayfa(JToken kitapBilgisi)
        {
            if (kitapBilgisi["pageCount"] != null)
            {
                int sayfaSayisi = Convert.ToInt32(kitapBilgisi["pageCount"]);
                SayfaSayisi(sayfaSayisi);
                numSayfa.Value = sayfaSayisi;
            }
        }

        private void SayfaSayisi(int sayfaSayisi)
        {
            if (sayfaSayisi > numSayfa.Maximum)
            {
                numSayfa.Maximum = sayfaSayisi + 100;
            }
        }

        private void YayinEvi(JToken kitapBilgisi)
        {
            if (kitapBilgisi["publisher"] != null)
            {
                txtYayinevi.Text = kitapBilgisi["publisher"].ToString();
            }
        }

        private void KapakResmi(JToken kitapBilgisi)
        {
            if (ResimLink(kitapBilgisi))
            {
                string resimLinki = ResmiAl(kitapBilgisi);
                ResmiIndir(resimLinki);
                Basarimesaji("Kitap bilgileri ve kapak resmi bulundu!");
            }
            else
            {
                pbResim.Visible = false;
                Hatamesaji("Kitap bilgileri geldi ama kapağı yok");
            }
        }

        private bool ResimLink(JToken kitapBilgisi)
        {
            return kitapBilgisi["imageLinks"] != null &&
                   kitapBilgisi["imageLinks"]["thumbnail"] != null;
        }

        private string ResmiAl(JToken kitapBilgisi)
        {
            string resimLinki = kitapBilgisi["imageLinks"]["thumbnail"].ToString();
            return resimLinki.Replace("http://", "https://");
        }

        private void ResmiIndir(string resimLinki)
        {
            using (WebClient webIstemci = new WebClient())
            {
                WebAyarları(webIstemci);
                byte[] indirilenResim = webIstemci.DownloadData(resimLinki);
                ResmiGoster(indirilenResim);
            }
        }

        private void ResmiGoster(byte[] resimVerisi)
        {
            using (MemoryStream bellekAkisi = new MemoryStream(resimVerisi))
            {
                pbResim.Image = Image.FromStream(bellekAkisi);
                kapakResmiBytes = resimVerisi;
            }
            pbResim.Visible = true;
        }

        private void Hatamesaji(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void Basarimesaji(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void WebHatasi(Exception ex)
        {
            Hatamesaji("Resim bulunamadı veya internet yok \nHata: " + ex.Message);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
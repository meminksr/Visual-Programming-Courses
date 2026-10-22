namespace KisiselButceTakip
{
    public partial class Form1 : Form
    {

        decimal toplamGelir = 0;
        decimal toplamGider = 0;
        decimal zorunluGider = 0;
        decimal istegeBagliGider = 0;

        public Form1()

        {

            InitializeComponent();
            cmbKategori.Items.AddRange(new string[] { "Kira", "Market", "Fatura", "Ulaşım", "Eğitim", "Diğer" });
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtGelir.Text, out decimal gelir) && gelir > 0)
            {
                toplamGelir = gelir;
                lblToplamGelir.Text = "Aylık Gelir:" + toplamGelir.ToString("C");
                DurumGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir gelir miktarı girin.");
            }
        }

        private void btnHarcamaEkle_Click(object sender, EventArgs e)
        {
            if (toplamGelir < 0)
            {
                MessageBox.Show("Lütfen önce gelir ekleyin.");
                return;
            }
            if (rbZorunlu.Checked && rbIstegeBagli.Checked)
            {

                MessageBox.Show("Lütfen harcama türünü (Zorunlu/İsteğe Bağlı) seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (decimal.TryParse(txtHarcamaTutari.Text, out decimal tutar) && tutar > 0)
            {
                string kategori = cmbKategori.SelectedItem.ToString();
                string harcamaTuru = rbZorunlu.Checked ? "Zorunlu" : "İsteğe Bağlı";

                if (rbZorunlu.Checked)
                {

                    zorunluGider += tutar;
                }
                else
                {

                    istegeBagliGider += tutar;
                }
                toplamGider += tutar;

                Harcamalar.Items.Add($"{kategori} - {tutar:C} ({harcamaTuru})");
                DurumGuncelle();

            }
            else
            {
                MessageBox.Show("Lütfen geçerli ve sıfırdan büyük bir harcama tutarı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbKategori.SelectedIndex = -1;
            txtHarcamaTutari.Clear();
            rbZorunlu.Checked = false;
            rbIstegeBagli.Checked = false;

        }
        private void DurumGuncelle()
        {
            decimal kalanButce = toplamGelir - toplamGider;

            lblToplamGider.Text = "Toplam Gider: " + toplamGider.ToString("C");
            lblKalanButce.Text = "Kalan Bütçe: " + kalanButce.ToString("C");
            lblZorunluToplam.Text = "Toplam Zorunlu: " + zorunluGider.ToString("C");
            lblIstegeBagliToplam.Text = "Toplam İsteğe Bağlı: " + istegeBagliGider.ToString("C");

            if (toplamGider > toplamGelir)
            {
                lblDurumMesaji.Text = "Bütçe açığı! Giderleriniz gelirinizi aştı.";
                lblDurumMesaji.ForeColor = Color.Red;
            }
            else if (toplamGider > (toplamGelir * 0.70m))
            {
                lblDurumMesaji.Text = "Dikkat! Harcamalarınız gelirin %70'ini aştı.";
                lblDurumMesaji.ForeColor = Color.Orange;
            }
            else
            {
                lblDurumMesaji.Text = "Bütçe durumunuz iyi.";
                lblDurumMesaji.ForeColor = Color.Green;
            }
        }

    }
}

namespace Ders1TekrarÇalışmam
{
    public partial class Form1 : Form
    {
        public void toplamMiktar()
        {
            int miktar = 0;
            if (cbBesiktasForma.Checked)
            {
                miktar += 850;
            }
            if (cbFenerForma.Checked)
            {
                miktar += 950;
            }
            if (cbGalatasarayForma.Checked)
            {
                miktar += 1020;
            }
            if (cbMilanForma.Checked)
            {
                miktar += 1850;
            }
            if (cbRealForma.Checked)
            {
                miktar += 2050;
            }
            lblToplamMiktar.Text = miktar.ToString();
        }


        public Form1()
        {
            InitializeComponent();
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string Adi, tel, adres, sehir, cinsiyet = " ", urun = " ";
            Adi = txtAdi.Text;
            tel = txtTel.Text;
            adres = txtAdres.Text;
            sehir = cmbSehir.Text;
            if (rbKadin.Checked)
            {
                cinsiyet = rbKadin.Text;
            }
            else if (rbErkek.Checked)
            {
                cinsiyet = rbErkek.Text;
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
            if (cbMilanForma.Checked)
            {
                urun = urun + " " + cbMilanForma.Text;
            }
            if (cbGalatasarayForma.Checked)
            {
                urun = urun + " " + cbGalatasarayForma.Text;
            }
            if (cbFenerForma.Checked)
            {
                urun = urun + " " + cbFenerForma.Text;
            }
            if (cbRealForma.Checked)
            {
                urun = urun + " " + cbRealForma.Text;
            }
            if (cbBesiktasForma.Checked)
            {
                urun = urun + " " + cbBesiktasForma.Text;
            }
            lbBilgiler.Items.Add("Adı:" + Adi + " | "
                + "Telefon:" + tel + " | "
                + "Adres:" + adres + " | "
                + "Şehir:" + sehir + " | "
                + "Cinsiyet:" + cinsiyet + " | "
                + "Ürünler:" + urun + ", "
                + "Ödenecek Mİktar:" + lblToplamMiktar.Text + " | ");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.ResetText();
            txtAdres.ResetText();
            txtTel.ResetText();
            cmbSehir.Text = " ";
            rbErkek.Checked = false;
            rbKadin.Enabled = false;
            cbBesiktasForma.Checked = false;
            cbRealForma.Checked = false;
            cbFenerForma.Checked = false;
            cbGalatasarayForma.Checked = false;
            cbMilanForma.Checked = false;
        }

        private void cbMilanForma_CheckedChanged(object sender, EventArgs e)
        {
            toplamMiktar();
        }

        private void cbFenerForma_CheckedChanged(object sender, EventArgs e)
        {
            toplamMiktar();
        }

        private void cbGalatasarayForma_CheckedChanged(object sender, EventArgs e)
        {
            toplamMiktar();
        }

        private void cbBesiktasForma_CheckedChanged(object sender, EventArgs e)
        {
            toplamMiktar();
        }

        private void cbRealForma_CheckedChanged(object sender, EventArgs e)
        {
            toplamMiktar();
        }
    }
}
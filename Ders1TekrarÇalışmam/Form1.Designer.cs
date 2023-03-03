namespace Ders1TekrarÇalışmam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cbMilanForma = new CheckBox();
            cbFenerForma = new CheckBox();
            cbGalatasarayForma = new CheckBox();
            cbBesiktasForma = new CheckBox();
            cbRealForma = new CheckBox();
            groupBox2 = new GroupBox();
            lblToplamMiktar = new Label();
            btnTemizle = new Button();
            btnKaydet = new Button();
            txtTel = new MaskedTextBox();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            cmbSehir = new ComboBox();
            txtAdres = new TextBox();
            txtAdi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbBilgiler = new ListBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürünler";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1062, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 140);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(821, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 140);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(561, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 140);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(309, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbMilanForma
            // 
            cbMilanForma.AutoSize = true;
            cbMilanForma.Location = new Point(61, 197);
            cbMilanForma.Name = "cbMilanForma";
            cbMilanForma.Size = new Size(114, 24);
            cbMilanForma.TabIndex = 1;
            cbMilanForma.Text = "Milan Forma";
            cbMilanForma.UseVisualStyleBackColor = true;
            cbMilanForma.CheckedChanged += cbMilanForma_CheckedChanged;
            // 
            // cbFenerForma
            // 
            cbFenerForma.AutoSize = true;
            cbFenerForma.Location = new Point(322, 197);
            cbFenerForma.Name = "cbFenerForma";
            cbFenerForma.Size = new Size(153, 24);
            cbFenerForma.TabIndex = 2;
            cbFenerForma.Text = "Fenerbahçe Forma";
            cbFenerForma.UseVisualStyleBackColor = true;
            cbFenerForma.CheckedChanged += cbFenerForma_CheckedChanged;
            // 
            // cbGalatasarayForma
            // 
            cbGalatasarayForma.AutoSize = true;
            cbGalatasarayForma.Location = new Point(574, 197);
            cbGalatasarayForma.Name = "cbGalatasarayForma";
            cbGalatasarayForma.Size = new Size(108, 24);
            cbGalatasarayForma.TabIndex = 3;
            cbGalatasarayForma.Text = "Galatasaray";
            cbGalatasarayForma.UseVisualStyleBackColor = true;
            cbGalatasarayForma.CheckedChanged += cbGalatasarayForma_CheckedChanged;
            // 
            // cbBesiktasForma
            // 
            cbBesiktasForma.AutoSize = true;
            cbBesiktasForma.Location = new Point(834, 197);
            cbBesiktasForma.Name = "cbBesiktasForma";
            cbBesiktasForma.Size = new Size(84, 24);
            cbBesiktasForma.TabIndex = 4;
            cbBesiktasForma.Text = "Beşiktaş";
            cbBesiktasForma.UseVisualStyleBackColor = true;
            cbBesiktasForma.CheckedChanged += cbBesiktasForma_CheckedChanged;
            // 
            // cbRealForma
            // 
            cbRealForma.AutoSize = true;
            cbRealForma.Location = new Point(1075, 197);
            cbRealForma.Name = "cbRealForma";
            cbRealForma.Size = new Size(112, 24);
            cbRealForma.TabIndex = 5;
            cbRealForma.Text = "Real Madrid";
            cbRealForma.UseVisualStyleBackColor = true;
            cbRealForma.CheckedChanged += cbRealForma_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblToplamMiktar);
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(txtTel);
            groupBox2.Controls.Add(rbKadin);
            groupBox2.Controls.Add(rbErkek);
            groupBox2.Controls.Add(cmbSehir);
            groupBox2.Controls.Add(txtAdres);
            groupBox2.Controls.Add(txtAdi);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(13, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1262, 339);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " Kişisel Bilgiler";
            // 
            // lblToplamMiktar
            // 
            lblToplamMiktar.AutoSize = true;
            lblToplamMiktar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamMiktar.Location = new Point(928, 104);
            lblToplamMiktar.Name = "lblToplamMiktar";
            lblToplamMiktar.Size = new Size(18, 20);
            lblToplamMiktar.TabIndex = 14;
            lblToplamMiktar.Text = "0";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(209, 267);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(93, 38);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(97, 267);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(93, 38);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(98, 68);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(204, 27);
            txtTel.TabIndex = 11;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(209, 222);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(68, 24);
            rbKadin.TabIndex = 10;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(97, 224);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(65, 24);
            rbErkek.TabIndex = 9;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // cmbSehir
            // 
            cmbSehir.FormattingEnabled = true;
            cmbSehir.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Bursa" });
            cmbSehir.Location = new Point(97, 180);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Size = new Size(205, 28);
            cmbSehir.TabIndex = 8;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(97, 101);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(205, 64);
            txtAdres.TabIndex = 7;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(97, 38);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(205, 27);
            txtAdi.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 224);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 180);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Şehir:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 104);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Adres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 72);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefon:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // lbBilgiler
            // 
            lbBilgiler.FormattingEnabled = true;
            lbBilgiler.ItemHeight = 20;
            lbBilgiler.Location = new Point(13, 616);
            lbBilgiler.Name = "lbBilgiler";
            lbBilgiler.Size = new Size(1260, 144);
            lbBilgiler.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(811, 104);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 15;
            label6.Text = "Toplam Miktar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1325, 833);
            Controls.Add(lbBilgiler);
            Controls.Add(cbRealForma);
            Controls.Add(groupBox2);
            Controls.Add(cbBesiktasForma);
            Controls.Add(groupBox1);
            Controls.Add(cbGalatasarayForma);
            Controls.Add(cbMilanForma);
            Controls.Add(cbFenerForma);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox cbMilanForma;
        private CheckBox cbFenerForma;
        private CheckBox cbGalatasarayForma;
        private CheckBox cbBesiktasForma;
        private CheckBox cbRealForma;
        private GroupBox groupBox2;
        private Button btnTemizle;
        private Button btnKaydet;
        private MaskedTextBox txtTel;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private ComboBox cmbSehir;
        private TextBox txtAdres;
        private TextBox txtAdi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblToplamMiktar;
        private ListBox lbBilgiler;
        private Label label6;
    }
}
namespace KutuphaneTakipUygulaması
{
    partial class AddBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKayitNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.cbbYazarAdi = new System.Windows.Forms.ComboBox();
            this.cbbYayinevi = new System.Windows.Forms.ComboBox();
            this.txtBasimYil = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.cbbTuru = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cbbDolap = new System.Windows.Forms.ComboBox();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFiltrele = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt No";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar Adı";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basım Yılı";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yayın Evi";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Türü";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dolap";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Açıklama";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Raf";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sıra";
            // 
            // txtKayitNo
            // 
            this.txtKayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKayitNo.Location = new System.Drawing.Point(75, 2);
            this.txtKayitNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKayitNo.Name = "txtKayitNo";
            this.txtKayitNo.ReadOnly = true;
            this.txtKayitNo.Size = new System.Drawing.Size(133, 20);
            this.txtKayitNo.TabIndex = 11;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKitapAdi.Location = new System.Drawing.Point(75, 26);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(133, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // cbbYazarAdi
            // 
            this.cbbYazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbYazarAdi.FormattingEnabled = true;
            this.cbbYazarAdi.Location = new System.Drawing.Point(75, 50);
            this.cbbYazarAdi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbYazarAdi.Name = "cbbYazarAdi";
            this.cbbYazarAdi.Size = new System.Drawing.Size(133, 21);
            this.cbbYazarAdi.TabIndex = 1;
            // 
            // cbbYayinevi
            // 
            this.cbbYayinevi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbYayinevi.FormattingEnabled = true;
            this.cbbYayinevi.Location = new System.Drawing.Point(75, 98);
            this.cbbYayinevi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbYayinevi.Name = "cbbYayinevi";
            this.cbbYayinevi.Size = new System.Drawing.Size(133, 21);
            this.cbbYayinevi.TabIndex = 3;
            // 
            // txtBasimYil
            // 
            this.txtBasimYil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBasimYil.Location = new System.Drawing.Point(75, 74);
            this.txtBasimYil.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasimYil.Name = "txtBasimYil";
            this.txtBasimYil.Size = new System.Drawing.Size(133, 20);
            this.txtBasimYil.TabIndex = 2;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(75, 122);
            this.txtSayfaSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(133, 20);
            this.txtSayfaSayisi.TabIndex = 4;
            // 
            // cbbTuru
            // 
            this.cbbTuru.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbTuru.FormattingEnabled = true;
            this.cbbTuru.Location = new System.Drawing.Point(75, 146);
            this.cbbTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTuru.Name = "cbbTuru";
            this.cbbTuru.Size = new System.Drawing.Size(133, 21);
            this.cbbTuru.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAciklama.Location = new System.Drawing.Point(75, 170);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(133, 44);
            this.txtAciklama.TabIndex = 6;
            // 
            // cbbDolap
            // 
            this.cbbDolap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbDolap.FormattingEnabled = true;
            this.cbbDolap.Location = new System.Drawing.Point(75, 218);
            this.cbbDolap.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDolap.Name = "cbbDolap";
            this.cbbDolap.Size = new System.Drawing.Size(133, 21);
            this.cbbDolap.TabIndex = 7;
            // 
            // txtRaf
            // 
            this.txtRaf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRaf.Location = new System.Drawing.Point(75, 242);
            this.txtRaf.Margin = new System.Windows.Forms.Padding(2);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(133, 20);
            this.txtRaf.TabIndex = 8;
            // 
            // txtSira
            // 
            this.txtSira.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSira.Location = new System.Drawing.Point(75, 268);
            this.txtSira.Margin = new System.Windows.Forms.Padding(2);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(133, 20);
            this.txtSira.TabIndex = 9;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel.Controls.Add(this.txtSira, 1, 10);
            this.tableLayoutPanel.Controls.Add(this.txtRaf, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.cbbDolap, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.txtAciklama, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.cbbTuru, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.txtSayfaSayisi, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.cbbYayinevi, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.cbbYazarAdi, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtBasimYil, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtKitapAdi, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.txtKayitNo, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel.Location = new System.Drawing.Point(15, 32);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(210, 292);
            this.tableLayoutPanel.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnKaydet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTemizle, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 331);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 28);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKaydet.Location = new System.Drawing.Point(2, 2);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(66, 24);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.Location = new System.Drawing.Point(72, 2);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(66, 24);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemizle.Location = new System.Drawing.Point(142, 2);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(66, 24);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(230, 31);
            this.dg.Margin = new System.Windows.Forms.Padding(2);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(386, 328);
            this.dg.TabIndex = 14;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Filtrele";
            // 
            // txtFiltrele
            // 
            this.txtFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrele.Location = new System.Drawing.Point(478, 8);
            this.txtFiltrele.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltrele.Name = "txtFiltrele";
            this.txtFiltrele.Size = new System.Drawing.Size(138, 20);
            this.txtFiltrele.TabIndex = 16;
            this.txtFiltrele.TextChanged += new System.EventHandler(this.txtFiltrele_TextChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.txtFiltrele);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKayitNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.ComboBox cbbYazarAdi;
        private System.Windows.Forms.ComboBox cbbYayinevi;
        private System.Windows.Forms.TextBox txtBasimYil;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox cbbTuru;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cbbDolap;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFiltrele;
    }
}
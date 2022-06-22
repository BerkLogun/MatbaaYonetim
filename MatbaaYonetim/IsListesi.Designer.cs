
namespace MatbaaYonetim
{
    partial class IsListesi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isListesiDataGrid = new System.Windows.Forms.DataGridView();
            this.filtreCombo1 = new System.Windows.Forms.ComboBox();
            this.isID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baskiAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitEbadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitCinsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selefonSira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakSira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobstSira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kazanliSira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siralamaGuncelle = new System.Windows.Forms.Button();
            this.isID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakOnTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kesilenAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitEbat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gramajCins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selefonSira1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakSira1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobstSira1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kazanliSira1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira70x100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira50x70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sms2Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.isListesiDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // isListesiDataGrid
            // 
            this.isListesiDataGrid.AllowDrop = true;
            this.isListesiDataGrid.AllowUserToAddRows = false;
            this.isListesiDataGrid.AllowUserToOrderColumns = true;
            this.isListesiDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.isListesiDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isListesiDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.isListesiDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.isListesiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isListesiDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isID1,
            this.tarih,
            this.firmaAdi,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.lakOnTur,
            this.kesilenAdet,
            this.kagitEbat,
            this.gramajCins,
            this.selefonSira1,
            this.lakSira1,
            this.bobstSira1,
            this.kazanliSira1,
            this.sira70x100,
            this.sira50x70,
            this.sms2Sira});
            this.isListesiDataGrid.Location = new System.Drawing.Point(0, 3);
            this.isListesiDataGrid.MultiSelect = false;
            this.isListesiDataGrid.Name = "isListesiDataGrid";
            this.isListesiDataGrid.RowTemplate.Height = 25;
            this.isListesiDataGrid.Size = new System.Drawing.Size(1446, 450);
            this.isListesiDataGrid.TabIndex = 0;
            this.isListesiDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.isListesiDataGrid_CellMouseDown);
            this.isListesiDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.isListesiDataGrid_RowsAdded);
            this.isListesiDataGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.isListesiDataGrid_MouseMove);
            this.isListesiDataGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.isListesiDataGrid_MouseUp);
            // 
            // filtreCombo1
            // 
            this.filtreCombo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filtreCombo1.FormattingEnabled = true;
            this.filtreCombo1.Items.AddRange(new object[] {
            "HEPSİ",
            "SELEFON",
            "LAK",
            "BOBST KESİM",
            "KAZANLI KESİM",
            "70X100",
            "50X70",
            "SMS2"});
            this.filtreCombo1.Location = new System.Drawing.Point(1452, 3);
            this.filtreCombo1.Name = "filtreCombo1";
            this.filtreCombo1.Size = new System.Drawing.Size(189, 29);
            this.filtreCombo1.TabIndex = 1;
            this.filtreCombo1.SelectedIndexChanged += new System.EventHandler(this.filtreCombo1_SelectedIndexChanged);
            // 
            // isID
            // 
            this.isID.HeaderText = "İş NO";
            this.isID.Name = "isID";
            // 
            // tarih_1
            // 
            this.tarih_1.HeaderText = "Tarih";
            this.tarih_1.MinimumWidth = 20;
            this.tarih_1.Name = "tarih_1";
            // 
            // Firma
            // 
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            this.Firma.Width = 150;
            // 
            // isAdi
            // 
            this.isAdi.HeaderText = "İşin Adı";
            this.isAdi.Name = "isAdi";
            this.isAdi.Width = 150;
            // 
            // makine
            // 
            this.makine.HeaderText = "Makine";
            this.makine.Name = "makine";
            this.makine.Width = 150;
            // 
            // lakTuru
            // 
            this.lakTuru.HeaderText = "Lak Türü";
            this.lakTuru.Name = "lakTuru";
            // 
            // baskiAdedi
            // 
            this.baskiAdedi.HeaderText = "Baskı Adedi";
            this.baskiAdedi.Name = "baskiAdedi";
            // 
            // kagitEbadi
            // 
            this.kagitEbadi.HeaderText = "Kağıt Ebatı";
            this.kagitEbadi.Name = "kagitEbadi";
            this.kagitEbadi.Width = 150;
            // 
            // kagitCinsi
            // 
            this.kagitCinsi.HeaderText = "Kağıt Cinsi";
            this.kagitCinsi.Name = "kagitCinsi";
            this.kagitCinsi.Width = 150;
            // 
            // selefonSira
            // 
            this.selefonSira.HeaderText = "selefonSira";
            this.selefonSira.Name = "selefonSira";
            // 
            // lakSira
            // 
            this.lakSira.HeaderText = "lakSira";
            this.lakSira.Name = "lakSira";
            // 
            // bobstSira
            // 
            this.bobstSira.HeaderText = "bobstSira";
            this.bobstSira.Name = "bobstSira";
            // 
            // kazanliSira
            // 
            this.kazanliSira.HeaderText = "kazanliSira";
            this.kazanliSira.Name = "kazanliSira";
            // 
            // siralamaGuncelle
            // 
            this.siralamaGuncelle.Location = new System.Drawing.Point(1515, 292);
            this.siralamaGuncelle.Name = "siralamaGuncelle";
            this.siralamaGuncelle.Size = new System.Drawing.Size(73, 40);
            this.siralamaGuncelle.TabIndex = 2;
            this.siralamaGuncelle.Text = "SIRALAMA GÜNCELLE";
            this.siralamaGuncelle.UseVisualStyleBackColor = true;
            this.siralamaGuncelle.Click += new System.EventHandler(this.siralamaGuncelle_Click);
            // 
            // isID1
            // 
            this.isID1.HeaderText = "isID";
            this.isID1.Name = "isID1";
            // 
            // tarih
            // 
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            // 
            // firmaAdi
            // 
            this.firmaAdi.HeaderText = "FİRMA ADI";
            this.firmaAdi.Name = "firmaAdi";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "İŞ ADI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "makine";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lakOnTur
            // 
            this.lakOnTur.HeaderText = "lakOnTur";
            this.lakOnTur.Name = "lakOnTur";
            // 
            // kesilenAdet
            // 
            this.kesilenAdet.HeaderText = "KESİLEN ADET";
            this.kesilenAdet.Name = "kesilenAdet";
            // 
            // kagitEbat
            // 
            this.kagitEbat.HeaderText = "Kağıt Ebat";
            this.kagitEbat.Name = "kagitEbat";
            // 
            // gramajCins
            // 
            this.gramajCins.HeaderText = "Gramaj Cins";
            this.gramajCins.Name = "gramajCins";
            // 
            // selefonSira1
            // 
            this.selefonSira1.HeaderText = "selefonSira1";
            this.selefonSira1.Name = "selefonSira1";
            // 
            // lakSira1
            // 
            this.lakSira1.HeaderText = "lakSira1";
            this.lakSira1.Name = "lakSira1";
            // 
            // bobstSira1
            // 
            this.bobstSira1.HeaderText = "bobstSira";
            this.bobstSira1.Name = "bobstSira1";
            // 
            // kazanliSira1
            // 
            this.kazanliSira1.HeaderText = "kazanliSira";
            this.kazanliSira1.Name = "kazanliSira1";
            // 
            // sira70x100
            // 
            this.sira70x100.HeaderText = "70x100 Sira";
            this.sira70x100.Name = "sira70x100";
            // 
            // sira50x70
            // 
            this.sira50x70.HeaderText = "50x70 Sira";
            this.sira50x70.Name = "sira50x70";
            // 
            // sms2Sira
            // 
            this.sms2Sira.HeaderText = "sms2Sira";
            this.sms2Sira.Name = "sms2Sira";
            // 
            // IsListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.siralamaGuncelle);
            this.Controls.Add(this.filtreCombo1);
            this.Controls.Add(this.isListesiDataGrid);
            this.Name = "IsListesi";
            this.Size = new System.Drawing.Size(1843, 969);
            ((System.ComponentModel.ISupportInitialize)(this.isListesiDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView isListesiDataGrid;
        private System.Windows.Forms.ComboBox filtreCombo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn makine;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn baskiAdedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitEbadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitCinsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn selefonSira;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakSira;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobstSira;
        private System.Windows.Forms.DataGridViewTextBoxColumn kazanliSira;
        private System.Windows.Forms.Button siralamaGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn isID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakOnTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn kesilenAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitEbat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramajCins;
        private System.Windows.Forms.DataGridViewTextBoxColumn selefonSira1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakSira1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobstSira1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kazanliSira1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira70x100;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira50x70;
        private System.Windows.Forms.DataGridViewTextBoxColumn sms2Sira;
    }
}

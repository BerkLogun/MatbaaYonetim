
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
            this.isID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baskiAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitEbadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitCinsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtreCombo1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.isListesiDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // isListesiDataGrid
            // 
            this.isListesiDataGrid.AllowUserToOrderColumns = true;
            this.isListesiDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.isListesiDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isListesiDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.isListesiDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.isListesiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isListesiDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isID,
            this.tarih_1,
            this.Firma,
            this.isAdi,
            this.makine,
            this.lakTuru,
            this.baskiAdedi,
            this.kagitEbadi,
            this.kagitCinsi});
            this.isListesiDataGrid.Location = new System.Drawing.Point(0, 0);
            this.isListesiDataGrid.Name = "isListesiDataGrid";
            this.isListesiDataGrid.RowTemplate.Height = 25;
            this.isListesiDataGrid.Size = new System.Drawing.Size(1192, 450);
            this.isListesiDataGrid.TabIndex = 0;
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
            this.filtreCombo1.Location = new System.Drawing.Point(1393, 15);
            this.filtreCombo1.Name = "filtreCombo1";
            this.filtreCombo1.Size = new System.Drawing.Size(189, 29);
            this.filtreCombo1.TabIndex = 1;
            this.filtreCombo1.SelectedIndexChanged += new System.EventHandler(this.filtreCombo1_SelectedIndexChanged);
            // 
            // IsListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.filtreCombo1);
            this.Controls.Add(this.isListesiDataGrid);
            this.Name = "IsListesi";
            this.Size = new System.Drawing.Size(1843, 969);
            ((System.ComponentModel.ISupportInitialize)(this.isListesiDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView isListesiDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn makine;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn baskiAdedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitEbadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitCinsi;
        private System.Windows.Forms.ComboBox filtreCombo1;
    }
}


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
            this.isinAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalipRenkAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baskiAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitEbadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitCinsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.isListesiDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // isListesiDataGrid
            // 
            this.isListesiDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.isListesiDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isListesiDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.isListesiDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.isListesiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isListesiDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isinAdi,
            this.tarih_1,
            this.Firma,
            this.dataGridViewTextBoxColumn1,
            this.kalipRenkAdet,
            this.lakTuru,
            this.baskiAdedi,
            this.kagitEbadi,
            this.kagitCinsi});
            this.isListesiDataGrid.Location = new System.Drawing.Point(0, 0);
            this.isListesiDataGrid.Name = "isListesiDataGrid";
            this.isListesiDataGrid.RowTemplate.Height = 25;
            this.isListesiDataGrid.Size = new System.Drawing.Size(1257, 969);
            this.isListesiDataGrid.TabIndex = 0;
            // 
            // isinAdi
            // 
            this.isinAdi.HeaderText = "Sıra No";
            this.isinAdi.Name = "isinAdi";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "İşin Adı";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // kalipRenkAdet
            // 
            this.kalipRenkAdet.HeaderText = "Kalip Adedi / Renk";
            this.kalipRenkAdet.Name = "kalipRenkAdet";
            this.kalipRenkAdet.Width = 150;
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
            // IsListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.isListesiDataGrid);
            this.Name = "IsListesi";
            this.Size = new System.Drawing.Size(1843, 969);
            ((System.ComponentModel.ISupportInitialize)(this.isListesiDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView isListesiDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isinAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalipRenkAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn baskiAdedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitEbadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitCinsi;
    }
}

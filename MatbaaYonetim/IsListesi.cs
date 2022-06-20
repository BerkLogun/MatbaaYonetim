using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MatbaaYonetim
{
    public partial class IsListesi : UserControl
    {
        public IsListesi()
        {
            InitializeComponent();
            
        }


        public void dataListUpdate()
        {
            string connectionString = "Data Source=matbaa-yonetim.database.windows.net;Initial Catalog=MatbaaLogs;Persist Security Info=True;User ID=ecra;Password=berkod123A";
            SqlConnection connect = new SqlConnection(connectionString);
            


            if(filtreCombo1.Text == "HEPSİ")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "SELEFON")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE NOT selefOnX =''");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "LAK")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE NOT lakOnEbatX =''");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if(filtreCombo1.Text == "BOBST KESİM")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE kesimIslem ='BOBST GOFRE'");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "KAZANLI KESİM")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE kesimIslem ='KAZANLI KESIM'");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "70X100")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE makine ='70X100'");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "50X70")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE makine ='50X70'");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }
            if (filtreCombo1.Text == "50X70")
            {
                isListesiDataGrid.Rows.Clear();
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT isID, tarih, firmaAdi, isAdi, makine, lakOnTur, kesilenAdet, kagitEbat, gramajCins FROM isListesi WHERE makine ='SMS2'");
                cmd.Connection = connect;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    isListesiDataGrid.Rows.Add(da.GetValue(0).ToString(), da.GetValue(1).ToString(), da.GetValue(2).ToString(), da.GetValue(3).ToString(), da.GetValue(4).ToString(), da.GetValue(5).ToString(), da.GetValue(6).ToString(), da.GetValue(7).ToString(), da.GetValue(8).ToString(),"","","","","","","");
                }

                connect.Close();
            }

        }

        private void filtreCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataListUpdate();
        }




        int dragRow = -1;
        Label dragLabel = null;

        private void isListesiDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            dragRow = e.RowIndex;

            if (dragLabel == null) dragLabel = new Label();
            dragLabel.Text = isListesiDataGrid[e.ColumnIndex, e.RowIndex].Value.ToString();

            dragLabel.Parent = isListesiDataGrid;
            dragLabel.Location = e.Location;
        }

        private void isListesiDataGrid_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left && dragLabel != null)
                {
                    dragLabel.Location = e.Location;
                    isListesiDataGrid.ClearSelection();
                }
            }
            catch { }
        }

        private void isListesiDataGrid_MouseUp(object sender, MouseEventArgs e)
        {

            var hit = isListesiDataGrid.HitTest(e.X, e.Y);
            int dropRow = -1;

            try
            {
                if (hit.Type != DataGridViewHitTestType.None)
                {
                    dropRow = hit.RowIndex;
                    if (dragRow >= 0)
                    {
                        int tgtRow = dropRow + (dragRow > dropRow ? 1 : 0);
                        if (tgtRow != dragRow)
                        {
                            DataGridViewRow row = isListesiDataGrid.Rows[dragRow];
                            isListesiDataGrid.Rows.Remove(row);
                            isListesiDataGrid.Rows.Insert(tgtRow, row);

                            isListesiDataGrid.ClearSelection();
                            row.Selected = true;
                        }
                    }
                }
                else { isListesiDataGrid.Rows[dragRow].Selected = true; }

                if (dragLabel != null)
                {
                    dragLabel.Dispose();
                    dragLabel = null;
                }

            }
            catch { }
        }

        private void isListesiDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            /*if (isListesiDataGrid.Columns.Contains("siraNo"))
             {
                 foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                 {
                     r.Cells["siraNo"].Value = r.Index + 1;
                 }
             }
             */

            try
            {
                if (filtreCombo1.Text == "SELEFON")
                {
                    if (isListesiDataGrid.Columns.Contains("selefonSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["selefonSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "LAK")
                {
                    if (isListesiDataGrid.Columns.Contains("lakSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["lakSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "BOBST KESİM")
                {
                    if (isListesiDataGrid.Columns.Contains("bobstSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["bobstSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "KAZANLI KESİM")
                {
                    if (isListesiDataGrid.Columns.Contains("kazanliSira1"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["kazanliSira1"].Value = r.Index + 1;
                        }
                    }
                }
                if (filtreCombo1.Text == "KAZANLI KESİM")
                {
                    if (isListesiDataGrid.Columns.Contains("kazanliSira"))
                    {
                        foreach (DataGridViewRow r in isListesiDataGrid.Rows)
                        {
                            r.Cells["kazanliSira"].Value = r.Index + 1;
                        }
                    }
                }
            }
            catch { }
        }
    }
}

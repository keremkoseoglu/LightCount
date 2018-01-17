using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sayim
{
    public partial class Form2 : Form
    {
        private DataSet ds;
        private FileStream fs;
        private Warehouse warehouse;

        public Form2(Warehouse W)
        {
            InitializeComponent();
            warehouse = W;
            prepareDataset();
            initializeFocus();
        }

        private void prepareDataset()
        {
            // Eðer dosya mevcutsa onu kullanacaðýz
            DirectoryInfo di = new DirectoryInfo(Program.applicationPath);
            foreach (FileInfo fi in di.GetFiles("*.xml"))
            {
                ds = new DataSet();
                ds.ReadXml(fi.FullName);
                Program.fileName = fi.FullName;
                fs = fi.OpenWrite();
            }

            // Dosya bulamadýysak, tabloyu baþtan yaratalým
            if (ds == null)
            {
                ds = new DataSet();
                ds.Tables.Add("SAYIM");
                ds.Tables[0].Columns.Add("BARKOD");
                ds.Tables[0].Columns.Add("MIKTAR");
                ds.Tables[0].Columns.Add("OB");
                ds.Tables[0].Columns.Add("DEPO");
                fs = null;
            }

            // Data source
            ds.Tables[0].Columns[0].ReadOnly = true;
            ds.Tables[0].Columns[2].ReadOnly = true;
            ds.Tables[0].Columns[3].ReadOnly = true;

            dgMain.DataSource = ds.Tables[0];

            // Table STyle
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = "SAYIM";

            DataGridColumnStyle dgcs;
                
            dgcs = new DataGridTextBoxColumn();
            dgcs.MappingName = "BARKOD";
            dgcs.HeaderText = "BARKOD";
            dgcs.Width = 120;
            ts.GridColumnStyles.Add(dgcs);

            dgcs = new DataGridTextBoxColumn();
            dgcs.MappingName = "MIKTAR";
            dgcs.HeaderText = "MIKTAR";
            dgcs.Width = 50;
            ts.GridColumnStyles.Add(dgcs);

            dgcs = new DataGridTextBoxColumn();
            dgcs.MappingName = "OB";
            dgcs.HeaderText = "OB";
            dgcs.Width = 30;
            ts.GridColumnStyles.Add(dgcs);

            dgcs = new DataGridTextBoxColumn();
            dgcs.MappingName = "DEPO";
            dgcs.HeaderText = "DEPO";
            dgcs.Width = 50;
            ts.GridColumnStyles.Add(dgcs);

            dgMain.TableStyles.Clear();
            dgMain.TableStyles.Add(ts);

            //dgMain.TableStyles["ISIK"].GridColumnStyles["BARKOD"].Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBar.Text.Length <= 0)
            {
                MessageBox.Show("Lutfen once barkodu okutun");
                initializeFocus();
                return;
            }

            for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
            {
                if (ds.Tables[0].Rows[n]["BARKOD"].ToString() == txtBar.Text)
                {
                    MessageBox.Show("Bu barkodu daha once okutmussunuz");
                    initializeFocus();
                    return;
                }
            }

            callNextForm();
        }

        private void callPrevForm()
        {
            fs.Close();
            Program.mustAnalyseBarkodForMeins = false;
            Program.form1.Show();
            this.Dispose();
        }

        private void callNextForm()
        {
            Program.form3 = new Form3(txtBar.Text, warehouse);
            Program.form3.Show();
            this.Hide();
        }

        private void callNextForm(int RowIndex)
        {
            Program.form3 = new Form3(ds.Tables[0].Rows[RowIndex]["BARKOD"].ToString(), RowIndex, ds.Tables[0].Rows[RowIndex]["MIKTAR"].ToString(), warehouse);
            Program.form3.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kaydetmeden cikiyorsunuz! Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Yes) return;

            callPrevForm();
        }

        private void Form2_Closed(object sender, EventArgs e)
        {
            callPrevForm();
        }

        public void transferQuantity(string Quantity, string Meins, int RowIndex)
        {
            if (RowIndex < 0)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["BARKOD"] = txtBar.Text;
                dr["MIKTAR"] = Quantity;
                dr["OB"] = Meins;
                dr["DEPO"] = warehouse.code;
                ds.Tables[0].Rows.Add(dr);
            }
            else
            {
                ds.Tables[0].Rows[RowIndex]["MIKTAR"] = Quantity;
            }

            dgMain.Refresh();
            initializeFocus();
        }

        public void initializeFocus()
        {
            txtBar.Text = "";
            txtBar.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void txtBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && txtBar.Text.Length <= 0) save();
        }

        private void save()
        {
            DialogResult dr = MessageBox.Show("Ekran kaydedilecek! Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Yes) return;

            try
            {
                //MessageBox.Show(Program.fileName + " kaydedilecek");
                if (fs != null) fs.Close();
                ds.WriteXml(Program.fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            callPrevForm();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int n = dgMain.CurrentRowIndex;
            if (n < 0) return;

            DialogResult dr = MessageBox.Show("Satýr silinecek! Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Yes) return;

            ds.Tables[0].Rows[n].Delete();
            dgMain.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int n = dgMain.CurrentRowIndex;
            if (n < 0) return;

            callNextForm(n);
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sayim
{
    public partial class Form3 : Form
    {
        private int rowIndex;

        public Form3()
        {
            InitializeComponent();
            rowIndex = -1;
            init();
        }

        public Form3(string Barkod, Warehouse W)
        {
            InitializeComponent();
            txtWarehouse.Text = W.ToString();
            txtBar.Text = Barkod;
            rowIndex = -1;
            init();
        }

        public Form3(string Barkod, int RowIndex, string Quantity, Warehouse W)
        {
            InitializeComponent();
            txtWarehouse.Text = W.ToString();
            txtBar.Text = Barkod;
            txtMenge.Text = Quantity;
            rowIndex = RowIndex;
            init();
        }

        private void init()
        {
            txtMeins.ReadOnly = (!Program.uoms.manuelInputEnabled) || (rowIndex >= 0);

            if (Program.mustAnalyseBarkodForMeins)
            {
                txtMeins.Text = Program.uoms.getTargetUom(txtBar.Text).extCode;
            }
            else
            {
                txtMeins.Text = Program.uoms.defaultEnabledUom.extCode;
            }

            txtMenge.Focus();

            if (txtMenge.Text.Length > 0) txtMenge.SelectAll();
        }

        private void txtMenge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (Program.uoms.manuelInputEnabled)
                {
                    if (txtMenge.Text.Length > 0) txtMeins.Focus();
                }
                else
                {
                    callPrevForm(true);
                }
            }
        }

        private void txtMeins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) callPrevForm(true);
        }

        private void callPrevForm(bool TransferValues)
        {
            if (TransferValues)
            {
                if (txtMenge.Text.Length <= 0)
                {
                    MessageBox.Show("Lutfen miktari girin");
                    return;
                }

                if (!Program.uoms.isInputValid(txtMeins.Text))
                {
                    MessageBox.Show("Olcu birimi gecersiz");
                    return;
                }

                Program.form2.transferQuantity(txtMenge.Text, txtMeins.Text, rowIndex);
            }
            Program.form2.Show();
            Program.form2.initializeFocus();
            this.Dispose();
        }

        private void Form3_Closed(object sender, EventArgs e)
        {
            callPrevForm(false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            callPrevForm(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            callPrevForm(true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sayim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int n = 0; n < Program.warehouses.Count; n++)
            {
                Warehouse w = Program.warehouses[n];
                cmbWarehouse.Items.Add(w.ToString());
            }
            cmbWarehouse.SelectedIndex = 0;
        }

        private void setAllButtons(bool Enabled)
        {
            button1.Enabled = Enabled;
            button2.Enabled = Enabled;
            button3.Enabled = Enabled;
            button4.Enabled = Enabled;
            button5.Enabled = Enabled;
            button6.Enabled = Enabled;
            button7.Enabled = Enabled;
        }

        private void arrangeButtons()
        {
            Warehouse w = Program.warehouses[cmbWarehouse.SelectedIndex];

            setAllButtons(false);

            button1.Enabled = w.code == "1020" ||
                              w.code == "1030" ||
                              w.code == "1110" ||
                              w.code == "1111" ||
                              w.code == "1112" ||
                              w.code == "1120" ||
                              w.code == "1121" ||
                              w.code == "1122" ||
                              w.code == "1200" ||
                              w.code == "1400" ||
                              w.code == "1600";

            button2.Enabled = 
            button3.Enabled = w.code == "1040" ||
                              w.code == "1050" ||
                              w.code == "1110" ||
                              w.code == "1111" ||
                              w.code == "1112" ||
                              w.code == "1120" ||
                              w.code == "1121" ||
                              w.code == "1122" ||
                              w.code == "1200" ||
                              w.code == "1300" ||
                              w.code == "1400" ||
                              w.code == "1600";

            button4.Enabled =
            button5.Enabled = w.code == "1060" ||
                              w.code == "1200" ||
                              w.code == "1600";

            button6.Enabled = 
            button7.Enabled = w.code == "1010" ||
                              w.code == "1110" ||
                              w.code == "1111" ||
                              w.code == "1112" ||
                              w.code == "1120" ||
                              w.code == "1121" ||
                              w.code == "1122" ||
                              w.code == "1200" ||
                              w.code == "1400" ||
                              w.code == "1600";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            callNextForm("KG");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            callNextForm("ST");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.uoms.clearEnabledUoms();
            Program.uoms.addEnabledUom("KI");
            Program.uoms.addEnabledUom("PAL");
            Program.mustAnalyseBarkodForMeins = true;
            callNextForm();
        }

        private void callNextForm(string InternalCode)
        {
            Program.uoms.clearEnabledUoms();
            Program.uoms.addEnabledUom(InternalCode);
            callNextForm();
        }

        private void callNextForm()
        {
            this.Visible = false;
            Program.form2 = new Form2(Program.warehouses[cmbWarehouse.SelectedIndex]);
            Program.form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            callNextForm("TOR");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            callNextForm("KG");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            callNextForm("PAL");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            callNextForm("KG");
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrangeButtons();
        }
    }
}
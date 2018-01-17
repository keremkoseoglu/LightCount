namespace Sayim
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtMeins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenge = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWarehouse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.Text = "Barkod";
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(61, 73);
            this.txtBar.Name = "txtBar";
            this.txtBar.ReadOnly = true;
            this.txtBar.Size = new System.Drawing.Size(261, 23);
            this.txtBar.TabIndex = 1;
            // 
            // txtMeins
            // 
            this.txtMeins.Location = new System.Drawing.Point(246, 102);
            this.txtMeins.Name = "txtMeins";
            this.txtMeins.Size = new System.Drawing.Size(76, 23);
            this.txtMeins.TabIndex = 2;
            this.txtMeins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeins_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.Text = "Miktar";
            // 
            // txtMenge
            // 
            this.txtMenge.Location = new System.Drawing.Point(61, 102);
            this.txtMenge.Name = "txtMenge";
            this.txtMenge.Size = new System.Drawing.Size(179, 23);
            this.txtMenge.TabIndex = 1;
            this.txtMenge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMenge_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 20);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 249);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 20);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Geri";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.Text = "Depo";
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Location = new System.Drawing.Point(61, 42);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.ReadOnly = true;
            this.txtWarehouse.Size = new System.Drawing.Size(261, 23);
            this.txtWarehouse.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(325, 272);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWarehouse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMenge);
            this.Controls.Add(this.txtMeins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBar);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form3";
            this.Text = "Miktar";
            this.Closed += new System.EventHandler(this.Form3_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtMeins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMenge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWarehouse;
    }
}
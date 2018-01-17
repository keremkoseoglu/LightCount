namespace Sayim
{
    partial class Form2
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
            this.txtBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMain = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(61, 38);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(217, 23);
            this.txtBar.TabIndex = 0;
            this.txtBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBar_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.Text = "Barkod";
            // 
            // dgMain
            // 
            this.dgMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgMain.Location = new System.Drawing.Point(3, 67);
            this.dgMain.Name = "dgMain";
            this.dgMain.RowHeadersVisible = false;
            this.dgMain.Size = new System.Drawing.Size(319, 176);
            this.dgMain.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oku";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 249);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 20);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 20);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(107, 249);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(38, 20);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Sil";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(151, 249);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 20);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Deðiþtir";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(325, 272);
            this.ControlBox = false;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBar);
            this.Location = new System.Drawing.Point(1, 1);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Barkod Ekraný";
            this.Closed += new System.EventHandler(this.Form2_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dgMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
    }
}
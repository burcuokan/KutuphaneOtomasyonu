namespace KutuphaneOtomasyonu
{
    partial class FrmEmanetKitapİade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmanetKitapİade));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnTeslimAl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnTeslimAl
            // 
            this.BtnTeslimAl.BackColor = System.Drawing.Color.White;
            this.BtnTeslimAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTeslimAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTeslimAl.ImageIndex = 0;
            this.BtnTeslimAl.ImageList = this.ımageList1;
            this.BtnTeslimAl.Location = new System.Drawing.Point(437, 455);
            this.BtnTeslimAl.Name = "BtnTeslimAl";
            this.BtnTeslimAl.Size = new System.Drawing.Size(158, 48);
            this.BtnTeslimAl.TabIndex = 9;
            this.BtnTeslimAl.Text = "Teslim Al";
            this.BtnTeslimAl.UseVisualStyleBackColor = false;
            this.BtnTeslimAl.Click += new System.EventHandler(this.BtnTeslimAl_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iade1.jpg");
            this.ımageList1.Images.SetKeyName(1, "icons8_cancel_480px_1.png");
            this.ımageList1.Images.SetKeyName(2, "icons8_search_500px.png");
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.Color.White;
            this.BtnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCıkıs.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnCıkıs.ImageIndex = 1;
            this.BtnCıkıs.ImageList = this.ımageList1;
            this.BtnCıkıs.Location = new System.Drawing.Point(627, 455);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(158, 48);
            this.BtnCıkıs.TabIndex = 21;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtAra);
            this.groupBox1.Controls.Add(this.BtnAra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(428, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 87);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // TxtAra
            // 
            this.TxtAra.Location = new System.Drawing.Point(165, 36);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(129, 31);
            this.TxtAra.TabIndex = 28;
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.White;
            this.BtnAra.ImageIndex = 2;
            this.BtnAra.ImageList = this.ımageList1;
            this.BtnAra.Location = new System.Drawing.Point(300, 32);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(42, 39);
            this.BtnAra.TabIndex = 29;
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(20, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Barkod No Ara:";
            // 
            // FrmEmanetKitapİade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.BtnTeslimAl);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEmanetKitapİade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İade";
            this.Load += new System.EventHandler(this.FrmEmanetKitapİade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnTeslimAl;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Label label9;
    }
}
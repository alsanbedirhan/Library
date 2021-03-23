
namespace pro
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OGRENCINUMARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KITAPADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GETGMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnHepsi = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKitapSirala = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OGRENCINUMARA,
            this.KITAPADI,
            this.GMT,
            this.SONGMT,
            this.GETGMT});
            this.dataGridView1.Location = new System.Drawing.Point(12, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1010, 303);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // OGRENCINUMARA
            // 
            this.OGRENCINUMARA.DataPropertyName = "OGRENCINUMARA";
            this.OGRENCINUMARA.HeaderText = "Öğrencinin Numarası";
            this.OGRENCINUMARA.Name = "OGRENCINUMARA";
            // 
            // KITAPADI
            // 
            this.KITAPADI.DataPropertyName = "KITAPADI";
            this.KITAPADI.HeaderText = "Kitabın Adı";
            this.KITAPADI.Name = "KITAPADI";
            // 
            // GMT
            // 
            this.GMT.DataPropertyName = "GMT";
            this.GMT.HeaderText = "Alındığı Tarih";
            this.GMT.Name = "GMT";
            // 
            // SONGMT
            // 
            this.SONGMT.DataPropertyName = "SONGMT";
            this.SONGMT.HeaderText = "Geri Getireceği Tarih";
            this.SONGMT.Name = "SONGMT";
            // 
            // GETGMT
            // 
            this.GETGMT.DataPropertyName = "GETGMT";
            this.GETGMT.HeaderText = "Geri Getirdiği Tarih";
            this.GETGMT.Name = "GETGMT";
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(216, 340);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(202, 21);
            this.cmbOgrenci.TabIndex = 5;
            // 
            // cmbKitap
            // 
            this.cmbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(216, 387);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(202, 21);
            this.cmbKitap.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Öğrenci Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Kitap Adı:";
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(260, 483);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(118, 41);
            this.btnAl.TabIndex = 47;
            this.btnAl.Text = "Kitap Al";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(464, 340);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(118, 41);
            this.btnVer.TabIndex = 48;
            this.btnVer.Text = "Seçili Kitabı Geri Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(464, 494);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(118, 41);
            this.btnSirala.TabIndex = 50;
            this.btnSirala.Text = "Seçili Öğrencinin İşlemlerini Göster";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // btnHepsi
            // 
            this.btnHepsi.Location = new System.Drawing.Point(464, 412);
            this.btnHepsi.Name = "btnHepsi";
            this.btnHepsi.Size = new System.Drawing.Size(118, 41);
            this.btnHepsi.TabIndex = 52;
            this.btnHepsi.Text = "İşlemlerin Hepsini Göster";
            this.btnHepsi.UseVisualStyleBackColor = true;
            this.btnHepsi.Click += new System.EventHandler(this.btnHepsi_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(612, 325);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(410, 274);
            this.zedGraphControl1.TabIndex = 53;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Geri Getirileceği Tarih:";
            // 
            // btnKitapSirala
            // 
            this.btnKitapSirala.Location = new System.Drawing.Point(464, 557);
            this.btnKitapSirala.Name = "btnKitapSirala";
            this.btnKitapSirala.Size = new System.Drawing.Size(118, 41);
            this.btnKitapSirala.TabIndex = 60;
            this.btnKitapSirala.Text = "Seçili Kitabın İşlemlerini Göster";
            this.btnKitapSirala.UseVisualStyleBackColor = true;
            this.btnKitapSirala.Click += new System.EventHandler(this.btnKitapSirala_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenci.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrenci.Image")));
            this.btnOgrenci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenci.Location = new System.Drawing.Point(12, 557);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(130, 42);
            this.btnOgrenci.TabIndex = 61;
            this.btnOgrenci.Text = "Öğrenci";
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click_1);
            // 
            // btnKitap
            // 
            this.btnKitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.Image = ((System.Drawing.Image)(resources.GetObject("btnKitap.Image")));
            this.btnKitap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitap.Location = new System.Drawing.Point(12, 494);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(130, 42);
            this.btnKitap.TabIndex = 62;
            this.btnKitap.Text = "Kitap";
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 432);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 63;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitapSirala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.btnHepsi);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.cmbOgrenci);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnHepsi;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKitapSirala;
        private System.Windows.Forms.DataGridViewTextBoxColumn OGRENCINUMARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KITAPADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GETGMT;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
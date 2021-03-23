
namespace pro
{
    partial class OgrenciSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciSorgula));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OGRENCINUMARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KITAPADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GETGMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 280);
            this.dataGridView1.TabIndex = 50;
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
            // OgrenciSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciSorgula";
            this.Text = "OgrenciSorgula";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciSorgula_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OGRENCINUMARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KITAPADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GETGMT;
    }
}
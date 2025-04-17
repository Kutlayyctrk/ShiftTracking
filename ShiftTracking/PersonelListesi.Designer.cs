namespace ShiftTracking
{
    partial class PersonelListesi
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
            dgwPersonelListe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwPersonelListe).BeginInit();
            SuspendLayout();
            // 
            // dgwPersonelListe
            // 
            dgwPersonelListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPersonelListe.Dock = DockStyle.Fill;
            dgwPersonelListe.Location = new Point(0, 0);
            dgwPersonelListe.Name = "dgwPersonelListe";
            dgwPersonelListe.RowHeadersWidth = 51;
            dgwPersonelListe.Size = new Size(899, 504);
            dgwPersonelListe.TabIndex = 0;
            // 
            // PersonelListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(899, 504);
            Controls.Add(dgwPersonelListe);
            Name = "PersonelListesi";
            Text = "PersonelListesi";
            Load += PersonelListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgwPersonelListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwPersonelListe;
    }
}
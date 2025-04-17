namespace ShiftTracking
{
    partial class frmPersonelEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAsciAdiEkleme = new TextBox();
            txtAsciSoyadiEkleme = new TextBox();
            btnAscıOlusturma = new Button();
            cmbPersonelIstasyonEkleme = new ComboBox();
            cmbPozisyonEkle = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(228, 128);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 0;
            label1.Text = "Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(228, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 1;
            label2.Text = "Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(228, 257);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 3;
            label3.Text = "Pozisyon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(228, 194);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 2;
            label4.Text = "İstasyon:";
            // 
            // txtAsciAdiEkleme
            // 
            txtAsciAdiEkleme.Location = new Point(329, 58);
            txtAsciAdiEkleme.Name = "txtAsciAdiEkleme";
            txtAsciAdiEkleme.Size = new Size(125, 27);
            txtAsciAdiEkleme.TabIndex = 4;
            // 
            // txtAsciSoyadiEkleme
            // 
            txtAsciSoyadiEkleme.Location = new Point(329, 121);
            txtAsciSoyadiEkleme.Name = "txtAsciSoyadiEkleme";
            txtAsciSoyadiEkleme.Size = new Size(125, 27);
            txtAsciSoyadiEkleme.TabIndex = 5;
            // 
            // btnAscıOlusturma
            // 
            btnAscıOlusturma.Location = new Point(347, 329);
            btnAscıOlusturma.Name = "btnAscıOlusturma";
            btnAscıOlusturma.Size = new Size(94, 29);
            btnAscıOlusturma.TabIndex = 8;
            btnAscıOlusturma.Text = "Kaydet";
            btnAscıOlusturma.UseVisualStyleBackColor = true;
            btnAscıOlusturma.Click += btnAscıOlusturma_Click;
            // 
            // cmbPersonelIstasyonEkleme
            // 
            cmbPersonelIstasyonEkleme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelIstasyonEkleme.FormattingEnabled = true;
            cmbPersonelIstasyonEkleme.Items.AddRange(new object[] { "Abuyer", "Izgara", "Tava", "Fritöz", "Pizza-Soguk", "Bulaşık", "Depo" });
            cmbPersonelIstasyonEkleme.Location = new Point(329, 189);
            cmbPersonelIstasyonEkleme.Name = "cmbPersonelIstasyonEkleme";
            cmbPersonelIstasyonEkleme.Size = new Size(125, 28);
            cmbPersonelIstasyonEkleme.TabIndex = 9;
            // 
            // cmbPozisyonEkle
            // 
            cmbPozisyonEkle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozisyonEkle.FormattingEnabled = true;
            cmbPozisyonEkle.Items.AddRange(new object[] { "Mutfak Şefi", "Sous Şef", "Izgara 1", "Izgara 2", "Izgara 3", "Izgara 4", "Fritöz 1", "Fritöz 2", "Fritöz 3", "Fritöz 4", "Tava 1", "Tava 2", "Tava 3", "Tava 4", "Pizza-Soğuk 1", "Depo", "Pizza-Soğuk 2", "Pizza-Soğuk 3", "Pizza-Soğuk 4", "Bulaşık" });
            cmbPozisyonEkle.Location = new Point(329, 252);
            cmbPozisyonEkle.Name = "cmbPozisyonEkle";
            cmbPozisyonEkle.Size = new Size(125, 28);
            cmbPozisyonEkle.TabIndex = 10;
            // 
            // frmPersonelEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPozisyonEkle);
            Controls.Add(cmbPersonelIstasyonEkleme);
            Controls.Add(btnAscıOlusturma);
            Controls.Add(txtAsciSoyadiEkleme);
            Controls.Add(txtAsciAdiEkleme);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPersonelEkle";
            Text = "Personel Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAsciAdiEkleme;
        private TextBox txtAsciSoyadiEkleme;
        private Button btnAscıOlusturma;
        private ComboBox cmbPersonelIstasyonEkleme;
        private ComboBox cmbPozisyonEkle;
    }
}
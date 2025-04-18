namespace ShiftTracking
{
    partial class frmPersonelBilgi
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
            cmbpersonelbilgi = new ComboBox();
            groupBox1 = new GroupBox();
            cmbpersonelbilgipozisyon = new ComboBox();
            cmbpersonelbilgiistasyon = new ComboBox();
            txtpersonelbilgisoyad = new TextBox();
            txtpersonelbilgiad = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 166);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel Seçiniz:";
            // 
            // cmbpersonelbilgi
            // 
            cmbpersonelbilgi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpersonelbilgi.FormattingEnabled = true;
            cmbpersonelbilgi.Location = new Point(139, 158);
            cmbpersonelbilgi.Name = "cmbpersonelbilgi";
            cmbpersonelbilgi.Size = new Size(269, 28);
            cmbpersonelbilgi.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbpersonelbilgipozisyon);
            groupBox1.Controls.Add(cmbpersonelbilgiistasyon);
            groupBox1.Controls.Add(txtpersonelbilgisoyad);
            groupBox1.Controls.Add(txtpersonelbilgiad);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(493, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // cmbpersonelbilgipozisyon
            // 
            cmbpersonelbilgipozisyon.FormattingEnabled = true;
            cmbpersonelbilgipozisyon.Items.AddRange(new object[] { "Mutfak Şefi", "Sous Şef", "Izgara 1", "Izgara 2", "Izgara 3", "Izgara 4", "Fritöz 1", "Fritöz 2", "Fritöz 3", "Fritöz 4", "Tava 1", "Tava 2", "Tava 3", "Tava 4", "Pizza-Soğuk 1", "Pizza-Soğuk 2", "Pizza-Soğuk 3", "Pizza-Soğuk 4", "Depo", "Bulaşık" });
            cmbpersonelbilgipozisyon.Location = new Point(138, 200);
            cmbpersonelbilgipozisyon.Name = "cmbpersonelbilgipozisyon";
            cmbpersonelbilgipozisyon.Size = new Size(157, 28);
            cmbpersonelbilgipozisyon.TabIndex = 10;
            // 
            // cmbpersonelbilgiistasyon
            // 
            cmbpersonelbilgiistasyon.FormattingEnabled = true;
            cmbpersonelbilgiistasyon.Items.AddRange(new object[] { "Abuyer", "Fritöz", "Tava", "Izgara", "Pizza-Soğuk", "Bulaşıkhane", "Depo" });
            cmbpersonelbilgiistasyon.Location = new Point(138, 146);
            cmbpersonelbilgiistasyon.Name = "cmbpersonelbilgiistasyon";
            cmbpersonelbilgiistasyon.Size = new Size(157, 28);
            cmbpersonelbilgiistasyon.TabIndex = 9;
            // 
            // txtpersonelbilgisoyad
            // 
            txtpersonelbilgisoyad.Location = new Point(138, 84);
            txtpersonelbilgisoyad.Name = "txtpersonelbilgisoyad";
            txtpersonelbilgisoyad.Size = new Size(157, 27);
            txtpersonelbilgisoyad.TabIndex = 8;
            // 
            // txtpersonelbilgiad
            // 
            txtpersonelbilgiad.Location = new Point(138, 34);
            txtpersonelbilgiad.Name = "txtpersonelbilgiad";
            txtpersonelbilgiad.Size = new Size(157, 27);
            txtpersonelbilgiad.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(115, 292);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 7;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 208);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Pozisyon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 154);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "İstasyon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 37);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Adı:";
            // 
            // frmPersonelBilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(863, 483);
            Controls.Add(groupBox1);
            Controls.Add(cmbpersonelbilgi);
            Controls.Add(label1);
            Name = "frmPersonelBilgi";
            Text = "Personel Bilgi Ekranı";
            Load += frmPersonelBilgi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbpersonelbilgi;
        private GroupBox groupBox1;
        private ComboBox cmbpersonelbilgipozisyon;
        private ComboBox cmbpersonelbilgiistasyon;
        private TextBox txtpersonelbilgisoyad;
        private TextBox txtpersonelbilgiad;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
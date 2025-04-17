namespace ShiftTracking
{
    partial class frmPersonelSil
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
            cmbsilinecekpersonel = new ComboBox();
            btnsil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 152);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "Silenecek Personeli Seçin:";
            // 
            // cmbsilinecekpersonel
            // 
            cmbsilinecekpersonel.FormattingEnabled = true;
            cmbsilinecekpersonel.Location = new Point(325, 144);
            cmbsilinecekpersonel.Name = "cmbsilinecekpersonel";
            cmbsilinecekpersonel.Size = new Size(273, 28);
            cmbsilinecekpersonel.TabIndex = 1;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(383, 232);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(151, 29);
            btnsil.TabIndex = 2;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // frmPersonelSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsil);
            Controls.Add(cmbsilinecekpersonel);
            Controls.Add(label1);
            Name = "frmPersonelSil";
            Text = "frmPersonelSil";
            Load += frmPersonelSil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbsilinecekpersonel;
        private Button btnsil;
    }
}
namespace ShiftTracking
{
    partial class frmSecenekler
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
            cmbislemler = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbislemler
            // 
            cmbislemler.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbislemler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbislemler.FormattingEnabled = true;
            cmbislemler.Location = new Point(300, 110);
            cmbislemler.Name = "cmbislemler";
            cmbislemler.Size = new Size(198, 28);
            cmbislemler.TabIndex = 0;
            cmbislemler.SelectedIndexChanged += cmbpersonelislem_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(143, 118);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "İşlem Seç:";
            // 
            // frmSecenekler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbislemler);
            Name = "frmSecenekler";
            Text = "Seçenekler";
            Load += frmSecenekler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbislemler;
        private Label label1;
    }
}
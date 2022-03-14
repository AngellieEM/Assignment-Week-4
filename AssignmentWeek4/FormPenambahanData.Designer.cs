namespace AssignmentWeek4
{
    partial class FormPenambahanData
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
            this.labelPenambahanNama = new System.Windows.Forms.Label();
            this.textBoxPenambahanNama = new System.Windows.Forms.TextBox();
            this.labelPenambahanAlamat = new System.Windows.Forms.Label();
            this.textBoxPenambahanAlamat = new System.Windows.Forms.TextBox();
            this.labelPenambahanTelp = new System.Windows.Forms.Label();
            this.textBoxPenambahanTelp = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPenambahanNama
            // 
            this.labelPenambahanNama.AutoSize = true;
            this.labelPenambahanNama.Location = new System.Drawing.Point(12, 31);
            this.labelPenambahanNama.Name = "labelPenambahanNama";
            this.labelPenambahanNama.Size = new System.Drawing.Size(53, 19);
            this.labelPenambahanNama.TabIndex = 1;
            this.labelPenambahanNama.Text = "Nama :";
            // 
            // textBoxPenambahanNama
            // 
            this.textBoxPenambahanNama.Location = new System.Drawing.Point(87, 31);
            this.textBoxPenambahanNama.Name = "textBoxPenambahanNama";
            this.textBoxPenambahanNama.Size = new System.Drawing.Size(338, 26);
            this.textBoxPenambahanNama.TabIndex = 2;
            // 
            // labelPenambahanAlamat
            // 
            this.labelPenambahanAlamat.AutoSize = true;
            this.labelPenambahanAlamat.Location = new System.Drawing.Point(12, 93);
            this.labelPenambahanAlamat.Name = "labelPenambahanAlamat";
            this.labelPenambahanAlamat.Size = new System.Drawing.Size(63, 19);
            this.labelPenambahanAlamat.TabIndex = 3;
            this.labelPenambahanAlamat.Text = "Alamat : ";
            // 
            // textBoxPenambahanAlamat
            // 
            this.textBoxPenambahanAlamat.Location = new System.Drawing.Point(87, 93);
            this.textBoxPenambahanAlamat.Name = "textBoxPenambahanAlamat";
            this.textBoxPenambahanAlamat.Size = new System.Drawing.Size(479, 26);
            this.textBoxPenambahanAlamat.TabIndex = 4;
            // 
            // labelPenambahanTelp
            // 
            this.labelPenambahanTelp.AutoSize = true;
            this.labelPenambahanTelp.Location = new System.Drawing.Point(12, 161);
            this.labelPenambahanTelp.Name = "labelPenambahanTelp";
            this.labelPenambahanTelp.Size = new System.Drawing.Size(42, 19);
            this.labelPenambahanTelp.TabIndex = 5;
            this.labelPenambahanTelp.Text = "Telp :";
            // 
            // textBoxPenambahanTelp
            // 
            this.textBoxPenambahanTelp.Location = new System.Drawing.Point(87, 161);
            this.textBoxPenambahanTelp.Name = "textBoxPenambahanTelp";
            this.textBoxPenambahanTelp.Size = new System.Drawing.Size(202, 26);
            this.textBoxPenambahanTelp.TabIndex = 6;
            this.textBoxPenambahanTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPenambahanTelp_KeyPress);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(16, 231);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 29);
            this.buttonSimpan.TabIndex = 7;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonLihatData
            // 
            this.buttonLihatData.Location = new System.Drawing.Point(121, 231);
            this.buttonLihatData.Name = "buttonLihatData";
            this.buttonLihatData.Size = new System.Drawing.Size(82, 29);
            this.buttonLihatData.TabIndex = 8;
            this.buttonLihatData.Text = "Lihat Data";
            this.buttonLihatData.UseVisualStyleBackColor = true;
            this.buttonLihatData.Click += new System.EventHandler(this.buttonLihatData_Click);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 288);
            this.Controls.Add(this.buttonLihatData);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxPenambahanTelp);
            this.Controls.Add(this.labelPenambahanTelp);
            this.Controls.Add(this.textBoxPenambahanAlamat);
            this.Controls.Add(this.labelPenambahanAlamat);
            this.Controls.Add(this.textBoxPenambahanNama);
            this.Controls.Add(this.labelPenambahanNama);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPenambahanData";
            this.Text = "FormPenambahanData";
            this.Load += new System.EventHandler(this.FormPenambahanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPenambahanNama;
        private System.Windows.Forms.TextBox textBoxPenambahanNama;
        private System.Windows.Forms.Label labelPenambahanAlamat;
        private System.Windows.Forms.TextBox textBoxPenambahanAlamat;
        private System.Windows.Forms.Label labelPenambahanTelp;
        private System.Windows.Forms.TextBox textBoxPenambahanTelp;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonLihatData;
    }
}
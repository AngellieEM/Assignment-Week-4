namespace AssignmentWeek4
{
    partial class FormTampilanData
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
            this.labelTampilanNama = new System.Windows.Forms.Label();
            this.textBoxTampilanNama = new System.Windows.Forms.TextBox();
            this.labelTampilanAlamat = new System.Windows.Forms.Label();
            this.textBoxTampilanAlamat = new System.Windows.Forms.TextBox();
            this.labelTampilanTelp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonPrevData = new System.Windows.Forms.Button();
            this.buttonNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTampilanNama
            // 
            this.labelTampilanNama.AutoSize = true;
            this.labelTampilanNama.Location = new System.Drawing.Point(12, 30);
            this.labelTampilanNama.Name = "labelTampilanNama";
            this.labelTampilanNama.Size = new System.Drawing.Size(53, 19);
            this.labelTampilanNama.TabIndex = 0;
            this.labelTampilanNama.Text = "Nama :";
            // 
            // textBoxTampilanNama
            // 
            this.textBoxTampilanNama.Location = new System.Drawing.Point(81, 30);
            this.textBoxTampilanNama.Name = "textBoxTampilanNama";
            this.textBoxTampilanNama.Size = new System.Drawing.Size(338, 26);
            this.textBoxTampilanNama.TabIndex = 1;
            // 
            // labelTampilanAlamat
            // 
            this.labelTampilanAlamat.AutoSize = true;
            this.labelTampilanAlamat.Location = new System.Drawing.Point(12, 91);
            this.labelTampilanAlamat.Name = "labelTampilanAlamat";
            this.labelTampilanAlamat.Size = new System.Drawing.Size(63, 19);
            this.labelTampilanAlamat.TabIndex = 2;
            this.labelTampilanAlamat.Text = "Alamat : ";
            // 
            // textBoxTampilanAlamat
            // 
            this.textBoxTampilanAlamat.Location = new System.Drawing.Point(81, 91);
            this.textBoxTampilanAlamat.Name = "textBoxTampilanAlamat";
            this.textBoxTampilanAlamat.Size = new System.Drawing.Size(479, 26);
            this.textBoxTampilanAlamat.TabIndex = 3;
            // 
            // labelTampilanTelp
            // 
            this.labelTampilanTelp.AutoSize = true;
            this.labelTampilanTelp.Location = new System.Drawing.Point(12, 149);
            this.labelTampilanTelp.Name = "labelTampilanTelp";
            this.labelTampilanTelp.Size = new System.Drawing.Size(42, 19);
            this.labelTampilanTelp.TabIndex = 4;
            this.labelTampilanTelp.Text = "Telp :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 5;
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(16, 230);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(75, 29);
            this.buttonKembali.TabIndex = 6;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonPrevData
            // 
            this.buttonPrevData.Location = new System.Drawing.Point(115, 230);
            this.buttonPrevData.Name = "buttonPrevData";
            this.buttonPrevData.Size = new System.Drawing.Size(83, 29);
            this.buttonPrevData.TabIndex = 7;
            this.buttonPrevData.Text = "Prev Data";
            this.buttonPrevData.UseVisualStyleBackColor = true;
            // 
            // buttonNextData
            // 
            this.buttonNextData.Location = new System.Drawing.Point(227, 230);
            this.buttonNextData.Name = "buttonNextData";
            this.buttonNextData.Size = new System.Drawing.Size(83, 29);
            this.buttonNextData.TabIndex = 8;
            this.buttonNextData.Text = "Next Data";
            this.buttonNextData.UseVisualStyleBackColor = true;
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 287);
            this.Controls.Add(this.buttonNextData);
            this.Controls.Add(this.buttonPrevData);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTampilanTelp);
            this.Controls.Add(this.textBoxTampilanAlamat);
            this.Controls.Add(this.labelTampilanAlamat);
            this.Controls.Add(this.textBoxTampilanNama);
            this.Controls.Add(this.labelTampilanNama);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTampilanData";
            this.Text = "Form Tampilan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTampilanNama;
        private System.Windows.Forms.TextBox textBoxTampilanNama;
        private System.Windows.Forms.Label labelTampilanAlamat;
        private System.Windows.Forms.TextBox textBoxTampilanAlamat;
        private System.Windows.Forms.Label labelTampilanTelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonPrevData;
        private System.Windows.Forms.Button buttonNextData;
    }
}
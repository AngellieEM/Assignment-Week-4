using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentWeek4
{
    public partial class FormPenambahanData : Form
    {
        public static FormPenambahanData instance;
        public FormPenambahanData()
        {
            InitializeComponent();
            instance = this;
        }
        public DataTable InputData = new DataTable();

        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            FormTampilanData form = new FormTampilanData();
            form.Show();
            this.Hide();
        }

        private static bool validate(char c)
        {
            int asci = Convert.ToInt32(c);
            if (asci >= 48 && asci <= 57 || asci == 13 || asci == 8)
            {
                return false; 
            }
            else
            {
                return true;
            }
        }
        
        private void textBoxPenambahanTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validate(e.KeyChar);
        }

        private void FormPenambahanData_Load(object sender, EventArgs e)
        {
            InputData.Columns.Add("Nama");
            InputData.Columns.Add("Alamat");
            InputData.Columns.Add("Telp");
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            //bisa save data tapi nda bisa masukkin ke form tampilan data 
            InputData.Rows.Add(textBoxPenambahanNama.Text, textBoxPenambahanAlamat.Text, textBoxPenambahanTelp.Text);

        }
    }
}

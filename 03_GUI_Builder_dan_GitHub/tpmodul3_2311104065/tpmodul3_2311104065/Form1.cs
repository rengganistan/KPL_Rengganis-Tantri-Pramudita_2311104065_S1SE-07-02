using System;
using System.Windows.Forms;

namespace tpmodul3_2311104065
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNama = textBox1.Text;

            if (inputNama == "Rengganis Tantri") // Ganti dengan namamu
            {
                label1.Text = "Halo " + inputNama;
            }
            else
            {
                label1.Text = "Nama tidak cocok";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Boleh dikosongkan atau dihapus jika tidak dipakai
        }
    }
}

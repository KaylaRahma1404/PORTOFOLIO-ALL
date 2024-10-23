namespace LatihanModul2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBelanja = int.Parse(txttotalbelanja.Text);
            int diskon = int.Parse(txtdiskon.Text);
            int diskonDapet = (int)((double)diskon / 100.0 * (double)totalBelanja);
            int sisaUang = totalBelanja - diskonDapet;
            txtHarga.Text = sisaUang.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

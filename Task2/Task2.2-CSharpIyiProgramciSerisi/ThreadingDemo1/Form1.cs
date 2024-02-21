namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 1 çalıştı");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı");
        }
    }
}

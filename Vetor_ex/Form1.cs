namespace Vetor_ex
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmiex1_Click(object sender, EventArgs e)
        {
            Hide();
            frmex1 ex1 = new frmex1();
            ex1.Show();
        }

        private void tsmisair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiex2_Click(object sender, EventArgs e)
        {
            Hide();
            frmex2 ex2 = new frmex2();
            ex2.Show();
        }

        private void tsmiex3_Click(object sender, EventArgs e)
        {
            Hide();
            frmex3 ex3 = new frmex3();
            ex3.Show();
        }
    }
}

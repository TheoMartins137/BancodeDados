namespace Ex_23_04
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuPessoa_Click(object sender, EventArgs e)
        {
            CadastroPessoa form = new CadastroPessoa();
            form.ShowDialog();
        }

        private void mnuCarro_Click(object sender, EventArgs e)
        {
            CadastrarCarro form = new CadastrarCarro();
            form.ShowDialog();
        }
    }
}

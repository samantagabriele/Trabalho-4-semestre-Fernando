using AppValidaRa.Control;

namespace AppValidaRa
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.AcceptButton = btnValidar;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            var controller = new Validacao();
            string resultado = controller.ValidarDados(txtRa.Text);

            lblResposta.Text = resultado; // Mostra o resultado em um label
        }
    }
}

using SWII6_Prova2_Desktop.Models;

namespace SWII6_Prova2_Desktop
{
    public partial class Form1 : Form
    {
        private readonly UsuariosService usuariosService;
        private UsuarioModel usuarioSelected;

        public Form1()
        {
            InitializeComponent();
            usuariosService = UsuariosService.getInstance();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            var usuario = new UsuarioModel()
            {
                Nome = textNome.Text,
                Senha = textSenha.Text,
                Status = radioAtivo.Checked,
            };

            if ((sender as Button).Text == "Adicionar")
            {
                usuariosService.Create(usuario);
            }
            else
            {
                usuario.Id = usuarioSelected.Id;
                usuariosService.Update(usuario);
            }
            buttonLimpar_Click(sender, e);

        }

        private async void buttonAtualizarListagem_Click(object sender, EventArgs e)
        {
            var list = await usuariosService.GetAll();
            dataGridView1.DataSource = list;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textNome.Text = "";
            textSenha.Text = "";
            radioAtivo.Checked = true;
            radioInativo.Checked = false;

            buttonAdicionar.Text = "Adicionar";
            usuarioSelected = null;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var usuarios = (List<UsuarioModel>)dataGridView1.DataSource;
            usuarioSelected = usuarios[dataGridView1.SelectedRows[0].Index];

            textNome.Text = usuarioSelected.Nome;
            textSenha.Text = usuarioSelected.Senha;
            radioAtivo.Checked = usuarioSelected.Status;
            radioInativo.Checked = !usuarioSelected.Status;

            buttonAdicionar.Text = "Salvar";
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            var usuarios = (List<UsuarioModel>)dataGridView1.DataSource;
            var usuario = usuarios[dataGridView1.SelectedRows[0].Index];

            usuariosService.Delete(usuario.Id);
        }
    }
}
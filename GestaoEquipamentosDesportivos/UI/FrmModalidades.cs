using GestaoEquipamentosDesportivos.DataAccess;
using GestaoEquipamentosDesportivos.Models;
using GestaoEquipamentosDesportivos.TextFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoEquipamentosDesportivos.TextFiles;


namespace GestaoEquipamentosDesportivos.UI
{
    public partial class FrmModalidades : Form
    {
        private readonly SqlDataAccess _dataAccess = new SqlDataAccess();
        private int _idModalidadeSelecionada = 0;

        public FrmModalidades()
        {
            InitializeComponent();
            CarregarModalidades();
            FileHelper.GuardarModalidades(_dataAccess.ListarModalidades());
        }

        private void CarregarModalidades()
        {
            dgvModalidades.DataSource = _dataAccess.ListarModalidades();
        }

        private void FrmModalidades_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show(
                    "Nome e descrição são obrigatórios.",
                    "Erro de validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            ModalidadeModel modalidade = new ModalidadeModel
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text
            };

            _dataAccess.AdicionarModalidade(modalidade);
            LimparCampos();
            CarregarModalidades();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            if (_idModalidadeSelecionada == 0)
                return;

            ModalidadeModel modalidade = new ModalidadeModel
            {
                IdModalidade = _idModalidadeSelecionada,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text
            };

            _dataAccess.AtualizarModalidade(modalidade);
            LimparCampos();
            CarregarModalidades();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_idModalidadeSelecionada == 0)
                return;

            _dataAccess.RemoverModalidade(_idModalidadeSelecionada);
            LimparCampos();
            CarregarModalidades();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            _idModalidadeSelecionada = 0;
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void dgvModalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var linha = dgvModalidades.Rows[e.RowIndex];

            _idModalidadeSelecionada = (int)linha.Cells["IdModalidade"].Value;
            txtNome.Text = linha.Cells["Nome"].Value.ToString();
            txtDescricao.Text = linha.Cells["Descricao"].Value.ToString();
        }
    }
}

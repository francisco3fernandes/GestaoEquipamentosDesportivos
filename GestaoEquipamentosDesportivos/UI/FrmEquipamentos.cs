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
    public partial class FrmEquipamentos : Form
    {
        private readonly SqlDataAccess _dataAccess = new SqlDataAccess();
        private int _idEquipamentoSelecionado = 0;
        public FrmEquipamentos()
        {
            InitializeComponent();
            CarregarEquipamentos();
            FileHelper.GuardarEquipamentos(_dataAccess.ListarEquipamentos());
        }
        private void CarregarEquipamentos()
        {
            dgvEquipamentos.DataSource = _dataAccess.ListarEquipamentos();
        }



        private void FrmEquipamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
             string.IsNullOrWhiteSpace(txtTipo.Text) ||
             string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show(
                    "Todos os campos (Nome, Tipo e Estado) são obrigatórios.",
                    "Erro de validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            EquipamentoModel equipamento = new EquipamentoModel
            {
                Nome = txtNome.Text,
                Tipo = txtTipo.Text,
                Estado = txtEstado.Text,
                DataAquisicao = dtpDataAquisicao.Value
            };

            _dataAccess.AdicionarEquipamento(equipamento);
            LimparCampos();
            CarregarEquipamentos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (_idEquipamentoSelecionado == 0)
                return;

            EquipamentoModel equipamento = new EquipamentoModel
            {
                IdEquipamento = _idEquipamentoSelecionado,
                Nome = txtNome.Text,
                Tipo = txtTipo.Text,
                Estado = txtEstado.Text,
                DataAquisicao = dtpDataAquisicao.Value
            };

            _dataAccess.AtualizarEquipamento(equipamento);
            LimparCampos();
            CarregarEquipamentos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_idEquipamentoSelecionado == 0)
                return;

            _dataAccess.RemoverEquipamento(_idEquipamentoSelecionado);
            LimparCampos();
            CarregarEquipamentos();
        }

        private void dgvEquipamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var linha = dgvEquipamentos.Rows[e.RowIndex];

            _idEquipamentoSelecionado = (int)linha.Cells["IdEquipamento"].Value;
            txtNome.Text = linha.Cells["Nome"].Value.ToString();
            txtTipo.Text = linha.Cells["Tipo"].Value.ToString();
            txtEstado.Text = linha.Cells["Estado"].Value.ToString();
            dtpDataAquisicao.Value = (DateTime)linha.Cells["DataAquisicao"].Value;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            _idEquipamentoSelecionado = 0;
            txtNome.Clear();
            txtTipo.Clear();
            txtEstado.Clear();
            dtpDataAquisicao.Value = DateTime.Now;
        }
    }
}

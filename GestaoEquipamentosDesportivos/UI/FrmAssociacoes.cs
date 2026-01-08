using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoEquipamentosDesportivos.DataAccess;
using GestaoEquipamentosDesportivos.Models;

namespace GestaoEquipamentosDesportivos.UI
{
    public partial class FrmAssociacoes : Form
    {
        private readonly SqlDataAccess _dataAccess = new SqlDataAccess();

        public FrmAssociacoes()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            cmbEquipamentos.DataSource = _dataAccess.ListarEquipamentos();
            cmbEquipamentos.DisplayMember = "Nome";
            cmbEquipamentos.ValueMember = "IdEquipamento";

            cmbModalidades.DataSource = _dataAccess.ListarModalidades();
            cmbModalidades.DisplayMember = "Nome";
            cmbModalidades.ValueMember = "IdModalidade";
        }

        private void FrmAssociacoes_Load(object sender, EventArgs e)
        {

        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {
            int idEquipamento = (int)cmbEquipamentos.SelectedValue;
            int idModalidade = (int)cmbModalidades.SelectedValue;

            _dataAccess.AssociarEquipamentoModalidade(idEquipamento, idModalidade);
            MessageBox.Show("Associação criada com sucesso.");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idEquipamento = (int)cmbEquipamentos.SelectedValue;
            int idModalidade = (int)cmbModalidades.SelectedValue;

            _dataAccess.RemoverEquipamentoModalidade(idEquipamento, idModalidade);
            MessageBox.Show("Associação removida com sucesso.");
        }
    }
}

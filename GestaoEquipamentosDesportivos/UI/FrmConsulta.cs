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
    public partial class FrmConsulta : Form
    {
        private readonly SqlDataAccess _dataAccess = new SqlDataAccess();

        public FrmConsulta()
        {
            InitializeComponent();
            CarregarModalidades();
        }

        private void CarregarModalidades()
        {
            cmbModalidades.DataSource = _dataAccess.ListarModalidades();
            cmbModalidades.DisplayMember = "Nome";
            cmbModalidades.ValueMember = "IdModalidade";
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idModalidade = (int)cmbModalidades.SelectedValue;
            dgvEquipamentos.DataSource = _dataAccess.ListarEquipamentosPorModalidade(idModalidade);
        }
    }
}

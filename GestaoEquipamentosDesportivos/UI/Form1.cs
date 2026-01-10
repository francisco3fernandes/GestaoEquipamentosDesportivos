using GestaoEquipamentosDesportivos.UI;
using System;
using System.Windows.Forms;

namespace GestaoEquipamentosDesportivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            FrmEquipamentos frm = new FrmEquipamentos();
            frm.ShowDialog();
        }

        private void btnModalidades_Click(object sender, EventArgs e)
        {
            FrmModalidades frm = new FrmModalidades();
            frm.ShowDialog();
        }

        private void btnAssociacoes_Click(object sender, EventArgs e)
        {
            FrmAssociacoes frm = new FrmAssociacoes();
            frm.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta frm = new FrmConsulta();
            frm.ShowDialog();
        }
    }
}

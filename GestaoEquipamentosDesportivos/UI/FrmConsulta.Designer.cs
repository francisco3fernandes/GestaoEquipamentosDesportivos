namespace GestaoEquipamentosDesportivos.UI
{
    partial class FrmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbModalidades = new ComboBox();
            btnConsultar = new Button();
            dgvEquipamentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).BeginInit();
            SuspendLayout();
            // 
            // cmbModalidades
            // 
            cmbModalidades.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbModalidades.FormattingEnabled = true;
            cmbModalidades.Location = new Point(12, 12);
            cmbModalidades.Name = "cmbModalidades";
            cmbModalidades.Size = new Size(151, 27);
            cmbModalidades.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(339, 412);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvEquipamentos
            // 
            dgvEquipamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamentos.Location = new Point(43, 94);
            dgvEquipamentos.Name = "dgvEquipamentos";
            dgvEquipamentos.ReadOnly = true;
            dgvEquipamentos.RowHeadersWidth = 51;
            dgvEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipamentos.Size = new Size(694, 253);
            dgvEquipamentos.TabIndex = 2;
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dgvEquipamentos);
            Controls.Add(btnConsultar);
            Controls.Add(cmbModalidades);
            Name = "FrmConsulta";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Equipamentos por Modalidade";
            Load += FrmConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbModalidades;
        private Button btnConsultar;
        private DataGridView dgvEquipamentos;
    }
}
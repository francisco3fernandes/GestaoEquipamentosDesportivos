namespace GestaoEquipamentosDesportivos.UI
{
    partial class FrmEquipamentos
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblTipo = new Label();
            txtTipo = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblData = new Label();
            dtpDataAquisicao = new DateTimePicker();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            btnRemover = new Button();
            btnLimpar = new Button();
            dgvEquipamentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(12, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(12, 103);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(45, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTipo.Location = new Point(12, 126);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(125, 27);
            txtTipo.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(12, 200);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(62, 20);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEstado.Location = new Point(12, 223);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 5;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(495, 20);
            lblData.Name = "lblData";
            lblData.Size = new Size(127, 20);
            lblData.TabIndex = 6;
            lblData.Text = "Data Aquisição";
            // 
            // dtpDataAquisicao
            // 
            dtpDataAquisicao.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpDataAquisicao.Location = new Point(495, 43);
            dtpDataAquisicao.Name = "dtpDataAquisicao";
            dtpDataAquisicao.Size = new Size(250, 27);
            dtpDataAquisicao.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(12, 406);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(220, 406);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(472, 406);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(676, 406);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvEquipamentos
            // 
            dgvEquipamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamentos.Location = new Point(182, 103);
            dgvEquipamentos.MultiSelect = false;
            dgvEquipamentos.Name = "dgvEquipamentos";
            dgvEquipamentos.ReadOnly = true;
            dgvEquipamentos.RowHeadersWidth = 51;
            dgvEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipamentos.Size = new Size(588, 255);
            dgvEquipamentos.TabIndex = 12;
            dgvEquipamentos.CellContentClick += dgvEquipamentos_CellContentClick;
            // 
            // FrmEquipamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dgvEquipamentos);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnAtualizar);
            Controls.Add(btnAdicionar);
            Controls.Add(dtpDataAquisicao);
            Controls.Add(lblData);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FrmEquipamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Equipamentos";
            Load += FrmEquipamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblTipo;
        private TextBox txtTipo;
        private Label lblEstado;
        private TextBox txtEstado;
        private Label lblData;
        private DateTimePicker dtpDataAquisicao;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnRemover;
        private Button btnLimpar;
        private DataGridView dgvEquipamentos;
    }
}
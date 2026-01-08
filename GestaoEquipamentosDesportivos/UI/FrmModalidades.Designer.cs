namespace GestaoEquipamentosDesportivos.UI
{
    partial class FrmModalidades
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
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            btnRemover = new Button();
            btnLimpar = new Button();
            dgvModalidades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvModalidades).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(12, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(12, 132);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(84, 20);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(12, 155);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 34);
            txtDescricao.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(12, 412);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(235, 412);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(458, 412);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(676, 412);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvModalidades
            // 
            dgvModalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvModalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModalidades.Location = new Point(183, 55);
            dgvModalidades.MultiSelect = false;
            dgvModalidades.Name = "dgvModalidades";
            dgvModalidades.ReadOnly = true;
            dgvModalidades.RowHeadersWidth = 51;
            dgvModalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModalidades.Size = new Size(587, 317);
            dgvModalidades.TabIndex = 8;
            dgvModalidades.CellContentClick += dgvModalidades_CellContentClick;
            // 
            // FrmModalidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dgvModalidades);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnAtualizar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FrmModalidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Modalidades ";
            Load += FrmModalidades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvModalidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnRemover;
        private Button btnLimpar;
        private DataGridView dgvModalidades;
    }
}
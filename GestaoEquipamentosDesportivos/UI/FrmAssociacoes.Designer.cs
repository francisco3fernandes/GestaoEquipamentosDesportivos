namespace GestaoEquipamentosDesportivos.UI
{
    partial class FrmAssociacoes
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
            cmbEquipamentos = new ComboBox();
            cmbModalidades = new ComboBox();
            btnAssociar = new Button();
            btnRemover = new Button();
            dgvAssociacoes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAssociacoes).BeginInit();
            SuspendLayout();
            // 
            // cmbEquipamentos
            // 
            cmbEquipamentos.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbEquipamentos.FormattingEnabled = true;
            cmbEquipamentos.Location = new Point(12, 12);
            cmbEquipamentos.Name = "cmbEquipamentos";
            cmbEquipamentos.Size = new Size(151, 27);
            cmbEquipamentos.TabIndex = 0;
            // 
            // cmbModalidades
            // 
            cmbModalidades.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbModalidades.FormattingEnabled = true;
            cmbModalidades.Location = new Point(619, 12);
            cmbModalidades.Name = "cmbModalidades";
            cmbModalidades.Size = new Size(151, 27);
            cmbModalidades.TabIndex = 1;
            // 
            // btnAssociar
            // 
            btnAssociar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssociar.Location = new Point(12, 412);
            btnAssociar.Name = "btnAssociar";
            btnAssociar.Size = new Size(94, 29);
            btnAssociar.TabIndex = 2;
            btnAssociar.Text = "Associar";
            btnAssociar.UseVisualStyleBackColor = true;
            btnAssociar.Click += btnAssociar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(557, 412);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(213, 29);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover Associação";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvAssociacoes
            // 
            dgvAssociacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssociacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociacoes.Location = new Point(12, 60);
            dgvAssociacoes.Name = "dgvAssociacoes";
            dgvAssociacoes.ReadOnly = true;
            dgvAssociacoes.RowHeadersWidth = 51;
            dgvAssociacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociacoes.Size = new Size(758, 319);
            dgvAssociacoes.TabIndex = 4;
            // 
            // FrmAssociacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(dgvAssociacoes);
            Controls.Add(btnRemover);
            Controls.Add(btnAssociar);
            Controls.Add(cmbModalidades);
            Controls.Add(cmbEquipamentos);
            Name = "FrmAssociacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Associação Equipamentos ↔ Modalidades";
            Load += FrmAssociacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAssociacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEquipamentos;
        private ComboBox cmbModalidades;
        private Button btnAssociar;
        private Button btnRemover;
        private DataGridView dgvAssociacoes;
    }
}
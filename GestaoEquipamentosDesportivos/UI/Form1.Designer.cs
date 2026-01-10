namespace GestaoEquipamentosDesportivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEquipamentos = new Button();
            btnModalidades = new Button();
            btnAssociacoes = new Button();
            btnConsulta = new Button();
            SuspendLayout();
            // 
            // btnEquipamentos
            // 
            btnEquipamentos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipamentos.Location = new Point(12, 14);
            btnEquipamentos.Name = "btnEquipamentos";
            btnEquipamentos.Size = new Size(179, 46);
            btnEquipamentos.TabIndex = 0;
            btnEquipamentos.Text = "Equipamentos";
            btnEquipamentos.UseVisualStyleBackColor = true;
            btnEquipamentos.Click += btnEquipamentos_Click;
            // 
            // btnModalidades
            // 
            btnModalidades.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModalidades.Location = new Point(12, 195);
            btnModalidades.Name = "btnModalidades";
            btnModalidades.Size = new Size(179, 46);
            btnModalidades.TabIndex = 1;
            btnModalidades.Text = "Modalidades";
            btnModalidades.UseVisualStyleBackColor = true;
            btnModalidades.Click += btnModalidades_Click;
            // 
            // btnAssociacoes
            // 
            btnAssociacoes.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssociacoes.Location = new Point(391, 12);
            btnAssociacoes.Name = "btnAssociacoes";
            btnAssociacoes.Size = new Size(179, 46);
            btnAssociacoes.TabIndex = 2;
            btnAssociacoes.Text = "Associações";
            btnAssociacoes.UseVisualStyleBackColor = true;
            btnAssociacoes.Click += btnAssociacoes_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsulta.Location = new Point(391, 195);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(179, 46);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(btnConsulta);
            Controls.Add(btnAssociacoes);
            Controls.Add(btnModalidades);
            Controls.Add(btnEquipamentos);
            Name = "Form1";
            Text = "Sistema de Gestão de Equipamentos Desportivos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEquipamentos;
        private Button btnModalidades;
        private Button btnAssociacoes;
        private Button btnConsulta;
    }
}

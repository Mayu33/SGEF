namespace SGEF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_laboratorio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_qtd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_codigodebarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tb_pesquisar = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.tb_lote = new System.Windows.Forms.TextBox();
            this.tb_validade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codigoDeBarras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(116, 93);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(719, 22);
            this.tb_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laboratório";
            // 
            // tb_laboratorio
            // 
            this.tb_laboratorio.Location = new System.Drawing.Point(25, 154);
            this.tb_laboratorio.Name = "tb_laboratorio";
            this.tb_laboratorio.Size = new System.Drawing.Size(219, 22);
            this.tb_laboratorio.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Qtd.";
            // 
            // tb_qtd
            // 
            this.tb_qtd.Location = new System.Drawing.Point(25, 93);
            this.tb_qtd.Name = "tb_qtd";
            this.tb_qtd.Size = new System.Drawing.Size(65, 22);
            this.tb_qtd.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_qtd,
            this.col_nome,
            this.col_laboratorio,
            this.col_lote,
            this.col_validade,
            this.col_codigodebarras});
            this.dataGridView1.Location = new System.Drawing.Point(25, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 456);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.Width = 35;
            // 
            // col_qtd
            // 
            this.col_qtd.HeaderText = "Qtd.";
            this.col_qtd.MinimumWidth = 6;
            this.col_qtd.Name = "col_qtd";
            this.col_qtd.Width = 50;
            // 
            // col_nome
            // 
            this.col_nome.HeaderText = "Nome";
            this.col_nome.MinimumWidth = 6;
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 350;
            // 
            // col_laboratorio
            // 
            this.col_laboratorio.HeaderText = "Laboratório";
            this.col_laboratorio.MinimumWidth = 6;
            this.col_laboratorio.Name = "col_laboratorio";
            this.col_laboratorio.Width = 140;
            // 
            // col_lote
            // 
            this.col_lote.HeaderText = "Lote";
            this.col_lote.MinimumWidth = 6;
            this.col_lote.Name = "col_lote";
            this.col_lote.Width = 105;
            // 
            // col_validade
            // 
            this.col_validade.HeaderText = "Validade";
            this.col_validade.MinimumWidth = 6;
            this.col_validade.Name = "col_validade";
            this.col_validade.Width = 105;
            // 
            // col_codigodebarras
            // 
            this.col_codigodebarras.HeaderText = "Código de Barras";
            this.col_codigodebarras.MinimumWidth = 6;
            this.col_codigodebarras.Name = "col_codigodebarras";
            this.col_codigodebarras.Width = 125;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(322, 26);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(115, 40);
            this.btn_novo.TabIndex = 55;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(457, 26);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(115, 40);
            this.btn_editar.TabIndex = 56;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(595, 26);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(115, 40);
            this.btn_excluir.TabIndex = 57;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(523, 207);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(115, 40);
            this.btn_cancelar.TabIndex = 58;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.Location = new System.Drawing.Point(170, 272);
            this.tb_pesquisar.Multiline = true;
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(551, 40);
            this.tb_pesquisar.TabIndex = 60;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(738, 272);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(115, 40);
            this.btn_pesquisar.TabIndex = 61;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // tb_lote
            // 
            this.tb_lote.Location = new System.Drawing.Point(273, 154);
            this.tb_lote.Name = "tb_lote";
            this.tb_lote.Size = new System.Drawing.Size(228, 22);
            this.tb_lote.TabIndex = 63;
            // 
            // tb_validade
            // 
            this.tb_validade.Location = new System.Drawing.Point(523, 154);
            this.tb_validade.Name = "tb_validade";
            this.tb_validade.Size = new System.Drawing.Size(241, 22);
            this.tb_validade.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Validade";
            // 
            // tb_codigoDeBarras
            // 
            this.tb_codigoDeBarras.Location = new System.Drawing.Point(788, 154);
            this.tb_codigoDeBarras.Name = "tb_codigoDeBarras";
            this.tb_codigoDeBarras.Size = new System.Drawing.Size(212, 22);
            this.tb_codigoDeBarras.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Código de Barras";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(862, 93);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(138, 22);
            this.tb_id.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(859, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Lote";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(386, 207);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(115, 40);
            this.btn_salvar.TabIndex = 71;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 822);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_codigoDeBarras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_validade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_lote);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.tb_pesquisar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_qtd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_laboratorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome);
            this.Name = "Form1";
            this.Text = "SGEF - Sistema de Gerenciamento de Estoque para Farmácias";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_laboratorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_qtd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox tb_pesquisar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox tb_lote;
        private System.Windows.Forms.TextBox tb_validade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codigoDeBarras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigodebarras;
    }
}


namespace SistemaLanchonete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnLanches = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeLanche = new System.Windows.Forms.TextBox();
            this.tabConsulta = new System.Windows.Forms.TabControl();
            this.tbCadastroLanche = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoLanche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngredienteLanche = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvExibir = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.PnLanches.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tbCadastroLanche.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibir)).BeginInit();
            this.SuspendLayout();
            // 
            // PnLanches
            // 
            this.PnLanches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnLanches.Controls.Add(this.label1);
            this.PnLanches.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLanches.Location = new System.Drawing.Point(0, 0);
            this.PnLanches.Name = "PnLanches";
            this.PnLanches.Size = new System.Drawing.Size(803, 112);
            this.PnLanches.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE LANCHES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNomeLanche
            // 
            this.txtNomeLanche.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLanche.Location = new System.Drawing.Point(418, 35);
            this.txtNomeLanche.Name = "txtNomeLanche";
            this.txtNomeLanche.Size = new System.Drawing.Size(298, 30);
            this.txtNomeLanche.TabIndex = 2;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tbCadastroLanche);
            this.tabConsulta.Controls.Add(this.tabPage2);
            this.tabConsulta.Location = new System.Drawing.Point(0, 118);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.SelectedIndex = 0;
            this.tabConsulta.Size = new System.Drawing.Size(807, 479);
            this.tabConsulta.TabIndex = 3;
            // 
            // tbCadastroLanche
            // 
            this.tbCadastroLanche.Controls.Add(this.label6);
            this.tbCadastroLanche.Controls.Add(this.txtCodigo);
            this.tbCadastroLanche.Controls.Add(this.btExcluir);
            this.tbCadastroLanche.Controls.Add(this.btEditar);
            this.tbCadastroLanche.Controls.Add(this.btCadastrar);
            this.tbCadastroLanche.Controls.Add(this.label4);
            this.tbCadastroLanche.Controls.Add(this.txtPrecoLanche);
            this.tbCadastroLanche.Controls.Add(this.label3);
            this.tbCadastroLanche.Controls.Add(this.txtIngredienteLanche);
            this.tbCadastroLanche.Controls.Add(this.label2);
            this.tbCadastroLanche.Controls.Add(this.txtNomeLanche);
            this.tbCadastroLanche.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastroLanche.Location = new System.Drawing.Point(4, 22);
            this.tbCadastroLanche.Name = "tbCadastroLanche";
            this.tbCadastroLanche.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroLanche.Size = new System.Drawing.Size(799, 453);
            this.tbCadastroLanche.TabIndex = 0;
            this.tbCadastroLanche.Text = "Cadastrar Lanche";
            this.tbCadastroLanche.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(129, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 30);
            this.txtCodigo.TabIndex = 11;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Silver;
            this.btExcluir.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(474, 393);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(107, 50);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Gray;
            this.btEditar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(338, 393);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(107, 50);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCadastrar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(203, 393);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(107, 50);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Preço:";
            // 
            // txtPrecoLanche
            // 
            this.txtPrecoLanche.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoLanche.Location = new System.Drawing.Point(114, 319);
            this.txtPrecoLanche.Name = "txtPrecoLanche";
            this.txtPrecoLanche.Size = new System.Drawing.Size(121, 30);
            this.txtPrecoLanche.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredientes:";
            // 
            // txtIngredienteLanche
            // 
            this.txtIngredienteLanche.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteLanche.Location = new System.Drawing.Point(34, 139);
            this.txtIngredienteLanche.Multiline = true;
            this.txtIngredienteLanche.Name = "txtIngredienteLanche";
            this.txtIngredienteLanche.Size = new System.Drawing.Size(682, 143);
            this.txtIngredienteLanche.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvExibir);
            this.tabPage2.Controls.Add(this.btPesquisar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtConsultar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Lanche";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvExibir
            // 
            this.dgvExibir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExibir.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExibir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvExibir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExibir.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvExibir.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExibir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExibir.ColumnHeadersHeight = 30;
            this.dgvExibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExibir.EnableHeadersVisualStyles = false;
            this.dgvExibir.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvExibir.Location = new System.Drawing.Point(28, 95);
            this.dgvExibir.Name = "dgvExibir";
            this.dgvExibir.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExibir.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExibir.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExibir.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExibir.Size = new System.Drawing.Size(753, 351);
            this.dgvExibir.TabIndex = 9;
            this.dgvExibir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExibir_CellClick);
            this.dgvExibir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExibir_CellContentClick);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Gray;
            this.btPesquisar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Location = new System.Drawing.Point(647, 27);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(134, 38);
            this.btPesquisar.TabIndex = 8;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nome:";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(228, 35);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(327, 30);
            this.txtConsultar.TabIndex = 4;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            this.txtConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultar_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 599);
            this.Controls.Add(this.tabConsulta);
            this.Controls.Add(this.PnLanches);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnLanches.ResumeLayout(false);
            this.PnLanches.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tbCadastroLanche.ResumeLayout(false);
            this.tbCadastroLanche.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnLanches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeLanche;
        private System.Windows.Forms.TabControl tabConsulta;
        private System.Windows.Forms.TabPage tbCadastroLanche;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoLanche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngredienteLanche;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvExibir;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}


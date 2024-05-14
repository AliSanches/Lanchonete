namespace SistemaLanchonete
{
    partial class FormCadPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.lbAltera = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLanche = new System.Windows.Forms.ComboBox();
            this.btBuscarLanche = new System.Windows.Forms.Button();
            this.txtValorLanche = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRemoverLanche = new SistemaLanchonete.br.lanchonete.estilo.BotaoArredondado();
            this.btAdicionarLanche = new SistemaLanchonete.br.lanchonete.estilo.BotaoArredondado();
            this.txtQuantidadeLanche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricaoLanche = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIngrediente = new System.Windows.Forms.ComboBox();
            this.btBuscarIngrediente = new System.Windows.Forms.Button();
            this.btRemoverIngrediente = new SistemaLanchonete.br.lanchonete.estilo.BotaoArredondado();
            this.btAdicionarIngrediente = new SistemaLanchonete.br.lanchonete.estilo.BotaoArredondado();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidadeIngrediente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvCarrinhoLanche = new System.Windows.Forms.DataGridView();
            this.dgvCarrinhoIngrediente = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCancelarPedido = new SistemaLanchonete.br.lanchonete.estilo.BotaoArredondado();
            this.btPagamento = new SistemaLanchonete.br.lanchonete.estilo.BotaoArredondado();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoLanche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.lbAltera);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 79);
            this.panel1.TabIndex = 154;
            // 
            // btSair
            // 
            this.btSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSair.BackgroundImage = global::SistemaLanchonete.Properties.Resources.excluir;
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Location = new System.Drawing.Point(1213, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(23, 23);
            this.btSair.TabIndex = 4;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbAltera
            // 
            this.lbAltera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAltera.AutoSize = true;
            this.lbAltera.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltera.ForeColor = System.Drawing.Color.White;
            this.lbAltera.Location = new System.Drawing.Point(461, 21);
            this.lbAltera.Name = "lbAltera";
            this.lbAltera.Size = new System.Drawing.Size(250, 33);
            this.lbAltera.TabIndex = 2;
            this.lbAltera.Text = "REALIZAR PEDIDO";
            this.lbAltera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SistemaLanchonete.Properties.Resources.CadPedido;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(31, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 59);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 141);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btBuscar.BackgroundImage = global::SistemaLanchonete.Properties.Resources.procurar;
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(200, 66);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(23, 23);
            this.btBuscar.TabIndex = 184;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(71, 30);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(123, 22);
            this.txtData.TabIndex = 183;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(15, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 18);
            this.label14.TabIndex = 182;
            this.label14.Text = "*Data:";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(71, 68);
            this.txtCpf.Mask = "###.###.###-##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(123, 21);
            this.txtCpf.TabIndex = 181;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 180;
            this.label3.Text = "*Cpf:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(161, 106);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 22);
            this.txtNome.TabIndex = 179;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 178;
            this.label2.Text = "*Nome Completo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLanche);
            this.groupBox2.Controls.Add(this.btBuscarLanche);
            this.groupBox2.Controls.Add(this.txtValorLanche);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnRemoverLanche);
            this.groupBox2.Controls.Add(this.btAdicionarLanche);
            this.groupBox2.Controls.Add(this.txtQuantidadeLanche);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDescricaoLanche);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 273);
            this.groupBox2.TabIndex = 182;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LANCHE";
            // 
            // cbLanche
            // 
            this.cbLanche.FormattingEnabled = true;
            this.cbLanche.Location = new System.Drawing.Point(116, 29);
            this.cbLanche.Name = "cbLanche";
            this.cbLanche.Size = new System.Drawing.Size(167, 26);
            this.cbLanche.TabIndex = 199;
            this.cbLanche.SelectedIndexChanged += new System.EventHandler(this.cbLanche_SelectedIndexChanged);
            // 
            // btBuscarLanche
            // 
            this.btBuscarLanche.BackColor = System.Drawing.Color.Transparent;
            this.btBuscarLanche.BackgroundImage = global::SistemaLanchonete.Properties.Resources.procurar;
            this.btBuscarLanche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarLanche.FlatAppearance.BorderSize = 0;
            this.btBuscarLanche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarLanche.Location = new System.Drawing.Point(287, 30);
            this.btBuscarLanche.Name = "btBuscarLanche";
            this.btBuscarLanche.Size = new System.Drawing.Size(23, 23);
            this.btBuscarLanche.TabIndex = 185;
            this.btBuscarLanche.UseVisualStyleBackColor = false;
            this.btBuscarLanche.Click += new System.EventHandler(this.btBuscarLanche_Click);
            // 
            // txtValorLanche
            // 
            this.txtValorLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLanche.Location = new System.Drawing.Point(117, 70);
            this.txtValorLanche.Name = "txtValorLanche";
            this.txtValorLanche.Size = new System.Drawing.Size(99, 22);
            this.txtValorLanche.TabIndex = 195;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(17, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 18);
            this.label15.TabIndex = 194;
            this.label15.Text = "Preço (R$):";
            // 
            // btnRemoverLanche
            // 
            this.btnRemoverLanche.BackColor = System.Drawing.Color.Silver;
            this.btnRemoverLanche.BackgroundColor = System.Drawing.Color.Silver;
            this.btnRemoverLanche.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoverLanche.BorderRadius = 40;
            this.btnRemoverLanche.BorderSize = 0;
            this.btnRemoverLanche.FlatAppearance.BorderSize = 0;
            this.btnRemoverLanche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverLanche.ForeColor = System.Drawing.Color.White;
            this.btnRemoverLanche.Location = new System.Drawing.Point(132, 224);
            this.btnRemoverLanche.Name = "btnRemoverLanche";
            this.btnRemoverLanche.Size = new System.Drawing.Size(106, 40);
            this.btnRemoverLanche.TabIndex = 193;
            this.btnRemoverLanche.Text = "REMOVER";
            this.btnRemoverLanche.TextColor = System.Drawing.Color.White;
            this.btnRemoverLanche.UseVisualStyleBackColor = false;
            this.btnRemoverLanche.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btAdicionarLanche
            // 
            this.btAdicionarLanche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btAdicionarLanche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btAdicionarLanche.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAdicionarLanche.BorderRadius = 40;
            this.btAdicionarLanche.BorderSize = 0;
            this.btAdicionarLanche.FlatAppearance.BorderSize = 0;
            this.btAdicionarLanche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btAdicionarLanche.ForeColor = System.Drawing.Color.White;
            this.btAdicionarLanche.Location = new System.Drawing.Point(255, 224);
            this.btAdicionarLanche.Name = "btAdicionarLanche";
            this.btAdicionarLanche.Size = new System.Drawing.Size(102, 40);
            this.btAdicionarLanche.TabIndex = 192;
            this.btAdicionarLanche.Text = "ADICIONAR";
            this.btAdicionarLanche.TextColor = System.Drawing.Color.White;
            this.btAdicionarLanche.UseVisualStyleBackColor = false;
            this.btAdicionarLanche.Click += new System.EventHandler(this.btAdicionarLanche_Click);
            // 
            // txtQuantidadeLanche
            // 
            this.txtQuantidadeLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeLanche.Location = new System.Drawing.Point(116, 194);
            this.txtQuantidadeLanche.Name = "txtQuantidadeLanche";
            this.txtQuantidadeLanche.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidadeLanche.TabIndex = 190;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 189;
            this.label6.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 187;
            this.label1.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 185;
            this.label5.Text = "Lanche:";
            // 
            // txtDescricaoLanche
            // 
            this.txtDescricaoLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoLanche.Location = new System.Drawing.Point(117, 105);
            this.txtDescricaoLanche.Multiline = true;
            this.txtDescricaoLanche.Name = "txtDescricaoLanche";
            this.txtDescricaoLanche.Size = new System.Drawing.Size(356, 73);
            this.txtDescricaoLanche.TabIndex = 188;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbIngrediente);
            this.groupBox3.Controls.Add(this.btBuscarIngrediente);
            this.groupBox3.Controls.Add(this.btRemoverIngrediente);
            this.groupBox3.Controls.Add(this.btAdicionarIngrediente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtQuantidadeIngrediente);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(31, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 197);
            this.groupBox3.TabIndex = 191;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INGREDIENTES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 198;
            this.label8.Text = "Ingredientes:";
            // 
            // cbIngrediente
            // 
            this.cbIngrediente.FormattingEnabled = true;
            this.cbIngrediente.Location = new System.Drawing.Point(132, 55);
            this.cbIngrediente.Name = "cbIngrediente";
            this.cbIngrediente.Size = new System.Drawing.Size(167, 26);
            this.cbIngrediente.TabIndex = 197;
            this.cbIngrediente.SelectedIndexChanged += new System.EventHandler(this.cbIngrediente_SelectedIndexChanged);
            // 
            // btBuscarIngrediente
            // 
            this.btBuscarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btBuscarIngrediente.BackgroundImage = global::SistemaLanchonete.Properties.Resources.procurar;
            this.btBuscarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscarIngrediente.FlatAppearance.BorderSize = 0;
            this.btBuscarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarIngrediente.Location = new System.Drawing.Point(305, 58);
            this.btBuscarIngrediente.Name = "btBuscarIngrediente";
            this.btBuscarIngrediente.Size = new System.Drawing.Size(23, 23);
            this.btBuscarIngrediente.TabIndex = 196;
            this.btBuscarIngrediente.UseVisualStyleBackColor = false;
            this.btBuscarIngrediente.Click += new System.EventHandler(this.btBuscarIngrediente_Click);
            // 
            // btRemoverIngrediente
            // 
            this.btRemoverIngrediente.BackColor = System.Drawing.Color.Silver;
            this.btRemoverIngrediente.BackgroundColor = System.Drawing.Color.Silver;
            this.btRemoverIngrediente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btRemoverIngrediente.BorderRadius = 40;
            this.btRemoverIngrediente.BorderSize = 0;
            this.btRemoverIngrediente.FlatAppearance.BorderSize = 0;
            this.btRemoverIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoverIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverIngrediente.ForeColor = System.Drawing.Color.White;
            this.btRemoverIngrediente.Location = new System.Drawing.Point(132, 143);
            this.btRemoverIngrediente.Name = "btRemoverIngrediente";
            this.btRemoverIngrediente.Size = new System.Drawing.Size(106, 40);
            this.btRemoverIngrediente.TabIndex = 195;
            this.btRemoverIngrediente.Text = "REMOVER";
            this.btRemoverIngrediente.TextColor = System.Drawing.Color.White;
            this.btRemoverIngrediente.UseVisualStyleBackColor = false;
            this.btRemoverIngrediente.Click += new System.EventHandler(this.btRemoverIngrediente_Click);
            // 
            // btAdicionarIngrediente
            // 
            this.btAdicionarIngrediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btAdicionarIngrediente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btAdicionarIngrediente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAdicionarIngrediente.BorderRadius = 40;
            this.btAdicionarIngrediente.BorderSize = 0;
            this.btAdicionarIngrediente.FlatAppearance.BorderSize = 0;
            this.btAdicionarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btAdicionarIngrediente.ForeColor = System.Drawing.Color.White;
            this.btAdicionarIngrediente.Location = new System.Drawing.Point(255, 143);
            this.btAdicionarIngrediente.Name = "btAdicionarIngrediente";
            this.btAdicionarIngrediente.Size = new System.Drawing.Size(102, 40);
            this.btAdicionarIngrediente.TabIndex = 194;
            this.btAdicionarIngrediente.Text = "ADICIONAR";
            this.btAdicionarIngrediente.TextColor = System.Drawing.Color.White;
            this.btAdicionarIngrediente.UseVisualStyleBackColor = false;
            this.btAdicionarIngrediente.Click += new System.EventHandler(this.btAdicionarIngrediente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 85;
            this.label7.Text = "Quantidade:";
            // 
            // txtQuantidadeIngrediente
            // 
            this.txtQuantidadeIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeIngrediente.Location = new System.Drawing.Point(131, 109);
            this.txtQuantidadeIngrediente.Name = "txtQuantidadeIngrediente";
            this.txtQuantidadeIngrediente.Size = new System.Drawing.Size(168, 22);
            this.txtQuantidadeIngrediente.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(540, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 194;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(578, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 18);
            this.label11.TabIndex = 194;
            this.label11.Text = "LANCHES";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(578, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 196;
            this.label12.Text = "INGREDIENTES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(566, 732);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 18);
            this.label13.TabIndex = 196;
            this.label13.Text = "Total (R$):";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(661, 731);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(128, 22);
            this.txtTotal.TabIndex = 197;
            // 
            // dgvCarrinhoLanche
            // 
            this.dgvCarrinhoLanche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrinhoLanche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            this.dgvCarrinhoLanche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrinhoLanche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCarrinhoLanche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrinhoLanche.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCarrinhoLanche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.dgvCarrinhoLanche.Location = new System.Drawing.Point(543, 128);
            this.dgvCarrinhoLanche.Name = "dgvCarrinhoLanche";
            this.dgvCarrinhoLanche.RowHeadersVisible = false;
            this.dgvCarrinhoLanche.Size = new System.Drawing.Size(620, 387);
            this.dgvCarrinhoLanche.TabIndex = 198;
            this.dgvCarrinhoLanche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinhoLanche_CellContentClick);
            // 
            // dgvCarrinhoIngrediente
            // 
            this.dgvCarrinhoIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrinhoIngrediente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            this.dgvCarrinhoIngrediente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrinhoIngrediente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCarrinhoIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrinhoIngrediente.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCarrinhoIngrediente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.dgvCarrinhoIngrediente.Location = new System.Drawing.Point(543, 562);
            this.dgvCarrinhoIngrediente.Name = "dgvCarrinhoIngrediente";
            this.dgvCarrinhoIngrediente.RowHeadersVisible = false;
            this.dgvCarrinhoIngrediente.Size = new System.Drawing.Size(620, 155);
            this.dgvCarrinhoIngrediente.TabIndex = 199;
            this.dgvCarrinhoIngrediente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinhoIngrediente_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SistemaLanchonete.Properties.Resources.AdCarrinho;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(543, 523);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 27);
            this.panel4.TabIndex = 195;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SistemaLanchonete.Properties.Resources.AdCarrinho;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(543, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 27);
            this.panel3.TabIndex = 2;
            // 
            // btCancelarPedido
            // 
            this.btCancelarPedido.BackColor = System.Drawing.Color.Silver;
            this.btCancelarPedido.BackgroundColor = System.Drawing.Color.Silver;
            this.btCancelarPedido.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btCancelarPedido.BorderRadius = 40;
            this.btCancelarPedido.BorderSize = 0;
            this.btCancelarPedido.FlatAppearance.BorderSize = 0;
            this.btCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarPedido.ForeColor = System.Drawing.Color.White;
            this.btCancelarPedido.Location = new System.Drawing.Point(845, 722);
            this.btCancelarPedido.Name = "btCancelarPedido";
            this.btCancelarPedido.Size = new System.Drawing.Size(113, 40);
            this.btCancelarPedido.TabIndex = 195;
            this.btCancelarPedido.Text = "CANCELAR";
            this.btCancelarPedido.TextColor = System.Drawing.Color.White;
            this.btCancelarPedido.UseVisualStyleBackColor = false;
            // 
            // btPagamento
            // 
            this.btPagamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btPagamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btPagamento.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btPagamento.BorderRadius = 40;
            this.btPagamento.BorderSize = 0;
            this.btPagamento.FlatAppearance.BorderSize = 0;
            this.btPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btPagamento.ForeColor = System.Drawing.Color.White;
            this.btPagamento.Location = new System.Drawing.Point(1005, 722);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(113, 40);
            this.btPagamento.TabIndex = 194;
            this.btPagamento.Text = "PAGAMENTO";
            this.btPagamento.TextColor = System.Drawing.Color.White;
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // FormCadPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 777);
            this.Controls.Add(this.dgvCarrinhoIngrediente);
            this.Controls.Add(this.dgvCarrinhoLanche);
            this.Controls.Add(this.btCancelarPedido);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadPedido";
            this.Load += new System.EventHandler(this.FormCadPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoLanche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoIngrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAltera;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuantidadeLanche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricaoLanche;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidadeIngrediente;
        private br.lanchonete.estilo.BotaoArredondado btnRemoverLanche;
        private br.lanchonete.estilo.BotaoArredondado btAdicionarLanche;
        private br.lanchonete.estilo.BotaoArredondado btRemoverIngrediente;
        private br.lanchonete.estilo.BotaoArredondado btAdicionarIngrediente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private br.lanchonete.estilo.BotaoArredondado btCancelarPedido;
        private br.lanchonete.estilo.BotaoArredondado btPagamento;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtValorLanche;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btBuscarLanche;
        private System.Windows.Forms.DataGridView dgvCarrinhoLanche;
        private System.Windows.Forms.Button btBuscarIngrediente;
        private System.Windows.Forms.DataGridView dgvCarrinhoIngrediente;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbIngrediente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLanche;
    }
}
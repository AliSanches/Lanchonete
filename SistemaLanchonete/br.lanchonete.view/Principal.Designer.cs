namespace SistemaLanchonete.br.lanchonete.view
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAltera = new System.Windows.Forms.Label();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btHome = new System.Windows.Forms.Button();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btLanche = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.btPedido = new System.Windows.Forms.Button();
            this.btUsuario = new System.Windows.Forms.Button();
            this.pnExibicao = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnExibicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.lbAltera);
            this.panel1.Controls.Add(this.btMinimizar);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 69);
            this.panel1.TabIndex = 0;
            // 
            // lbAltera
            // 
            this.lbAltera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAltera.AutoSize = true;
            this.lbAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltera.ForeColor = System.Drawing.Color.White;
            this.lbAltera.Location = new System.Drawing.Point(687, 14);
            this.lbAltera.Name = "lbAltera";
            this.lbAltera.Size = new System.Drawing.Size(106, 33);
            this.lbAltera.TabIndex = 1;
            this.lbAltera.Text = "HOME";
            this.lbAltera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMinimizar.BackgroundImage = global::SistemaLanchonete.Properties.Resources.remover;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(1273, 3);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(24, 23);
            this.btMinimizar.TabIndex = 4;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSair.BackgroundImage = global::SistemaLanchonete.Properties.Resources.excluir;
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Location = new System.Drawing.Point(1303, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(23, 23);
            this.btSair.TabIndex = 3;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 69);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buck\'s Burgers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            this.flowLayoutPanel1.Controls.Add(this.btHome);
            this.flowLayoutPanel1.Controls.Add(this.btEstoque);
            this.flowLayoutPanel1.Controls.Add(this.btLanche);
            this.flowLayoutPanel1.Controls.Add(this.btCliente);
            this.flowLayoutPanel1.Controls.Add(this.btPedido);
            this.flowLayoutPanel1.Controls.Add(this.btUsuario);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 649);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btHome
            // 
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = global::SistemaLanchonete.Properties.Resources.Home;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(3, 3);
            this.btHome.Name = "btHome";
            this.btHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHome.Size = new System.Drawing.Size(197, 46);
            this.btHome.TabIndex = 6;
            this.btHome.Text = "   Home";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btEstoque
            // 
            this.btEstoque.FlatAppearance.BorderSize = 0;
            this.btEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btEstoque.ForeColor = System.Drawing.Color.White;
            this.btEstoque.Image = global::SistemaLanchonete.Properties.Resources._62941cardfilebox_109271;
            this.btEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEstoque.Location = new System.Drawing.Point(3, 55);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btEstoque.Size = new System.Drawing.Size(197, 46);
            this.btEstoque.TabIndex = 2;
            this.btEstoque.Text = "   Estoque";
            this.btEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEstoque.UseVisualStyleBackColor = true;
            this.btEstoque.Click += new System.EventHandler(this.btEstoque_Click);
            // 
            // btLanche
            // 
            this.btLanche.FlatAppearance.BorderSize = 0;
            this.btLanche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLanche.ForeColor = System.Drawing.Color.White;
            this.btLanche.Image = global::SistemaLanchonete.Properties.Resources.menu_book_food_drink_icon_146855;
            this.btLanche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLanche.Location = new System.Drawing.Point(3, 107);
            this.btLanche.Name = "btLanche";
            this.btLanche.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btLanche.Size = new System.Drawing.Size(197, 46);
            this.btLanche.TabIndex = 3;
            this.btLanche.Text = "   Lanches";
            this.btLanche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLanche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLanche.UseVisualStyleBackColor = true;
            this.btLanche.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCliente
            // 
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btCliente.ForeColor = System.Drawing.Color.White;
            this.btCliente.Image = global::SistemaLanchonete.Properties.Resources.choose_2_102347;
            this.btCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.Location = new System.Drawing.Point(3, 159);
            this.btCliente.Name = "btCliente";
            this.btCliente.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btCliente.Size = new System.Drawing.Size(197, 46);
            this.btCliente.TabIndex = 4;
            this.btCliente.Text = "   Clientes";
            this.btCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // btPedido
            // 
            this.btPedido.FlatAppearance.BorderSize = 0;
            this.btPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPedido.ForeColor = System.Drawing.Color.White;
            this.btPedido.Image = global::SistemaLanchonete.Properties.Resources.Pedido2;
            this.btPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPedido.Location = new System.Drawing.Point(3, 211);
            this.btPedido.Name = "btPedido";
            this.btPedido.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btPedido.Size = new System.Drawing.Size(197, 46);
            this.btPedido.TabIndex = 7;
            this.btPedido.Text = "   Pedido";
            this.btPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPedido.UseVisualStyleBackColor = true;
            this.btPedido.Click += new System.EventHandler(this.btPedido_Click);
            // 
            // btUsuario
            // 
            this.btUsuario.FlatAppearance.BorderSize = 0;
            this.btUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btUsuario.ForeColor = System.Drawing.Color.White;
            this.btUsuario.Image = global::SistemaLanchonete.Properties.Resources.systemusers_94754;
            this.btUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuario.Location = new System.Drawing.Point(3, 263);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btUsuario.Size = new System.Drawing.Size(197, 46);
            this.btUsuario.TabIndex = 5;
            this.btUsuario.Text = "   Funcionarios";
            this.btUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // pnExibicao
            // 
            this.pnExibicao.Controls.Add(this.pLogo);
            this.pnExibicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnExibicao.Location = new System.Drawing.Point(200, 69);
            this.pnExibicao.Name = "pnExibicao";
            this.pnExibicao.Size = new System.Drawing.Size(1129, 649);
            this.pnExibicao.TabIndex = 2;
            this.pnExibicao.Paint += new System.Windows.Forms.PaintEventHandler(this.pnExibicao_Paint);
            // 
            // pLogo
            // 
            this.pLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pLogo.BackgroundImage = global::SistemaLanchonete.Properties.Resources.Lanche_removebg_preview;
            this.pLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pLogo.Location = new System.Drawing.Point(302, 75);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(510, 535);
            this.pLogo.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 718);
            this.Controls.Add(this.pnExibicao);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnExibicao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btLanche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnExibicao;
        private System.Windows.Forms.Label lbAltera;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btEstoque;
        public System.Windows.Forms.Button btCliente;
        public System.Windows.Forms.Button btUsuario;
        public System.Windows.Forms.Button btPedido;
    }
}
namespace SistemaLanchonete
{
    partial class FormPedido
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
            this.lbAltera = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAltera
            // 
            this.lbAltera.AutoSize = true;
            this.lbAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbAltera.ForeColor = System.Drawing.Color.Black;
            this.lbAltera.Location = new System.Drawing.Point(582, 28);
            this.lbAltera.Name = "lbAltera";
            this.lbAltera.Size = new System.Drawing.Size(205, 25);
            this.lbAltera.TabIndex = 46;
            this.lbAltera.Text = "Pesquisar Usuário";
            this.lbAltera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(587, 72);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(397, 26);
            this.txtPesquisa.TabIndex = 45;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btBuscar.BackgroundImage = global::SistemaLanchonete.Properties.Resources.procurar;
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(990, 72);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(32, 30);
            this.btBuscar.TabIndex = 48;
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btAtualizar.BackgroundImage = global::SistemaLanchonete.Properties.Resources.Atualiza;
            this.btAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAtualizar.FlatAppearance.BorderSize = 0;
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Location = new System.Drawing.Point(1043, 62);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(52, 49);
            this.btAtualizar.TabIndex = 47;
            this.btAtualizar.UseVisualStyleBackColor = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btAdicionar.BackgroundImage = global::SistemaLanchonete.Properties.Resources.AdicionarVermelho;
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Location = new System.Drawing.Point(33, 60);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(53, 53);
            this.btAdicionar.TabIndex = 44;
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 669);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.lbAltera);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPedido";
            this.Text = "FormPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label lbAltera;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btAdicionar;
    }
}
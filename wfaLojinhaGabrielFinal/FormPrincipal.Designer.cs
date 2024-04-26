namespace wfaLojinhaGabrielFinal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelRelatorio = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btRelataVendas = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btRelataEstoque = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btColecoes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btVendas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btProdutos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panelLateral.Controls.Add(this.panelRelatorio);
            this.panelLateral.Controls.Add(this.panel6);
            this.panelLateral.Controls.Add(this.btRelatorio);
            this.panelLateral.Controls.Add(this.panel5);
            this.panelLateral.Controls.Add(this.btColecoes);
            this.panelLateral.Controls.Add(this.panel4);
            this.panelLateral.Controls.Add(this.btVendas);
            this.panelLateral.Controls.Add(this.panel3);
            this.panelLateral.Controls.Add(this.btProdutos);
            this.panelLateral.Controls.Add(this.panel2);
            this.panelLateral.Controls.Add(this.btClientes);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.btHome);
            this.panelLateral.Controls.Add(this.pbLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(223, 681);
            this.panelLateral.TabIndex = 0;
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.Controls.Add(this.panel10);
            this.panelRelatorio.Controls.Add(this.btRelataVendas);
            this.panelRelatorio.Controls.Add(this.panel9);
            this.panelRelatorio.Controls.Add(this.btRelataEstoque);
            this.panelRelatorio.Location = new System.Drawing.Point(29, 404);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.Size = new System.Drawing.Size(194, 67);
            this.panelRelatorio.TabIndex = 12;
            this.panelRelatorio.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel10.Location = new System.Drawing.Point(0, 36);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 30);
            this.panel10.TabIndex = 18;
            // 
            // btRelataVendas
            // 
            this.btRelataVendas.FlatAppearance.BorderSize = 0;
            this.btRelataVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btRelataVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btRelataVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelataVendas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelataVendas.ForeColor = System.Drawing.Color.White;
            this.btRelataVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelataVendas.Location = new System.Drawing.Point(0, 36);
            this.btRelataVendas.Name = "btRelataVendas";
            this.btRelataVendas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btRelataVendas.Size = new System.Drawing.Size(194, 30);
            this.btRelataVendas.TabIndex = 17;
            this.btRelataVendas.Text = "Relatório de Vendas";
            this.btRelataVendas.UseVisualStyleBackColor = true;
            this.btRelataVendas.Click += new System.EventHandler(this.btRelataVendas_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 30);
            this.panel9.TabIndex = 16;
            // 
            // btRelataEstoque
            // 
            this.btRelataEstoque.FlatAppearance.BorderSize = 0;
            this.btRelataEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btRelataEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btRelataEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelataEstoque.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelataEstoque.ForeColor = System.Drawing.Color.White;
            this.btRelataEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelataEstoque.Location = new System.Drawing.Point(0, 0);
            this.btRelataEstoque.Name = "btRelataEstoque";
            this.btRelataEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btRelataEstoque.Size = new System.Drawing.Size(194, 30);
            this.btRelataEstoque.TabIndex = 15;
            this.btRelataEstoque.Text = "Relatório de Estoque";
            this.btRelataEstoque.UseVisualStyleBackColor = true;
            this.btRelataEstoque.Click += new System.EventHandler(this.btRelataEstoque_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(0, 359);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 39);
            this.panel6.TabIndex = 11;
            this.panel6.Visible = false;
            // 
            // btRelatorio
            // 
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorio.ForeColor = System.Drawing.Color.White;
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.Location = new System.Drawing.Point(0, 359);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btRelatorio.Size = new System.Drawing.Size(223, 39);
            this.btRelatorio.TabIndex = 10;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Visible = false;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(0, 224);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 39);
            this.panel5.TabIndex = 9;
            // 
            // btColecoes
            // 
            this.btColecoes.FlatAppearance.BorderSize = 0;
            this.btColecoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btColecoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btColecoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btColecoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btColecoes.ForeColor = System.Drawing.Color.White;
            this.btColecoes.Image = ((System.Drawing.Image)(resources.GetObject("btColecoes.Image")));
            this.btColecoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btColecoes.Location = new System.Drawing.Point(0, 224);
            this.btColecoes.Name = "btColecoes";
            this.btColecoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btColecoes.Size = new System.Drawing.Size(223, 39);
            this.btColecoes.TabIndex = 8;
            this.btColecoes.Text = "Coleções";
            this.btColecoes.UseVisualStyleBackColor = true;
            this.btColecoes.Click += new System.EventHandler(this.btColecoes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(0, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 39);
            this.panel4.TabIndex = 7;
            // 
            // btVendas
            // 
            this.btVendas.FlatAppearance.BorderSize = 0;
            this.btVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVendas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVendas.ForeColor = System.Drawing.Color.White;
            this.btVendas.Image = ((System.Drawing.Image)(resources.GetObject("btVendas.Image")));
            this.btVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVendas.Location = new System.Drawing.Point(0, 314);
            this.btVendas.Name = "btVendas";
            this.btVendas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btVendas.Size = new System.Drawing.Size(223, 39);
            this.btVendas.TabIndex = 6;
            this.btVendas.Text = "Vendas";
            this.btVendas.UseVisualStyleBackColor = true;
            this.btVendas.Click += new System.EventHandler(this.btVendas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(0, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 39);
            this.panel3.TabIndex = 5;
            // 
            // btProdutos
            // 
            this.btProdutos.FlatAppearance.BorderSize = 0;
            this.btProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProdutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProdutos.ForeColor = System.Drawing.Color.White;
            this.btProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btProdutos.Image")));
            this.btProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProdutos.Location = new System.Drawing.Point(0, 269);
            this.btProdutos.Name = "btProdutos";
            this.btProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btProdutos.Size = new System.Drawing.Size(223, 39);
            this.btProdutos.TabIndex = 4;
            this.btProdutos.Text = "Produtos";
            this.btProdutos.UseVisualStyleBackColor = true;
            this.btProdutos.Click += new System.EventHandler(this.btProdutos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 39);
            this.panel2.TabIndex = 3;
            // 
            // btClientes
            // 
            this.btClientes.FlatAppearance.BorderSize = 0;
            this.btClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientes.ForeColor = System.Drawing.Color.White;
            this.btClientes.Image = ((System.Drawing.Image)(resources.GetObject("btClientes.Image")));
            this.btClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClientes.Location = new System.Drawing.Point(0, 179);
            this.btClientes.Name = "btClientes";
            this.btClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btClientes.Size = new System.Drawing.Size(223, 39);
            this.btClientes.TabIndex = 2;
            this.btClientes.Text = "Clientes";
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 39);
            this.panel1.TabIndex = 1;
            // 
            // btHome
            // 
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 134);
            this.btHome.Name = "btHome";
            this.btHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btHome.Size = new System.Drawing.Size(223, 39);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Início";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(223, 112);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.White;
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(223, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1041, 681);
            this.panelForms.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelLateral);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.panelLateral.ResumeLayout(false);
            this.panelRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btVendas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btProdutos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btColecoes;
        private System.Windows.Forms.Panel panelRelatorio;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btRelataVendas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btRelataEstoque;
    }
}


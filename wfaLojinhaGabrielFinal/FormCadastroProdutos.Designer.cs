namespace wfaLojinhaGabrielFinal
{
    partial class FormCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProdutos));
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.tbIdProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarProduto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPrecoCusto = new System.Windows.Forms.TextBox();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbColecao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(205, 142);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(321, 24);
            this.tbQtd.TabIndex = 24;
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(205, 67);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(321, 24);
            this.tbNomeProduto.TabIndex = 22;
            // 
            // tbIdProduto
            // 
            this.tbIdProduto.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdProduto.Enabled = false;
            this.tbIdProduto.Location = new System.Drawing.Point(205, 30);
            this.tbIdProduto.Name = "tbIdProduto";
            this.tbIdProduto.Size = new System.Drawing.Size(321, 24);
            this.tbIdProduto.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Preço de Custo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Coleção:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // btCadastrarProduto
            // 
            this.btCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarProduto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btCadastrarProduto.Location = new System.Drawing.Point(322, 366);
            this.btCadastrarProduto.Name = "btCadastrarProduto";
            this.btCadastrarProduto.Size = new System.Drawing.Size(204, 40);
            this.btCadastrarProduto.TabIndex = 15;
            this.btCadastrarProduto.Text = "Cadastrar";
            this.btCadastrarProduto.UseVisualStyleBackColor = false;
            this.btCadastrarProduto.Click += new System.EventHandler(this.btCadastrarProduto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tbPrecoCusto
            // 
            this.tbPrecoCusto.Location = new System.Drawing.Point(205, 179);
            this.tbPrecoCusto.Name = "tbPrecoCusto";
            this.tbPrecoCusto.Size = new System.Drawing.Size(321, 24);
            this.tbPrecoCusto.TabIndex = 25;
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Location = new System.Drawing.Point(205, 216);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(321, 24);
            this.tbPrecoVenda.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Preço de Venda:";
            // 
            // cbColecao
            // 
            this.cbColecao.BackColor = System.Drawing.Color.White;
            this.cbColecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColecao.FormattingEnabled = true;
            this.cbColecao.Location = new System.Drawing.Point(205, 104);
            this.cbColecao.Name = "cbColecao";
            this.cbColecao.Size = new System.Drawing.Size(320, 25);
            this.cbColecao.TabIndex = 28;
            // 
            // FormCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 495);
            this.Controls.Add(this.cbColecao);
            this.Controls.Add(this.tbPrecoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrecoCusto);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.tbIdProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarProduto);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.TextBox tbIdProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPrecoCusto;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbColecao;
    }
}
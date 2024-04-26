namespace wfaLojinhaGabrielFinal
{
    partial class FormRelataEstoque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFiltrarEstoque = new System.Windows.Forms.Button();
            this.checkMaior50 = new System.Windows.Forms.CheckBox();
            this.checkAte50 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltroColecao = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbQtdProdutos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Relatório de Estoque";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFiltrarEstoque);
            this.groupBox1.Controls.Add(this.checkMaior50);
            this.groupBox1.Controls.Add(this.checkAte50);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFiltroColecao);
            this.groupBox1.Location = new System.Drawing.Point(41, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Filtro";
            // 
            // btFiltrarEstoque
            // 
            this.btFiltrarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btFiltrarEstoque.FlatAppearance.BorderSize = 0;
            this.btFiltrarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltrarEstoque.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltrarEstoque.ForeColor = System.Drawing.Color.White;
            this.btFiltrarEstoque.Location = new System.Drawing.Point(83, 103);
            this.btFiltrarEstoque.Name = "btFiltrarEstoque";
            this.btFiltrarEstoque.Size = new System.Drawing.Size(181, 27);
            this.btFiltrarEstoque.TabIndex = 8;
            this.btFiltrarEstoque.Text = "Filtrar";
            this.btFiltrarEstoque.UseVisualStyleBackColor = false;
            // 
            // checkMaior50
            // 
            this.checkMaior50.AutoSize = true;
            this.checkMaior50.Location = new System.Drawing.Point(236, 66);
            this.checkMaior50.Name = "checkMaior50";
            this.checkMaior50.Size = new System.Drawing.Size(119, 23);
            this.checkMaior50.TabIndex = 10;
            this.checkMaior50.Text = "maior que 50";
            this.checkMaior50.UseVisualStyleBackColor = true;
            // 
            // checkAte50
            // 
            this.checkAte50.AutoSize = true;
            this.checkAte50.Location = new System.Drawing.Point(144, 66);
            this.checkAte50.Name = "checkAte50";
            this.checkAte50.Size = new System.Drawing.Size(72, 23);
            this.checkAte50.TabIndex = 9;
            this.checkAte50.Text = "até 50";
            this.checkAte50.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor de Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coleção:";
            // 
            // cbFiltroColecao
            // 
            this.cbFiltroColecao.FormattingEnabled = true;
            this.cbFiltroColecao.Location = new System.Drawing.Point(144, 26);
            this.cbFiltroColecao.Name = "cbFiltroColecao";
            this.cbFiltroColecao.Size = new System.Drawing.Size(211, 25);
            this.cbFiltroColecao.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbQtdProdutos);
            this.groupBox2.Location = new System.Drawing.Point(644, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 141);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantidade de Produtos";
            // 
            // tbQtdProdutos
            // 
            this.tbQtdProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQtdProdutos.Enabled = false;
            this.tbQtdProdutos.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.tbQtdProdutos.Location = new System.Drawing.Point(85, 55);
            this.tbQtdProdutos.Name = "tbQtdProdutos";
            this.tbQtdProdutos.Size = new System.Drawing.Size(198, 30);
            this.tbQtdProdutos.TabIndex = 0;
            // 
            // FormRelataEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelataEstoque";
            this.Text = "FormRelataEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkMaior50;
        private System.Windows.Forms.CheckBox checkAte50;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltroColecao;
        private System.Windows.Forms.Button btFiltrarEstoque;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbQtdProdutos;
    }
}
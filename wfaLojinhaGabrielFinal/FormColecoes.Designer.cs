namespace wfaLojinhaGabrielFinal
{
    partial class FormColecoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoverColecao = new System.Windows.Forms.Button();
            this.btAtualizarColecao = new System.Windows.Forms.Button();
            this.btCadastrarColecao = new System.Windows.Forms.Button();
            this.dgvColecoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColecoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(364, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gerenciamento de Coleções";
            // 
            // btRemoverColecao
            // 
            this.btRemoverColecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btRemoverColecao.FlatAppearance.BorderSize = 0;
            this.btRemoverColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoverColecao.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverColecao.ForeColor = System.Drawing.Color.White;
            this.btRemoverColecao.Location = new System.Drawing.Point(645, 619);
            this.btRemoverColecao.Name = "btRemoverColecao";
            this.btRemoverColecao.Size = new System.Drawing.Size(204, 40);
            this.btRemoverColecao.TabIndex = 10;
            this.btRemoverColecao.Text = "Excluir";
            this.btRemoverColecao.UseVisualStyleBackColor = false;
            this.btRemoverColecao.Click += new System.EventHandler(this.btRemoverColecao_Click);
            // 
            // btAtualizarColecao
            // 
            this.btAtualizarColecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btAtualizarColecao.FlatAppearance.BorderSize = 0;
            this.btAtualizarColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarColecao.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarColecao.ForeColor = System.Drawing.Color.White;
            this.btAtualizarColecao.Location = new System.Drawing.Point(401, 619);
            this.btAtualizarColecao.Name = "btAtualizarColecao";
            this.btAtualizarColecao.Size = new System.Drawing.Size(204, 40);
            this.btAtualizarColecao.TabIndex = 9;
            this.btAtualizarColecao.Text = "Editar";
            this.btAtualizarColecao.UseVisualStyleBackColor = false;
            this.btAtualizarColecao.Click += new System.EventHandler(this.btAtualizarColecao_Click);
            // 
            // btCadastrarColecao
            // 
            this.btCadastrarColecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btCadastrarColecao.FlatAppearance.BorderSize = 0;
            this.btCadastrarColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarColecao.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarColecao.ForeColor = System.Drawing.Color.White;
            this.btCadastrarColecao.Location = new System.Drawing.Point(156, 619);
            this.btCadastrarColecao.Name = "btCadastrarColecao";
            this.btCadastrarColecao.Size = new System.Drawing.Size(204, 40);
            this.btCadastrarColecao.TabIndex = 8;
            this.btCadastrarColecao.Text = "Cadastrar";
            this.btCadastrarColecao.UseVisualStyleBackColor = false;
            this.btCadastrarColecao.Click += new System.EventHandler(this.btCadastrarColecao_Click);
            // 
            // dgvColecoes
            // 
            this.dgvColecoes.AllowUserToAddRows = false;
            this.dgvColecoes.AllowUserToDeleteRows = false;
            this.dgvColecoes.AllowUserToResizeRows = false;
            this.dgvColecoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColecoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColecoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvColecoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColecoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColecoes.ColumnHeadersHeight = 30;
            this.dgvColecoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColecoes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColecoes.EnableHeadersVisualStyles = false;
            this.dgvColecoes.Location = new System.Drawing.Point(49, 66);
            this.dgvColecoes.Name = "dgvColecoes";
            this.dgvColecoes.ReadOnly = true;
            this.dgvColecoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColecoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColecoes.RowHeadersVisible = false;
            this.dgvColecoes.RowHeadersWidth = 51;
            this.dgvColecoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColecoes.Size = new System.Drawing.Size(943, 524);
            this.dgvColecoes.TabIndex = 12;
            this.dgvColecoes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvColecoes_CellMouseDoubleClick);
            // 
            // FormColecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 681);
            this.Controls.Add(this.dgvColecoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverColecao);
            this.Controls.Add(this.btAtualizarColecao);
            this.Controls.Add(this.btCadastrarColecao);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormColecoes";
            this.Text = "FormColecoes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvColecoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemoverColecao;
        private System.Windows.Forms.Button btAtualizarColecao;
        private System.Windows.Forms.Button btCadastrarColecao;
        private System.Windows.Forms.DataGridView dgvColecoes;
    }
}
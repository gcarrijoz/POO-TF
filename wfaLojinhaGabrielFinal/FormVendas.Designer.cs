namespace wfaLojinhaGabrielFinal
{
    partial class FormVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoverVenda = new System.Windows.Forms.Button();
            this.btAtualizarVenda = new System.Windows.Forms.Button();
            this.btCadastrarVenda = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(280, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gerenciamento de Vendas";
            // 
            // btRemoverVenda
            // 
            this.btRemoverVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btRemoverVenda.FlatAppearance.BorderSize = 0;
            this.btRemoverVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoverVenda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverVenda.ForeColor = System.Drawing.Color.White;
            this.btRemoverVenda.Location = new System.Drawing.Point(645, 619);
            this.btRemoverVenda.Name = "btRemoverVenda";
            this.btRemoverVenda.Size = new System.Drawing.Size(204, 40);
            this.btRemoverVenda.TabIndex = 22;
            this.btRemoverVenda.Text = "Excluir";
            this.btRemoverVenda.UseVisualStyleBackColor = false;
            this.btRemoverVenda.Click += new System.EventHandler(this.btRemoverVenda_Click);
            // 
            // btAtualizarVenda
            // 
            this.btAtualizarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btAtualizarVenda.FlatAppearance.BorderSize = 0;
            this.btAtualizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarVenda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarVenda.ForeColor = System.Drawing.Color.White;
            this.btAtualizarVenda.Location = new System.Drawing.Point(401, 619);
            this.btAtualizarVenda.Name = "btAtualizarVenda";
            this.btAtualizarVenda.Size = new System.Drawing.Size(204, 40);
            this.btAtualizarVenda.TabIndex = 21;
            this.btAtualizarVenda.Text = "Editar";
            this.btAtualizarVenda.UseVisualStyleBackColor = false;
            this.btAtualizarVenda.Click += new System.EventHandler(this.btAtualizarVenda_Click);
            // 
            // btCadastrarVenda
            // 
            this.btCadastrarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btCadastrarVenda.FlatAppearance.BorderSize = 0;
            this.btCadastrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarVenda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVenda.ForeColor = System.Drawing.Color.White;
            this.btCadastrarVenda.Location = new System.Drawing.Point(156, 619);
            this.btCadastrarVenda.Name = "btCadastrarVenda";
            this.btCadastrarVenda.Size = new System.Drawing.Size(204, 40);
            this.btCadastrarVenda.TabIndex = 20;
            this.btCadastrarVenda.Text = "Cadastrar";
            this.btCadastrarVenda.UseVisualStyleBackColor = false;
            this.btCadastrarVenda.Click += new System.EventHandler(this.btCadastrarVenda_Click);
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendas.ColumnHeadersHeight = 30;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendas.EnableHeadersVisualStyles = false;
            this.dgvVendas.Location = new System.Drawing.Point(49, 66);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.RowHeadersWidth = 51;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(943, 524);
            this.dgvVendas.TabIndex = 24;
            this.dgvVendas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVendas_CellMouseDoubleClick);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 681);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverVenda);
            this.Controls.Add(this.btAtualizarVenda);
            this.Controls.Add(this.btCadastrarVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemoverVenda;
        private System.Windows.Forms.Button btAtualizarVenda;
        private System.Windows.Forms.Button btCadastrarVenda;
        private System.Windows.Forms.DataGridView dgvVendas;
    }
}
namespace wfaLojinhaGabrielFinal
{
    partial class FormCadastroVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroVendas));
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.tbIdVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarVenda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProduto
            // 
            this.cbProduto.BackColor = System.Drawing.Color.White;
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(210, 116);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(316, 25);
            this.cbProduto.TabIndex = 42;
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(210, 153);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(316, 24);
            this.tbQtd.TabIndex = 38;
            // 
            // tbIdVenda
            // 
            this.tbIdVenda.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdVenda.Enabled = false;
            this.tbIdVenda.Location = new System.Drawing.Point(210, 43);
            this.tbIdVenda.Name = "tbIdVenda";
            this.tbIdVenda.Size = new System.Drawing.Size(316, 24);
            this.tbIdVenda.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID:";
            // 
            // btCadastrarVenda
            // 
            this.btCadastrarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btCadastrarVenda.FlatAppearance.BorderSize = 0;
            this.btCadastrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarVenda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVenda.ForeColor = System.Drawing.Color.White;
            this.btCadastrarVenda.Location = new System.Drawing.Point(322, 366);
            this.btCadastrarVenda.Name = "btCadastrarVenda";
            this.btCadastrarVenda.Size = new System.Drawing.Size(204, 40);
            this.btCadastrarVenda.TabIndex = 30;
            this.btCadastrarVenda.Text = "Cadastrar";
            this.btCadastrarVenda.UseVisualStyleBackColor = false;
            this.btCadastrarVenda.Click += new System.EventHandler(this.btCadastrarCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Data:";
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.White;
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(210, 78);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(316, 25);
            this.cbCliente.TabIndex = 47;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(210, 191);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(316, 24);
            this.dtpData.TabIndex = 48;
            // 
            // FormCadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 495);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.tbIdVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarVenda);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.TextBox tbIdVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarVenda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}
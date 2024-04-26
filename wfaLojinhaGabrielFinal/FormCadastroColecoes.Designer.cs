namespace wfaLojinhaGabrielFinal
{
    partial class FormCadastroColecoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroColecoes));
            this.tbNomeColecao = new System.Windows.Forms.TextBox();
            this.tbIdColecao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarColecao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeColecao
            // 
            this.tbNomeColecao.Location = new System.Drawing.Point(235, 125);
            this.tbNomeColecao.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomeColecao.Name = "tbNomeColecao";
            this.tbNomeColecao.Size = new System.Drawing.Size(422, 28);
            this.tbNomeColecao.TabIndex = 22;
            // 
            // tbIdColecao
            // 
            this.tbIdColecao.Enabled = false;
            this.tbIdColecao.Location = new System.Drawing.Point(235, 74);
            this.tbIdColecao.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdColecao.Name = "tbIdColecao";
            this.tbIdColecao.Size = new System.Drawing.Size(422, 28);
            this.tbIdColecao.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // btCadastrarColecao
            // 
            this.btCadastrarColecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btCadastrarColecao.FlatAppearance.BorderSize = 0;
            this.btCadastrarColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarColecao.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarColecao.ForeColor = System.Drawing.Color.White;
            this.btCadastrarColecao.Location = new System.Drawing.Point(402, 458);
            this.btCadastrarColecao.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastrarColecao.Name = "btCadastrarColecao";
            this.btCadastrarColecao.Size = new System.Drawing.Size(255, 50);
            this.btCadastrarColecao.TabIndex = 15;
            this.btCadastrarColecao.Text = "Cadastrar";
            this.btCadastrarColecao.UseVisualStyleBackColor = false;
            this.btCadastrarColecao.Click += new System.EventHandler(this.btCadastrarColecao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 334);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastroColecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 619);
            this.Controls.Add(this.tbNomeColecao);
            this.Controls.Add(this.tbIdColecao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarColecao);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroColecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Coleções";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNomeColecao;
        private System.Windows.Forms.TextBox tbIdColecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarColecao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
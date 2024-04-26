namespace wfaLojinhaGabrielFinal
{
    partial class FormRemoveColecoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemoveColecoes));
            this.tbNomeColecao = new System.Windows.Forms.TextBox();
            this.tbIdColecao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoverColecao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeColecao
            // 
            this.tbNomeColecao.Enabled = false;
            this.tbNomeColecao.Location = new System.Drawing.Point(188, 100);
            this.tbNomeColecao.Name = "tbNomeColecao";
            this.tbNomeColecao.Size = new System.Drawing.Size(338, 24);
            this.tbNomeColecao.TabIndex = 34;
            // 
            // tbIdColecao
            // 
            this.tbIdColecao.Enabled = false;
            this.tbIdColecao.Location = new System.Drawing.Point(188, 59);
            this.tbIdColecao.Name = "tbIdColecao";
            this.tbIdColecao.Size = new System.Drawing.Size(338, 24);
            this.tbIdColecao.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID:";
            // 
            // btRemoverColecao
            // 
            this.btRemoverColecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btRemoverColecao.FlatAppearance.BorderSize = 0;
            this.btRemoverColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoverColecao.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverColecao.ForeColor = System.Drawing.Color.White;
            this.btRemoverColecao.Location = new System.Drawing.Point(322, 366);
            this.btRemoverColecao.Name = "btRemoverColecao";
            this.btRemoverColecao.Size = new System.Drawing.Size(204, 40);
            this.btRemoverColecao.TabIndex = 30;
            this.btRemoverColecao.Text = "Excluir";
            this.btRemoverColecao.UseVisualStyleBackColor = false;
            this.btRemoverColecao.Click += new System.EventHandler(this.btRemoverColecao_Click);
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
            // FormRemoveColecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 495);
            this.Controls.Add(this.tbNomeColecao);
            this.Controls.Add(this.tbIdColecao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverColecao);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRemoveColecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remoção de Coleção";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeColecao;
        private System.Windows.Forms.TextBox tbIdColecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemoverColecao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
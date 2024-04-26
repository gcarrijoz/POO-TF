namespace wfaLojinhaGabrielFinal
{
    partial class FormEditaColecoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditaColecoes));
            this.tbNomeColecao = new System.Windows.Forms.TextBox();
            this.tbIdColecao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEditarColecao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeColecao
            // 
            this.tbNomeColecao.Location = new System.Drawing.Point(188, 100);
            this.tbNomeColecao.Name = "tbNomeColecao";
            this.tbNomeColecao.Size = new System.Drawing.Size(338, 24);
            this.tbNomeColecao.TabIndex = 28;

            // 
            // tbIdColecao
            // 
            this.tbIdColecao.Enabled = false;
            this.tbIdColecao.Location = new System.Drawing.Point(188, 59);
            this.tbIdColecao.Name = "tbIdColecao";
            this.tbIdColecao.Size = new System.Drawing.Size(338, 24);
            this.tbIdColecao.TabIndex = 27;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome:";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";

            // 
            // btEditarColecao
            // 
            this.btEditarColecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btEditarColecao.FlatAppearance.BorderSize = 0;
            this.btEditarColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarColecao.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarColecao.ForeColor = System.Drawing.Color.White;
            this.btEditarColecao.Location = new System.Drawing.Point(322, 366);
            this.btEditarColecao.Name = "btEditarColecao";
            this.btEditarColecao.Size = new System.Drawing.Size(204, 40);
            this.btEditarColecao.TabIndex = 24;
            this.btEditarColecao.Text = "Editar";
            this.btEditarColecao.UseVisualStyleBackColor = false;
            this.btEditarColecao.Click += new System.EventHandler(this.btEditarColecao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;

            // 
            // FormEditaColecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 495);
            this.Controls.Add(this.tbNomeColecao);
            this.Controls.Add(this.tbIdColecao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditarColecao);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditaColecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edição de Coleções";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeColecao;
        private System.Windows.Forms.TextBox tbIdColecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditarColecao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
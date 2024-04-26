namespace wfaLojinhaGabrielFinal
{
    partial class FormEditaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditaClientes));
            this.mtbCelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.tbEmailCliente = new System.Windows.Forms.TextBox();
            this.tbSobrenomeCliente = new System.Windows.Forms.TextBox();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEditarCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbCelularCliente
            // 
            this.mtbCelularCliente.Location = new System.Drawing.Point(188, 198);
            this.mtbCelularCliente.Name = "mtbCelularCliente";
            this.mtbCelularCliente.Size = new System.Drawing.Size(339, 24);
            this.mtbCelularCliente.TabIndex = 25;
            // 
            // tbEmailCliente
            // 
            this.tbEmailCliente.Location = new System.Drawing.Point(188, 157);
            this.tbEmailCliente.Name = "tbEmailCliente";
            this.tbEmailCliente.Size = new System.Drawing.Size(338, 24);
            this.tbEmailCliente.TabIndex = 24;
            // 
            // tbSobrenomeCliente
            // 
            this.tbSobrenomeCliente.Location = new System.Drawing.Point(188, 116);
            this.tbSobrenomeCliente.Name = "tbSobrenomeCliente";
            this.tbSobrenomeCliente.Size = new System.Drawing.Size(338, 24);
            this.tbSobrenomeCliente.TabIndex = 23;
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(188, 75);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(338, 24);
            this.tbNomeCliente.TabIndex = 22;
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Enabled = false;
            this.tbIdCliente.Location = new System.Drawing.Point(188, 34);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(338, 24);
            this.tbIdCliente.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sobrenome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // btEditarCliente
            // 
            this.btEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btEditarCliente.FlatAppearance.BorderSize = 0;
            this.btEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarCliente.ForeColor = System.Drawing.Color.White;
            this.btEditarCliente.Location = new System.Drawing.Point(322, 366);
            this.btEditarCliente.Name = "btEditarCliente";
            this.btEditarCliente.Size = new System.Drawing.Size(204, 40);
            this.btEditarCliente.TabIndex = 15;
            this.btEditarCliente.Text = "Editar";
            this.btEditarCliente.UseVisualStyleBackColor = false;
            this.btEditarCliente.Click += new System.EventHandler(this.btEditarCliente_Click);
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
            // FormEditaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 495);
            this.Controls.Add(this.mtbCelularCliente);
            this.Controls.Add(this.tbEmailCliente);
            this.Controls.Add(this.tbSobrenomeCliente);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.tbIdCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edição de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCelularCliente;
        private System.Windows.Forms.TextBox tbEmailCliente;
        private System.Windows.Forms.TextBox tbSobrenomeCliente;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace projetoVersat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            btnCadastrar = new Button();
            txtEndereco = new TextBox();
            label4 = new Label();
            btnPesquisar = new Button();
            label5 = new Label();
            lblid = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 144);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 221);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 296);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            label3.Click += label3_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(140, 140);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(422, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 221);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(422, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(140, 292);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(422, 23);
            txtCpf.TabIndex = 3;
            txtCpf.TextChanged += textBox3_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(45, 478);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(97, 32);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(140, 373);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(422, 23);
            txtEndereco.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 377);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 8;
            label4.Text = "Endereço:";
            label4.Click += label4_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(183, 478);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(99, 32);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 39);
            label5.Name = "label5";
            label5.Size = new Size(82, 18);
            label5.TabIndex = 10;
            label5.Text = "Cliente ID:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblid.Location = new Point(131, 39);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 18);
            lblid.TabIndex = 11;
            lblid.Click += label6_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(463, 29);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(99, 28);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.Location = new Point(325, 478);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(99, 32);
            btnAtualizar.TabIndex = 13;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletar.Location = new Point(464, 478);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(99, 32);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 569);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblid);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(label4);
            Controls.Add(txtEndereco);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private Button btnCadastrar;
        private TextBox txtEndereco;
        private Label label4;
        private Button btnPesquisar;
        private Label label5;
        private Label lblid;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
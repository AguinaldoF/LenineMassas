namespace LenineMassas.View
{
    partial class CadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnderecoCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCepCadastro = new System.Windows.Forms.TextBox();
            this.txtDataNascimentoCadastro = new System.Windows.Forms.TextBox();
            this.txtNumeroCadastro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefoneCadastro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCelularCadastro = new System.Windows.Forms.TextBox();
            this.btnIncluirCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnCancelaCadastro = new System.Windows.Forms.Button();
            this.btnAlterarCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nº:";
            // 
            // txtEnderecoCadastro
            // 
            this.txtEnderecoCadastro.Location = new System.Drawing.Point(71, 111);
            this.txtEnderecoCadastro.Name = "txtEnderecoCadastro";
            this.txtEnderecoCadastro.Size = new System.Drawing.Size(326, 20);
            this.txtEnderecoCadastro.TabIndex = 3;
            this.txtEnderecoCadastro.TextChanged += new System.EventHandler(this.txtEndereco);
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(71, 70);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(326, 20);
            this.txtNomeCadastro.TabIndex = 1;
            this.txtNomeCadastro.TextChanged += new System.EventHandler(this.txtNome);
            // 
            // txtCodigoCadastro
            // 
            this.txtCodigoCadastro.Location = new System.Drawing.Point(71, 32);
            this.txtCodigoCadastro.Name = "txtCodigoCadastro";
            this.txtCodigoCadastro.Size = new System.Drawing.Size(52, 20);
            this.txtCodigoCadastro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPesquisarCliente);
            // 
            // txtCepCadastro
            // 
            this.txtCepCadastro.Location = new System.Drawing.Point(440, 111);
            this.txtCepCadastro.Name = "txtCepCadastro";
            this.txtCepCadastro.Size = new System.Drawing.Size(99, 20);
            this.txtCepCadastro.TabIndex = 4;
            this.txtCepCadastro.TextChanged += new System.EventHandler(this.txtCep);
            // 
            // txtDataNascimentoCadastro
            // 
            this.txtDataNascimentoCadastro.Location = new System.Drawing.Point(516, 70);
            this.txtDataNascimentoCadastro.Name = "txtDataNascimentoCadastro";
            this.txtDataNascimentoCadastro.Size = new System.Drawing.Size(110, 20);
            this.txtDataNascimentoCadastro.TabIndex = 2;
            // 
            // txtNumeroCadastro
            // 
            this.txtNumeroCadastro.Location = new System.Drawing.Point(573, 111);
            this.txtNumeroCadastro.Name = "txtNumeroCadastro";
            this.txtNumeroCadastro.Size = new System.Drawing.Size(53, 20);
            this.txtNumeroCadastro.TabIndex = 5;
            this.txtNumeroCadastro.TextChanged += new System.EventHandler(this.txtNumero);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Telefone:";
            // 
            // txtTelefoneCadastro
            // 
            this.txtTelefoneCadastro.Location = new System.Drawing.Point(71, 150);
            this.txtTelefoneCadastro.Name = "txtTelefoneCadastro";
            this.txtTelefoneCadastro.Size = new System.Drawing.Size(114, 20);
            this.txtTelefoneCadastro.TabIndex = 6;
            this.txtTelefoneCadastro.TextChanged += new System.EventHandler(this.txtTelefone);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Celular:";
            // 
            // txtCelularCadastro
            // 
            this.txtCelularCadastro.Location = new System.Drawing.Point(239, 150);
            this.txtCelularCadastro.Name = "txtCelularCadastro";
            this.txtCelularCadastro.Size = new System.Drawing.Size(114, 20);
            this.txtCelularCadastro.TabIndex = 7;
            this.txtCelularCadastro.TextChanged += new System.EventHandler(this.txtCelular);
            // 
            // btnIncluirCadastro
            // 
            this.btnIncluirCadastro.Location = new System.Drawing.Point(203, 199);
            this.btnIncluirCadastro.Name = "btnIncluirCadastro";
            this.btnIncluirCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirCadastro.TabIndex = 8;
            this.btnIncluirCadastro.Text = "Incluir";
            this.btnIncluirCadastro.UseVisualStyleBackColor = true;
            this.btnIncluirCadastro.Click += new System.EventHandler(this.btnIncluirCadastro_Click);
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Location = new System.Drawing.Point(446, 199);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCadastro.TabIndex = 11;
            this.btnExcluirCadastro.Text = "Excluir";
            this.btnExcluirCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelaCadastro
            // 
            this.btnCancelaCadastro.Location = new System.Drawing.Point(527, 199);
            this.btnCancelaCadastro.Name = "btnCancelaCadastro";
            this.btnCancelaCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelaCadastro.TabIndex = 12;
            this.btnCancelaCadastro.Text = "Cancela";
            this.btnCancelaCadastro.UseVisualStyleBackColor = true;
            this.btnCancelaCadastro.Click += new System.EventHandler(this.btnCancelaCadastro_Click);
            // 
            // btnAlterarCadastro
            // 
            this.btnAlterarCadastro.Location = new System.Drawing.Point(284, 199);
            this.btnAlterarCadastro.Name = "btnAlterarCadastro";
            this.btnAlterarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCadastro.TabIndex = 9;
            this.btnAlterarCadastro.Text = "Alterar";
            this.btnAlterarCadastro.UseVisualStyleBackColor = true;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 242);
            this.Controls.Add(this.btnAlterarCadastro);
            this.Controls.Add(this.btnCancelaCadastro);
            this.Controls.Add(this.btnExcluirCadastro);
            this.Controls.Add(this.btnIncluirCadastro);
            this.Controls.Add(this.txtCelularCadastro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefoneCadastro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroCadastro);
            this.Controls.Add(this.txtDataNascimentoCadastro);
            this.Controls.Add(this.txtCepCadastro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodigoCadastro);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.txtEnderecoCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnderecoCadastro;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.TextBox txtCodigoCadastro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCepCadastro;
        private System.Windows.Forms.TextBox txtDataNascimentoCadastro;
        private System.Windows.Forms.TextBox txtNumeroCadastro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefoneCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCelularCadastro;
        private System.Windows.Forms.Button btnIncluirCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnCancelaCadastro;
        private System.Windows.Forms.Button btnAlterarCadastro;
    }
}
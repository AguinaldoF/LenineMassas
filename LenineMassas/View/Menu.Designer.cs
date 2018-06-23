namespace LenineMassas.View
{
    partial class telaMenu
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnFechar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(70, 67);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(125, 51);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(70, 134);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(125, 51);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Location = new System.Drawing.Point(70, 205);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(125, 51);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnFechar1
            // 
            this.btnFechar1.Location = new System.Drawing.Point(70, 276);
            this.btnFechar1.Name = "btnFechar1";
            this.btnFechar1.Size = new System.Drawing.Size(125, 51);
            this.btnFechar1.TabIndex = 3;
            this.btnFechar1.Text = "Fechar";
            this.btnFechar1.UseVisualStyleBackColor = true;
            this.btnFechar1.Click += new System.EventHandler(this.btnFechar1_Click);
            // 
            // telaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(266, 392);
            this.Controls.Add(this.btnFechar1);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnFechar1;
    }
}
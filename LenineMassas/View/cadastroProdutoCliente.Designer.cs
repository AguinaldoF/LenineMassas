namespace LenineMassas.View
{
    partial class cadastroProdutoCliente
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
            this.btnClientes1 = new System.Windows.Forms.Button();
            this.btnProdutos1 = new System.Windows.Forms.Button();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes1
            // 
            this.btnClientes1.Location = new System.Drawing.Point(12, 12);
            this.btnClientes1.Name = "btnClientes1";
            this.btnClientes1.Size = new System.Drawing.Size(75, 23);
            this.btnClientes1.TabIndex = 0;
            this.btnClientes1.Text = "Clientes";
            this.btnClientes1.UseVisualStyleBackColor = true;
            this.btnClientes1.Click += new System.EventHandler(this.btnClientes1_Click);
            // 
            // btnProdutos1
            // 
            this.btnProdutos1.Location = new System.Drawing.Point(93, 12);
            this.btnProdutos1.Name = "btnProdutos1";
            this.btnProdutos1.Size = new System.Drawing.Size(75, 23);
            this.btnProdutos1.TabIndex = 1;
            this.btnProdutos1.Text = "Produtos";
            this.btnProdutos1.UseVisualStyleBackColor = true;
            this.btnProdutos1.Click += new System.EventHandler(this.btnProdutos1_Click);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.AutoSize = true;
            this.btnVoltar2.Location = new System.Drawing.Point(174, 12);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar2.TabIndex = 2;
            this.btnVoltar2.Text = "Voltar";
            this.btnVoltar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // cadastroProdutoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(257, 48);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.btnProdutos1);
            this.Controls.Add(this.btnClientes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "cadastroProdutoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes1;
        private System.Windows.Forms.Button btnProdutos1;
        private System.Windows.Forms.Button btnVoltar2;
    }
}
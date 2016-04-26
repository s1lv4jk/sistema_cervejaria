namespace Sistema_CervejariaV01
{
    partial class receita
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_criar);
            this.groupBox1.Controls.Add(this.btn_visualizar);
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receitas:";
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(29, 50);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(153, 23);
            this.btn_visualizar.TabIndex = 0;
            this.btn_visualizar.Text = "&Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(29, 79);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(153, 23);
            this.btn_criar.TabIndex = 1;
            this.btn_criar.Text = "&Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(29, 108);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(153, 23);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "&Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // receita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "receita";
            this.Text = "Sistema Cervejavia v0.1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_visualizar;
    }
}
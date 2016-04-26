namespace Sistema_CervejariaV01
{
    partial class administracao
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.btn_ingredientes = new System.Windows.Forms.Button();
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.btn_receitas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_fechar);
            this.groupBox1.Controls.Add(this.btn_relatorios);
            this.groupBox1.Controls.Add(this.btn_ingredientes);
            this.groupBox1.Controls.Add(this.btn_pedidos);
            this.groupBox1.Controls.Add(this.btn_receitas);
            this.groupBox1.Location = new System.Drawing.Point(17, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administração";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(71, 149);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.Location = new System.Drawing.Point(71, 120);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(75, 23);
            this.btn_relatorios.TabIndex = 4;
            this.btn_relatorios.Text = "Relatórios";
            this.btn_relatorios.UseVisualStyleBackColor = true;
            // 
            // btn_ingredientes
            // 
            this.btn_ingredientes.Location = new System.Drawing.Point(71, 91);
            this.btn_ingredientes.Name = "btn_ingredientes";
            this.btn_ingredientes.Size = new System.Drawing.Size(75, 23);
            this.btn_ingredientes.TabIndex = 3;
            this.btn_ingredientes.Text = "Ingredientes";
            this.btn_ingredientes.UseVisualStyleBackColor = true;
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.Location = new System.Drawing.Point(71, 62);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(75, 23);
            this.btn_pedidos.TabIndex = 1;
            this.btn_pedidos.Text = "Pedidos";
            this.btn_pedidos.UseVisualStyleBackColor = true;
            // 
            // btn_receitas
            // 
            this.btn_receitas.Location = new System.Drawing.Point(71, 33);
            this.btn_receitas.Name = "btn_receitas";
            this.btn_receitas.Size = new System.Drawing.Size(75, 23);
            this.btn_receitas.TabIndex = 0;
            this.btn_receitas.Text = "Receitas";
            this.btn_receitas.UseVisualStyleBackColor = true;
            // 
            // administracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "administracao";
            this.Text = "Sistema Cervejavia v0.1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_receitas;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Button btn_ingredientes;
        private System.Windows.Forms.Button btn_pedidos;
    }
}
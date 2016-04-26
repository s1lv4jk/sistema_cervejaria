namespace Sistema_CervejariaV01
{
    partial class inicial
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_producao = new System.Windows.Forms.Button();
            this.btn_adm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.btn_producao);
            this.groupBox1.Controls.Add(this.btn_adm);
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bem vindo";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(12, 112);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(177, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "&Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_producao
            // 
            this.btn_producao.Location = new System.Drawing.Point(12, 83);
            this.btn_producao.Name = "btn_producao";
            this.btn_producao.Size = new System.Drawing.Size(177, 23);
            this.btn_producao.TabIndex = 4;
            this.btn_producao.Text = "&Produção";
            this.btn_producao.UseVisualStyleBackColor = true;
            // 
            // btn_adm
            // 
            this.btn_adm.Location = new System.Drawing.Point(12, 54);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(177, 23);
            this.btn_adm.TabIndex = 3;
            this.btn_adm.Text = "&Administração";
            this.btn_adm.UseVisualStyleBackColor = true;
            this.btn_adm.Click += new System.EventHandler(this.btn_adm_Click);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "inicial";
            this.Text = "Sistema Cervejaria v0.1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_producao;
        private System.Windows.Forms.Button btn_adm;
    }
}


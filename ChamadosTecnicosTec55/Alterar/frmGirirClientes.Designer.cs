namespace ChamadosTecnicosTec55.Alterar
{
    partial class frmGirirClientes
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
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.txtAdicionarCliente = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlternar = new System.Windows.Forms.Button();
            this.BtnIcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnP)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDados
            // 
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(12, 60);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.Size = new System.Drawing.Size(776, 284);
            this.DgvDados.TabIndex = 0;
            // 
            // txtAdicionarCliente
            // 
            this.txtAdicionarCliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtAdicionarCliente.ForeColor = System.Drawing.Color.White;
            this.txtAdicionarCliente.Location = new System.Drawing.Point(473, 33);
            this.txtAdicionarCliente.Name = "txtAdicionarCliente";
            this.txtAdicionarCliente.Size = new System.Drawing.Size(246, 20);
            this.txtAdicionarCliente.TabIndex = 1;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExcluir.Location = new System.Drawing.Point(681, 350);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(107, 40);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "EXCLUIR CLIENTE";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // BtnAlternar
            // 
            this.BtnAlternar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAlternar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAlternar.Location = new System.Drawing.Point(559, 350);
            this.BtnAlternar.Name = "BtnAlternar";
            this.BtnAlternar.Size = new System.Drawing.Size(116, 40);
            this.BtnAlternar.TabIndex = 3;
            this.BtnAlternar.Text = "ALTERNAR CLIENTE";
            this.BtnAlternar.UseVisualStyleBackColor = false;
            // 
            // BtnIcluir
            // 
            this.BtnIcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIcluir.Location = new System.Drawing.Point(443, 350);
            this.BtnIcluir.Name = "BtnIcluir";
            this.BtnIcluir.Size = new System.Drawing.Size(110, 40);
            this.BtnIcluir.TabIndex = 4;
            this.BtnIcluir.Text = "INCLUIR CLIENTE";
            this.BtnIcluir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(473, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Nome do  Cliente";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONSULTAR DADOS  CLIENTES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnP
            // 
            this.BtnP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnP.Image = global::ChamadosTecnicosTec55.Properties.Resources.lupa;
            this.BtnP.Location = new System.Drawing.Point(694, 33);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(36, 20);
            this.BtnP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnP.TabIndex = 8;
            this.BtnP.TabStop = false;
            this.BtnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // frmGirirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 417);
            this.Controls.Add(this.BtnP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIcluir);
            this.Controls.Add(this.BtnAlternar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.txtAdicionarCliente);
            this.Controls.Add(this.DgvDados);
            this.Name = "frmGirirClientes";
            this.Text = "frmGirirClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.TextBox txtAdicionarCliente;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlternar;
        private System.Windows.Forms.Button BtnIcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnP;
    }
}
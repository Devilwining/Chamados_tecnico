namespace ChamadosTecnicosTec55
{
    partial class frmGeririTecnico
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIcluir = new System.Windows.Forms.Button();
            this.BtnAlternar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.txtAdicionarTecnicos = new System.Windows.Forms.TextBox();
            this.DgvDados_T = new System.Windows.Forms.DataGridView();
            this.BtnP_T = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnP_T)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "CONSULTAR DADOS TECNICOS  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(473, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar Nome do  Tecnico";
            // 
            // BtnIcluir
            // 
            this.BtnIcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIcluir.Location = new System.Drawing.Point(443, 377);
            this.BtnIcluir.Name = "BtnIcluir";
            this.BtnIcluir.Size = new System.Drawing.Size(110, 40);
            this.BtnIcluir.TabIndex = 13;
            this.BtnIcluir.Text = "INCLUIR TECINICOS";
            this.BtnIcluir.UseVisualStyleBackColor = false;
            this.BtnIcluir.Click += new System.EventHandler(this.BtnIcluir_Click_1);
            // 
            // BtnAlternar
            // 
            this.BtnAlternar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAlternar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAlternar.Location = new System.Drawing.Point(559, 377);
            this.BtnAlternar.Name = "BtnAlternar";
            this.BtnAlternar.Size = new System.Drawing.Size(116, 40);
            this.BtnAlternar.TabIndex = 12;
            this.BtnAlternar.Text = "ALTERNAR TECNICOS";
            this.BtnAlternar.UseVisualStyleBackColor = false;
            this.BtnAlternar.Click += new System.EventHandler(this.BtnAlternar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExcluir.Location = new System.Drawing.Point(681, 377);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(107, 40);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "EXCLUIR TECNICOS";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // txtAdicionarTecnicos
            // 
            this.txtAdicionarTecnicos.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtAdicionarTecnicos.ForeColor = System.Drawing.Color.White;
            this.txtAdicionarTecnicos.Location = new System.Drawing.Point(473, 60);
            this.txtAdicionarTecnicos.Name = "txtAdicionarTecnicos";
            this.txtAdicionarTecnicos.Size = new System.Drawing.Size(246, 20);
            this.txtAdicionarTecnicos.TabIndex = 10;
            // 
            // DgvDados_T
            // 
            this.DgvDados_T.AllowUserToAddRows = false;
            this.DgvDados_T.AllowUserToDeleteRows = false;
            this.DgvDados_T.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados_T.Location = new System.Drawing.Point(12, 87);
            this.DgvDados_T.Name = "DgvDados_T";
            this.DgvDados_T.ReadOnly = true;
            this.DgvDados_T.Size = new System.Drawing.Size(776, 284);
            this.DgvDados_T.TabIndex = 9;
            // 
            // BtnP_T
            // 
            this.BtnP_T.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnP_T.Image = global::ChamadosTecnicosTec55.Properties.Resources.lupa;
            this.BtnP_T.Location = new System.Drawing.Point(694, 60);
            this.BtnP_T.Name = "BtnP_T";
            this.BtnP_T.Size = new System.Drawing.Size(36, 20);
            this.BtnP_T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnP_T.TabIndex = 16;
            this.BtnP_T.TabStop = false;
            this.BtnP_T.Click += new System.EventHandler(this.BtnP_T_Click);
            // 
            // frmGeririTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnP_T);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIcluir);
            this.Controls.Add(this.BtnAlternar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.txtAdicionarTecnicos);
            this.Controls.Add(this.DgvDados_T);
            this.Name = "frmGeririTecnico";
            this.Text = "frmGeririTecnico";
            this.Load += new System.EventHandler(this.frmGeririTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnP_T)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnP_T;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIcluir;
        private System.Windows.Forms.Button BtnAlternar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox txtAdicionarTecnicos;
        private System.Windows.Forms.DataGridView DgvDados_T;
    }
}
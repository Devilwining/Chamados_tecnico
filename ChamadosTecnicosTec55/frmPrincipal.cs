using ChamadosTecnicosTec55.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Oh, Vai mesmo sair ?" ,"Sistema de Chamado" ,MessageBoxButtons.YesNo);

            if (msgBox == DialogResult.Yes) 
            {
                Application.Exit();                   
            }
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://sp.senac.br",
                UseShellExecute = true
            });
        }

        private void claculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }
        public void coresFormulario() 
        {
            foreach(Control ctrl in this.Controls) 
            {
                try
                {
                    if (ctrl is MdiClient)
                    {
                        ctrl.BackColor = System.Drawing.Color.AliceBlue;
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            
            
            
            }
        
        
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            coresFormulario();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //itamciar
            var formcliente = new frmAdicionarCliente();
            // Define o formulario pai
            formcliente.MdiParent = this;
            formcliente.Show();
        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtecnico = new frmTecnicoAdicionar();
            // Define o formulario pai no C#
            formtecnico.MdiParent = this;
            formtecnico.Show();
        }
    }
}

using ChamadosTecnicosTec55.Adicionar;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmGeririTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmGeririTecnico()
        {
            InitializeComponent();
        }
        //Buscar no DAO o Tecnico
        private void ListarTecnico()
        {
            //Chama o Tecnico DAO
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);
            // Captura o valor digitado na barra de texto TXB
            string busca = txtAdicionarTecnicos.Text.ToString();
            //Chama o Metodo BuscaCliente do objeto
            DataSet ds = new DataSet();
            ds = tecnicoDao.BuscarTecnico(busca);
            // Defini o DataSource do DataGridView
            DgvDados_T.DataSource = ds;
            // Defini o Membro do DatoSet
            DgvDados_T.DataMember = "Tecnico";
        }

        private void BtnP_T_Click(object sender, EventArgs e)
        {
            if (BtnP_T.Text != "")
            {
                ListarTecnico();
            }
            else
            {
                MessageBox.Show("Digite algo para buscar");
            }
        }

        private void frmGirirTecnico_Load(object sender, EventArgs e)
        {
            ListarTecnico();
        }

        private void BtnIcluir_Click(object sender, EventArgs e)
        {
            var dados = new frmAdicionarCliente();
            dados.ShowDialog();
            ListarTecnico();
        }

        private void BtnIcluir_Click_1(object sender, EventArgs e)
        {
            var dados = new frmTecnicoAdicionar();
            dados.ShowDialog();
            ListarTecnico();
        }

    }
    
}

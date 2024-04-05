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

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmGirirClientes : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmGirirClientes()
        {
            InitializeComponent();
        }
        //Buscar no DAO o cliente
        private void ListarCliente() 
        {
            //Chama o Cliente DAO
            ClienteDao ClienteDao = new ClienteDao(_conexao);
            // Captura o valor digitado na barra de texto TXB
            string busca = txtAdicionarCliente.Text.ToString();
            //Chama o Metodo BuscaCliente do objeto
            DataSet ds = new DataSet();
            ds = ClienteDao.BuscarClientes(busca);
            // Defini o DataSource do DataGridView
            DgvDados.DataSource = ds;
            // Defini o Membro do DatoSet
            DgvDados.DataMember = "Cliente";



        }
        private void BtnP_Click(object sender, EventArgs e)
        {
            if (BtnP.Text != "")
            {
                ListarCliente();
            }
            else 
            {
                MessageBox.Show("Digite algo para buscar");
            }
        }

        private void frmGirirClientes_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void BtnIcluir_Click(object sender, EventArgs e)
        {
            var dados = new frmAdicionarCliente();           
            dados.ShowDialog();
            ListarCliente();
        }
    }
}

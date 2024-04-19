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
    public partial class Aterar_Clientes : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        
        public Aterar_Clientes(int codigo)
        {
            
            InitializeComponent();

            // Verificar se o código maior que zero
            if (codigo > 0) 
            {
               // Criar uma instância do objeto Cliente
              Cliente cliente = new Cliente();
              ClienteDao clientedao = new ClienteDao(_conexao);

                cliente = clientedao.ObtemCliente(codigo);

                //Se o cliente não foi encontrado
                if(cliente == null) 
                {
                    MessageBox.Show("Cliente não encontrado");
                    this.Close();
                }
                
                Txb_Cod_T.Text = cliente.CodigoCliente.ToString();
                Txb_Nome.Text = cliente.Nome;
                Txb_Pfsss.Text = cliente.Profissao;
                Txb_senha_T.Text = cliente.Setor;
                Txb_Obs.Text = cliente.Obs;
            
            }
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDeo = new ClienteDao(_conexao);

            try 
            {
                cliente.Nome = Txb_Nome.Text;
                cliente.Profissao = Txb_Pfsss.Text;
                cliente.Setor = Txb_senha_T.Text;
                cliente.Obs = Txb_Obs.Text;

                int Codigo = Convert.ToInt32(Txb_Cod_T.Text);

                cliente.CodigoCliente = Codigo;

                clienteDeo.AlterarCliente(cliente);

                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            
            
            }
        }
    }
}

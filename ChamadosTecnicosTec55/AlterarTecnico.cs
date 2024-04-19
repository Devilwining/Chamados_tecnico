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
    public partial class AlterarTecnico : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public AlterarTecnico(int codigo)
        {
            InitializeComponent();
            // Verificar se o código maior que zero
            if (codigo > 0)
            {
                // Criar uma instância do objeto Tencico
                Tecnico tecnico = new Tecnico();
                TecnicoDao tecnicodao = new TecnicoDao(_conexao);

                tecnico = tecnicodao.ObtemTecnico(codigo);

                //Se o cliente não foi encontrado
                if (tecnico == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                    this.Close();
                }

                Txb_Cod_T.Text = tecnico.CodigoTecnico.ToString();
                Txb_Nome_T.Text = tecnico.Nome;
                Txb_ESP_T.Text = tecnico.Especialidade;
                Txb_senha_T.Text = tecnico.Senha;
                txb_email_T.Text = tecnico.Email;
                Txb_Obs_T.Text = tecnico.Obs;
            }

        }
    }




}


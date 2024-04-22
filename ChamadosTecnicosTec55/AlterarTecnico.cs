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
                    MessageBox.Show("Tecnico não encontrado");
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

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicoDeo = new TecnicoDao(_conexao);

            try
            {               
                tecnico.Nome = Txb_Nome_T.Text;
                tecnico.Especialidade = Txb_ESP_T.Text;
                tecnico.Senha = Txb_senha_T.Text;
                tecnico.Email = txb_email_T.Text;
                tecnico.Obs = Txb_Obs_T.Text;

                int Codigo = Convert.ToInt32(Txb_Cod_T.Text);

                tecnico.CodigoTecnico = Codigo;

                tecnicoDeo.AlterarTecnico(tecnico);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }
}


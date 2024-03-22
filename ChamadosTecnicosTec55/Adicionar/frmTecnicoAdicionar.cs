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

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class frmTecnicoAdicionar : Form
    {
        //Chama a conexão
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
        public frmTecnicoAdicionar()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            txbnome.Clear();
            txbesp.Clear();
            txbemail.Clear();
            txbsenha.Clear();
            txbObs.Clear();
              

        }

        private void bntlimpar_Click(object sender, EventArgs e)
        {
            // chama o objeto Tecnico
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

            if (String.IsNullOrWhiteSpace(txbnome.Text) ||
               String.IsNullOrWhiteSpace(txbesp.Text) ||
               String.IsNullOrWhiteSpace(txbemail.Text) ||
               String.IsNullOrWhiteSpace(txbsenha.Text) ||
               String.IsNullOrWhiteSpace(txbObs.Text)) 
            {
                MessageBox.Show("Campos em branco obrigatorio");
            }
            else
            {
                // TODA VEZ QUE MEXER COM BD USUAR TRY
                try 
                {
                    //Preencher o Objeto Tecnico
                    tecnico.nome = txbnome.Text;
                    tecnico.Especialidade = txbesp.Text;
                    tecnico.Email = txbemail.Text;
                    tecnico.Senha = txbsenha.Text;
                    tecnico.Obs = txbObs.Text; 

                    // CHAMA O DAO para incluir o cliente
                    tecnicoDao.IncluiTecnico(tecnico);
                    MessageBox.Show("Cadastrado com sucesso !");

                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar" + ex, "Atenção",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }






            }



        }
    }
}

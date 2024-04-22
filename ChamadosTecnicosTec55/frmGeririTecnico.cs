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
            //Chama o Metodo BuscaTecnico do objeto
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

        private void BtnIcluir_Click_1(object sender, EventArgs e)
        {
            var dados = new frmTecnicoAdicionar();
            dados.ShowDialog();
            ListarTecnico();
        }

        private void BtnAlternar_Click(object sender, EventArgs e)
        {
            // Verificar se agulm linha selecionada no DGV
            if (DgvDados_T.SelectedRows.Count > 0)
            {
                // obtém o código do cliente da limha selecionada
                int codigo = Convert.ToInt32(DgvDados_T.CurrentRow.Cells[0].Value);

                var frmAlterar = new AlterarTecnico(codigo);
                frmAlterar.ShowDialog();

                // Apos a tela fechar listar os clientes cadastrados
                ListarTecnico();
            }
            else
            {
                // Exiba uma mensagem de Aviso se nenhum linha estiver selecionada
                MessageBox.Show("Selecione um registro para alterar");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Botão excluir
            // selecinar data grid , Capturar ID, Enviar para DAO , excluir
            if (DgvDados_T.SelectedRows.Count > 0)
            {

                int codigo = Convert.ToInt32(DgvDados_T.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja Excluir ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {

                    TecnicoDao tecnicodao = new TecnicoDao(_conexao);
                    tecnicodao.ExcluirTecnico(codigo);
                    ListarTecnico();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Registro !");
            }
        }

        private void frmGeririTecnico_Load(object sender, EventArgs e)
        {
            ListarTecnico();
        }
    }
}
        

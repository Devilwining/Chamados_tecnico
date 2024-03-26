using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // ADD NET
using System.Data.SqlClient;
using System.Linq.Expressions; // ADD para SQL SERVER

namespace Data
{
    public class TecnicoDao
    {
        private string _conexao;

        // metodo Construtor => Inicializa Obijeto buscando Conexao
        public TecnicoDao(string conexao) 
        {
            //RECEBE cenexao
            _conexao = conexao;
        
        }
        //Inserir Cliente vulgo XUXAR
        public void IncluiTecnico(Tecnico Tecnico) 
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            { 
                string sql = "Insert into Tecnicos(Nome,Especialidade,Email,senha,Obs) values(@Nome,@especialidade,@Email,@senha,@Obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@Nome", Tecnico.Nome);
                    comando.Parameters.AddWithValue("@Especialidade", Tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@Email", Tecnico.Email);
                    comando.Parameters.AddWithValue("@Senha", Tecnico.Senha);
                    comando.Parameters.AddWithValue("@Obs", Tecnico.Obs);


                    try
                    {

                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao Incluir Tecnico" + ex.Message);

                    }
                }
            
            }
                
        
        
        }

    }
}

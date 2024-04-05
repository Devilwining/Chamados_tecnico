using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //ADD.net
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Net.Http.Headers; // ADD para SQL SERVER

namespace Data
{
    public class ClienteDao
    {
        private string _conexao;

            // metodo Construtor => Inicializa Obijeto buscando Conexao
            public ClienteDao( string conexao)
            {      
              // RECEBA Conexao
              _conexao = conexao;
            }   
        
             //Inserir Cliente vulgo XUXAR
             public void IncluiCliente(Cliente cliente)
             {
                    using (SqlConnection conexaoBd = new SqlConnection(_conexao))
                    {
                        string sql = "Insert into Cliente (nome,profissao,setor,obs) values (@nome,@profissao,@setor,@obs)";

                        using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                        {
                            comando.Parameters.AddWithValue("@nome", cliente.Nome);
                            comando.Parameters.AddWithValue("@profissao", cliente.Profissao);
                            comando.Parameters.AddWithValue("@setor", cliente.Setor);
                            comando.Parameters.AddWithValue("@obs", cliente.Obs);


                            try
                            {
                                conexaoBd.Open();
                                comando.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                             
                             throw new Exception("Erro ao Incluir Cliente"+ ex.Message);
                            }
                        }

                    }

             }
        public DataSet BuscarClientes(string pesquisa = "")
        {
            //Constante com o SQL que faz buscar a partir de texto
            const string query = "Select * From cliente Where Nome like @pesquisa";

            //Vliadar Erro
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query ,conexaoBd))
                using (var adaptador = new SqlDataAdapter(comando))
                {                              //$ = tranforma tudo que esta etre {} se torna variavel
                    string parametroPesquisa = $"%{pesquisa}%";
                    comando.Parameters.AddWithValue("@pesquisa", parametroPesquisa);
                    conexaoBd.Open();
                    var dsClientes = new DataSet();
                    adaptador.Fill(dsClientes, "Cliente");
                    return dsClientes;
                }

            }
            catch (Exception ex)
            { 
                throw new Exception($"Erro ao buscar Cliente :{ex.Message}");            
            }
            
        }
    }
}

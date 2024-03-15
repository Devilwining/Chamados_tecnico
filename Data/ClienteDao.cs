using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //ADD.net
using System.Data.SqlClient;
using System.Linq.Expressions; // ADD para SQL SERVER

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
                        string sql = "Insert into Clientes (nome,profissao,seto) values (@nome,@profissao,@setor,@obs)";

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
    }
}

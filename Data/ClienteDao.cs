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
        public ClienteDao(string conexao)
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

                        throw new Exception("Erro ao Incluir Cliente" + ex.Message);
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
                using (var comando = new SqlCommand(query, conexaoBd))
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
        // Xuxar aqui
        public Cliente ObtemCliente(int codigoCliente)
        {
            // Define o sql para obter o cliente
            const string query = @"select * from Cliente where CodigoCliente = @Codigocliente";

            Cliente cliente = null;

            try
            {

                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                    conexaoBd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                CodigoCliente = Convert.ToInt32(reader["CodigoCliente"]),
                                Nome = reader["Nome"].ToString(),
                                Profissao = reader["Profissao"].ToString(),
                                Obs = reader["Obs"].ToString(),
                                Setor = reader["Setor"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o cliente{ex.Message}", ex);
            }
            return cliente;
        }
        public void AlterarCliente(Cliente cliente)
        {
            const string query = @"update Cliente set Nome=@Nome , Setor=@Setor , Profissao=@Profissao, Obs=@Observacao where CodigoCliente = @CodCliente";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@Nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@Setor", cliente.Setor);
                    comando.Parameters.AddWithValue("@Profissao", cliente.Profissao);
                    comando.Parameters.AddWithValue("@Observacao", cliente.Obs);
                    comando.Parameters.AddWithValue("@CodCliente", cliente.CodigoCliente);

                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro{ex.Message}");
            }

        }


}   }   
   


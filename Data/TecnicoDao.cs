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
        public DataSet BuscarTecnico(string pesquisa = "")
        {
            //Constante com o SQL que faz buscar a partir de texto
            const string query = "Select * From Tecnico Where Nome like @pesquisa";

            //Vliadar Erro
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                using (var adaptador = new SqlDataAdapter(comando))

                {  //$ = tranforma tudo que esta etre {} se torna variavel
                    string parametroPesquisa = $"%{pesquisa}%";

                    comando.Parameters.AddWithValue("@pesquisa", parametroPesquisa);
                    conexaoBd.Open();
                    var dsTecnico = new DataSet();
                    adaptador.Fill(dsTecnico, "Tecnico");
                    return dsTecnico;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar Tecnico :{ex.Message}");
            }


        }
        // Xuxar aqui
        public Tecnico ObtemTecnico(int codigoTecnico)
        {
            // Define o sql para obter o cliente
            const string query = @"select * from Tecnico where CodigoTecnico = @CodigoTecnico";

            Tecnico tecnico = null;

            try
            {

                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaoBd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tecnico = new Tecnico
                             {
                                CodigoTecnico = Convert.ToInt32(reader["CodigoTcnico"]),
                                Nome = reader["Nome"].ToString(),
                                Especialidade = reader["Especialidade"].ToString(),
                                Email = reader["email"].ToString(),
                                Obs = reader["Obs"].ToString(),
                                Senha = reader["Senha"].ToString()
                             };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o cliente{ex.Message}", ex);
            }
            return tecnico;
        }
        public void AlterarTecnico(Tecnico tecnico)
        {
            const string query = @"update Tecnico set Nome=@Nome , Senha=@Senha , Especialidade=@Especiacidade, Obs=@Observacao where CodigoTecnico = @CodTecnico";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@Nome", tecnico.Nome);
                    comando.Parameters.AddWithValue("@Senha", tecnico.Senha);
                    comando.Parameters.AddWithValue("@Especialidade", tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@Observacao", tecnico.Obs);
                    comando.Parameters.AddWithValue("@CodTecnico", tecnico.CodigoTecnico);

                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro{ex.Message}");
            }
        }
        // Excluir cliente
        public void ExcluirTecnico(int CodigoTecnico)
        {
            const string qurry = @"delete from Tecnico where CodigoTecnico  = @TecnicoCliente";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(qurry, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoCliente", CodigoTecnico);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir{ex.Message}", ex);
            }
        }
    }
}

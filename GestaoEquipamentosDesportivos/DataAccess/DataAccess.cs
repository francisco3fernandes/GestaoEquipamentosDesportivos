using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using GestaoEquipamentosDesportivos.Models;
using System.Net.Http.Headers;

namespace GestaoEquipamentosDesportivos.DataAccess
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["GestaoEquipamentosDB"].ConnectionString;
        }

        public void AdicionarEquipamento(EquipamentoModel equipamento)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spAdicionarEquipamento", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nome", equipamento.Nome);
            cmd.Parameters.AddWithValue("@Tipo", equipamento.Tipo);
            cmd.Parameters.AddWithValue("@Estado", equipamento.Estado);
            cmd.Parameters.AddWithValue("@DataAquisicao", equipamento.DataAquisicao);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void AtualizarEquipamento(EquipamentoModel equipamento)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spAtualizarEquipamento", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdEquipamento", equipamento.IdEquipamento);
            cmd.Parameters.AddWithValue("@Nome", equipamento.Nome);
            cmd.Parameters.AddWithValue("@Tipo", equipamento.Tipo);
            cmd.Parameters.AddWithValue("@Estado", equipamento.Estado);
            cmd.Parameters.AddWithValue("@DataAquisicao", equipamento.DataAquisicao);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void RemoverEquipamento(int idEquipamento)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spRemoverEquipamento", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEquipamento", idEquipamento);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<EquipamentoModel> ListarEquipamentos()
        {
            List<EquipamentoModel> equipamentos = new List<EquipamentoModel>();

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spListarEquipamentos", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                equipamentos.Add(new EquipamentoModel
                {
                    IdEquipamento = (int)reader["IdEquipamento"],
                    Nome = reader["Nome"].ToString(),
                    Tipo = reader["Tipo"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    DataAquisicao = (DateTime)reader["DataAquisicao"]
                });

            }
            return equipamentos;
        }
        public void AdicionarModalidade(ModalidadeModel modalidade)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spAdicionarModalidade", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nome", modalidade.Nome);
            cmd.Parameters.AddWithValue("@Descricao", modalidade.Descricao);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void AtualizarModalidade(ModalidadeModel modalidade)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spAtualizarModalidade", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdModalidade", modalidade.IdModalidade);
            cmd.Parameters.AddWithValue("@Nome", modalidade.Nome);
            cmd.Parameters.AddWithValue("@Descricao", modalidade.Descricao);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void RemoverModalidade(int idModalidade)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spRemoverModalidade", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdModalidade", idModalidade);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<ModalidadeModel> ListarModalidades()
        {
            List<ModalidadeModel> modalidades = new List<ModalidadeModel>();

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("SELECT * FROM Modalidade", conn);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                modalidades.Add(new ModalidadeModel
                {
                    IdModalidade = (int)reader["IdModalidade"],
                    Nome = reader["Nome"].ToString(),
                    Descricao = reader["Descricao"].ToString()
                });
            }

            return modalidades;
        }

        public void AssociarEquipamentoModalidade(int idEquipamento, int idModalidade)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spAssociarEquipamentoModalidade", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdEquipamento", idEquipamento);
            cmd.Parameters.AddWithValue("@IdModalidade", idModalidade);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void RemoverEquipamentoModalidade(int idEquipamento, int idModalidade)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spRemoverEquipamentoModalidade", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdEquipamento", idEquipamento);
            cmd.Parameters.AddWithValue("@IdModalidade", idModalidade);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<EquipamentoModel> ListarEquipamentosPorModalidade (int idModalidade)
        {
            List<EquipamentoModel> equipamentos = new List<EquipamentoModel>();

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand("spListarEquipamentosPorModalidade", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdModalidade", idModalidade);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                equipamentos.Add(new EquipamentoModel
                {
                    IdEquipamento = (int)reader["IdEquipamento"],
                    Nome = reader["Nome"].ToString(),
                    Tipo = reader["Tipo"].ToString(),
                    Estado = reader["Estado"].ToString(),
                    DataAquisicao = (DateTime)reader["DataAquisicao"]
                });
            }

            return equipamentos;
        }
    }
}

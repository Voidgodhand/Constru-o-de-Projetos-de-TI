using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DesenvolvedoraDAO
    {
        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int64, Desenvolvedora> ListarTodos()
        {
            Dictionary<Int64, Desenvolvedora> mapaDesenvolvedoras = new Dictionary<Int64, Desenvolvedora>();
            try
            {
                String SQL = "SELECT * FROM desenvolvedora;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Desenvolvedora d = new Desenvolvedora();

                    d.Cnpj = data.GetInt64(0);
                    d.Nome = data.GetString(1);
                    d.Presidente = data.GetString(2);
                    d.Fundador = data.GetString(3);
                    d.Fundacao = data.GetString(4);
                    d.NumeroEmpregados = data.GetInt64(5);
                    d.Tipo = data.GetString(6);

                    JogoDAO daoJogo = new JogoDAO();
                    d.jogos = daoJogo.ListarJogosPorDesenvolvedora(d.Cnpj);

                    mapaDesenvolvedoras.Add(d.Cnpj, d);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaDesenvolvedoras;
        }

        public Desenvolvedora BuscarPorID(Int64 _cnpj)
        {
            Desenvolvedora d = null;
            try
            {
                String SQL = String.Format("SELECT * FROM desenvolvedora WHERE cnpj = {0} ", _cnpj);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    d.Cnpj = data.GetInt64(0);
                    d.Nome = data.GetString(1);
                    d.Presidente = data.GetString(2);
                    d.Fundador = data.GetString(3);
                    d.Fundacao = data.GetString(4);
                    d.NumeroEmpregados = data.GetInt64(5);
                    d.Tipo = data.GetString(6);

                    JogoDAO daoJogo = new JogoDAO();
                    d.jogos = daoJogo.ListarJogosPorDesenvolvedora(d.Cnpj);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return d;
        }

        public Boolean InserirNoBD(Desenvolvedora _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO desenvolvedora (nome, presidente, fundador, fundacao, numeroempregados, tipo) "
                    + "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}')",
                    _obj.Nome,
                    _obj.Presidente,
                    _obj.Fundador,
                    _obj.Fundacao,
                    _obj.NumeroEmpregados,
                    _obj.Tipo);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean AlterarNoBD(Desenvolvedora _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE desenvolvedora SET "
                + "nome = '{0}', presidente = '{1}', fundador = '{2}', fundacao = '{3}', "
                + "numeroempregados = {4}, tipo = '{5}' WHERE cnpj = {6};",
                    _obj.Nome,
                    _obj.Presidente,
                    _obj.Fundador,
                    _obj.Fundacao,
                    _obj.NumeroEmpregados,
                    _obj.Tipo,
                    _obj.Cnpj);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean DeletarNoBD(Int64 _cnpj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM desenvolvedora WHERE cnpj = {0};", _cnpj);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Dictionary<Int64, Desenvolvedora> BuscarListaFiltrada(String _filtros)
        {
            try
            {
                Dictionary<Int64, Desenvolvedora> listDesenvolvedoras = new Dictionary<Int64, Desenvolvedora>();

                string SQL = "SELECT * FROM desenvolvedora WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("cnpj = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Desenvolvedora d = new Desenvolvedora();

                    d.Cnpj = data.GetInt64(0);
                    d.Nome = data.GetString(1);
                    d.Presidente = data.GetString(2);
                    d.Fundador = data.GetString(3);
                    d.Fundacao = data.GetString(4);
                    d.NumeroEmpregados = data.GetInt64(5);
                    d.Tipo = data.GetString(6);

                    listDesenvolvedoras.Add(d.Cnpj, d);
                }

                data.Close();
                BD.FecharConexao();

                return listDesenvolvedoras;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}

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
    public class JogoDAO
    {

        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int64, Jogo> ListarTodos()
        {
            Dictionary<Int64, Jogo> mapaJogos = new Dictionary<Int64, Jogo>();
            try
            {
                String SQL = "SELECT * FROM jogo;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Jogo j = new Jogo();

                    j.Codigo = data.GetInt64(0);
                    j.Nome = data.GetString(1);
                    j.Franquia = data.GetString(2);
                    j.Lancamento = data.GetString(3);
                    j.Genero = data.GetInt32(4);
                    j.Midia = data.GetInt32(5);
                    j.Cnpj = data.GetInt64(6);
                    j.Numero = data.GetInt64(7);

                    mapaJogos.Add(j.Codigo, j);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaJogos;
        }

        public Jogo BuscarPorID(Int64 _codigo)
        {
            Jogo j = null;
            try
            {
                String SQL = String.Format("SELECT * FROM jogo WHERE codigo = {0} ", _codigo);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    j.Codigo = data.GetInt64(0);
                    j.Nome = data.GetString(1);
                    j.Franquia = data.GetString(2);
                    j.Lancamento = data.GetString(3);
                    j.Genero = data.GetInt32(4);
                    j.Midia = data.GetInt32(5);
                    j.Cnpj = data.GetInt64(6);
                    j.Numero = data.GetInt64(7);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return j;
        }

        public Boolean InserirNoBD(Jogo _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO jogo (nome, franquia, lancamento, genero, midia, desenvolvedora_cnpj, console_numero) "
                    + "VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6})",
                    _obj.Nome,
                    _obj.Franquia,
                    _obj.Lancamento,
                    _obj.Genero,
                    _obj.Midia,
                    _obj.Cnpj,
                    _obj.Numero);

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

        public Boolean AlterarNoBD(Jogo _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE jogo SET "
                + "nome = '{0}', franquia = '{1}', lancamento = '{2}', genero = {3}, "
                + "midia = {4}, desenvolvedora_cnpj = {5}, console_numero = {6} WHERE codigo = {7};",
                    _obj.Nome,
                    _obj.Franquia,
                    _obj.Lancamento,
                    _obj.Genero,
                    _obj.Midia,
                    _obj.Cnpj,
                    _obj.Numero,
                    _obj.Codigo);

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

        public Boolean DeletarNoBD(Int64 _codigo)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM jogo WHERE codigo = {0};", _codigo);

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

        public Dictionary<Int64, Jogo> BuscarListaFiltrada(String _filtros)
        {
            try
            {
                Dictionary<Int64, Jogo> listJogos = new Dictionary<Int64, Jogo>();

                string SQL = "SELECT * FROM jogo WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("codigo = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Jogo j = new Jogo();

                    j.Codigo = data.GetInt64(0);
                    j.Nome = data.GetString(1);
                    j.Franquia = data.GetString(2);
                    j.Lancamento = data.GetString(3);
                    j.Genero = data.GetInt32(4);
                    j.Midia = data.GetInt32(5);
                    j.Cnpj = data.GetInt64(6);
                    j.Numero = data.GetInt64(7);

                    listJogos.Add(j.Codigo, j);
                }

                data.Close();
                BD.FecharConexao();

                return listJogos;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }

        public List<Jogo> ListarJogosPorConsole(Int64 _console_numero)
        {
            List<Jogo> listaJogos = new List<Jogo>();
            try
            {
                String SQL = String.Format("SELECT * FROM jogo WHERE console_numero = {0};", _console_numero);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Jogo j = new Jogo();

                    j.Codigo = data.GetInt64(0);
                    j.Nome = data.GetString(1);
                    j.Franquia = data.GetString(2);
                    j.Lancamento = data.GetString(3);
                    j.Genero = data.GetInt32(4);
                    j.Midia = data.GetInt32(5);
                    j.Cnpj = data.GetInt64(6);
                    j.Numero = data.GetInt64(7);

                    listaJogos.Add(j);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaJogos;
        }

        public List<Jogo> ListarJogosPorDesenvolvedora(Int64 _desenvolvedora_cnpj)
        {
            List<Jogo> listaJogos = new List<Jogo>();
            try
            {
                String SQL = String.Format("SELECT * FROM jogo WHERE desenvolvedora_cnpj = {0};", _desenvolvedora_cnpj);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Jogo j = new Jogo();

                    j.Codigo = data.GetInt64(0);
                    j.Nome = data.GetString(1);
                    j.Franquia = data.GetString(2);
                    j.Lancamento = data.GetString(3);
                    j.Genero = data.GetInt32(4);
                    j.Midia = data.GetInt32(5);
                    j.Cnpj = data.GetInt64(6);
                    j.Numero = data.GetInt64(7);

                    listaJogos.Add(j);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaJogos;
        }

        #endregion
    }
}

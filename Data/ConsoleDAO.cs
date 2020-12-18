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
    public class ConsoleDAO
    {
        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int64, Model.Console> ListarTodos()
        {
            Dictionary<Int64, Model.Console> mapaConsoles = new Dictionary<Int64, Model.Console>();
            try
            {
                String SQL = "SELECT * FROM console;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Model.Console c = new Model.Console();

                    c.Numero = data.GetInt64(0);
                    c.Nome = data.GetString(1);
                    c.Fabricante = data.GetString(2);
                    c.Tipo = data.GetInt32(3);
                    c.Lancamento = data.GetString(4);
                    c.Geracao = data.GetInt32(5);
                    c.TravaFisica = data.GetBoolean(6);
                    c.TravaLogica = data.GetBoolean(7);
                    
                    AcessorioDAO daoAcessorio = new AcessorioDAO();
                    c.acessorios = daoAcessorio.ListarAcessoriosPorConsole(c.Numero);

                    ControleDAO daoControle = new ControleDAO();
                    c.controles = daoControle.ListarControlesPorConsole(c.Numero);

                    JogoDAO daoJogo = new JogoDAO();
                    c.jogos = daoJogo.ListarJogosPorConsole(c.Numero);

                    mapaConsoles.Add(c.Numero, c);
                }

                data.Close();
                BD.FecharConexao();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaConsoles;
        }

        public Model.Console BuscarPorID(Int64 _Numero)
        {
            Model.Console c = null;
            try
            {
                String SQL = String.Format("SELECT * FROM console WHERE numero = {0} ", _Numero);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    c.Numero = data.GetInt64(0);
                    c.Nome = data.GetString(1);
                    c.Fabricante = data.GetString(2);
                    c.Tipo = data.GetInt32(3);
                    c.Lancamento = data.GetString(4);
                    c.Geracao = data.GetInt32(5);
                    c.TravaFisica = data.GetBoolean(6);
                    c.TravaLogica = data.GetBoolean(7);

                    AcessorioDAO daoAcessorio = new AcessorioDAO();
                    c.acessorios = daoAcessorio.ListarAcessoriosPorConsole(c.Numero);

                    ControleDAO daoControle = new ControleDAO();
                    c.controles = daoControle.ListarControlesPorConsole(c.Numero);

                    JogoDAO daoJogo = new JogoDAO();
                    c.jogos = daoJogo.ListarJogosPorConsole(c.Numero);

                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return c;
        }

        public Boolean InserirNoBD(Model.Console _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO console (nome, fabricante, tipo, lancamento, geracao, travafisica, travalogica) "
                    + "VALUES ('{0}', '{1}', {2}, '{3}', {4}, '{5}', '{6}')",
                    _obj.Nome,
                    _obj.Fabricante,
                    _obj.Tipo,
                    _obj.Lancamento,
                    _obj.Geracao,
                    _obj.TravaFisica,
                    _obj.TravaLogica);

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

        public Boolean AlterarNoBD(Model.Console _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE console SET "
                + "nome = '{0}', fabricante = '{1}', tipo = {2}, lancamento = '{3}', "
                + "geracao = {4}, travafisica = '{5}', travalogica = '{6}' WHERE numero = {7};",
                    _obj.Nome,
                    _obj.Fabricante,
                    _obj.Tipo,
                    _obj.Lancamento,
                    _obj.Geracao,
                    _obj.TravaFisica,
                    _obj.TravaLogica,
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

        public Boolean DeletarNoBD(Int64 _numero)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM console WHERE numero = {0};", _numero);

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

        public Dictionary<Int64, Model.Console> BuscarListaFiltrada(String _filtros)
        {
            try
            {
                Dictionary<Int64, Model.Console> listPessoas = new Dictionary<Int64, Model.Console>();

                string SQL = "SELECT * FROM console WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("numero = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Model.Console c = new Model.Console();

                    c.Numero = data.GetInt64(0);
                    c.Nome = data.GetString(1);
                    c.Fabricante = data.GetString(2);
                    c.Tipo = data.GetInt32(3);
                    c.Lancamento = data.GetString(4);
                    c.Geracao = data.GetInt32(5);
                    c.TravaFisica = data.GetBoolean(6);
                    c.TravaLogica = data.GetBoolean(7);

                    listPessoas.Add(c.Numero, c);
                }

                data.Close();
                BD.FecharConexao();

                return listPessoas;
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
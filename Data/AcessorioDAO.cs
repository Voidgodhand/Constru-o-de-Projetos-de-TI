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
    public class AcessorioDAO
    {

        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int64, Acessorio> ListarTodos()
        {
            Dictionary<Int64, Acessorio> mapaAcessorios = new Dictionary<Int64, Acessorio>();
            try
            {
                String SQL = "SELECT * FROM acessorio;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Acessorio a = new Acessorio();

                    a.Id = data.GetInt64(0);
                    a.Nome = data.GetString(1);
                    a.Cor = data.GetString(2);
                    a.Tipo = data.GetInt32(3);
                    a.Lancamento = data.GetString(4);
                    a.Fabricante = data.GetString(5);
                    a.Procedencia = data.GetString(6);
                    a.Numero = data.GetInt64(7);

                    mapaAcessorios.Add(a.Id, a);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaAcessorios;
        }

        public Acessorio BuscarPorID(Int64 _id)
        {
            Acessorio a = null;
            try
            {
                String SQL = String.Format("SELECT * FROM acessorio WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    a.Id = data.GetInt64(0);
                    a.Nome = data.GetString(1);
                    a.Cor = data.GetString(2);
                    a.Tipo = data.GetInt32(3);
                    a.Lancamento = data.GetString(4);
                    a.Fabricante = data.GetString(5);
                    a.Procedencia = data.GetString(6);
                    a.Numero = data.GetInt64(7);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return a;
        }

        public Boolean InserirNoBD(Acessorio _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO acessorio (nome, cor, tipo, lancamento, fabricante, procedencia, console_numero) "
                    + "VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}', {6})",
                    _obj.Nome,
                    _obj.Cor,
                    _obj.Tipo,
                    _obj.Lancamento,
                    _obj.Fabricante,
                    _obj.Procedencia,
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

        public Boolean AlterarNoBD(Acessorio _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE acessorio SET "
                + "nome = '{0}', cor = '{1}', tipo = {2}, "
                + "lancamento = '{3}', fabricante = '{4}', procedencia = '{5}',  console_numero = {6} WHERE id = {7};",
                    _obj.Nome,
                    _obj.Cor,
                    _obj.Tipo,
                    _obj.Lancamento,
                    _obj.Fabricante,
                    _obj.Procedencia,
                    _obj.Numero,
                    _obj.Id);

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

        public Boolean DeletarNoBD(Int64 _id)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM acessorio WHERE id = {0};", _id);

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

        public Dictionary<Int64, Acessorio> BuscarListaFiltrada(String _filtros)
        {
            try
            {
                Dictionary<Int64, Acessorio> listPessoas = new Dictionary<Int64, Acessorio>();

                string SQL = "SELECT * FROM acessorio WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("id = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtros);
                }

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Acessorio a = new Acessorio();

                    a.Id = data.GetInt64(0);
                    a.Nome = data.GetString(1);
                    a.Cor = data.GetString(2);
                    a.Tipo = data.GetInt32(3);
                    a.Lancamento = data.GetString(4);
                    a.Fabricante = data.GetString(5);
                    a.Procedencia = data.GetString(6);
                    a.Numero = data.GetInt64(7);

                    listPessoas.Add(a.Id, a);
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

        public List<Acessorio> ListarAcessoriosPorConsole(Int64 _console_numero)
        {
            List<Acessorio> listaAcessorios = new List<Acessorio>();
            try
            {
                String SQL = String.Format("SELECT * FROM acessorio WHERE console_numero = {0};", _console_numero);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Acessorio a = new Acessorio();

                    a.Id = data.GetInt64(0);
                    a.Nome = data.GetString(1);
                    a.Cor = data.GetString(2);
                    a.Tipo = data.GetInt32(3);
                    a.Lancamento = data.GetString(4);
                    a.Fabricante = data.GetString(5);
                    a.Procedencia = data.GetString(6);
                    a.Numero = data.GetInt64(7);

                    listaAcessorios.Add(a);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaAcessorios;
        }
        #endregion
    }
}

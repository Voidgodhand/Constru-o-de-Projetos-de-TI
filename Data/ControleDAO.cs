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
    public class ControleDAO
    {
        #region "Métodos de Acesso ao Banco de Dados"

        public Dictionary<Int64, Controle> ListarTodos()
        {
            Dictionary<Int64, Controle> mapaControles = new Dictionary<Int64, Controle>();
            try
            {
                String SQL = "SELECT * FROM controle;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Controle c = new Controle();

                    c.Seq = data.GetInt64(0);
                    c.Cor = data.GetString(1);
                    c.Fio = data.GetString(2);
                    c.Analogico = data.GetString(3);
                    c.NumeroBotoes = data.GetInt64(4);
                    c.Fabricante = data.GetString(5);
                    c.Procedencia = data.GetString(6);
                    c.Numero = data.GetInt64(7);
                    mapaControles.Add(c.Seq, c);
                }

                data.Close();
                BD.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaControles;
        }

        public Controle BuscarPorID(Int64 _seq)
        {
            Controle c = null;
            try
            {
                String SQL = String.Format("SELECT * FROM controle WHERE seq = {0} ", _seq);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    c.Seq = data.GetInt64(0);
                    c.Cor = data.GetString(1);
                    c.Fio = data.GetString(2);
                    c.Analogico = data.GetString(3);
                    c.NumeroBotoes = data.GetInt64(4);
                    c.Fabricante = data.GetString(5);
                    c.Procedencia = data.GetString(6);
                    c.Numero = data.GetInt64(7);
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

        public Boolean InserirNoBD(Controle _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO controle (cor, fio, analogico, numerobotoes, fabricante, procedencia, console_numero) "
                    + "VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', {6})",
                    _obj.Cor,
                    _obj.Fio,
                    _obj.Analogico,
                    _obj.NumeroBotoes,
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

        public Boolean AlterarNoBD(Controle _obj)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE controle SET "
                + "cor = '{0}', fio = '{1}', analogico = '{2}', numerobotoes = {3}, "
                + "fabricante = '{4}', procedencia = '{5}', console_numero = {6} WHERE seq = {7};",
                    _obj.Cor,
                    _obj.Fio,
                    _obj.Analogico,
                    _obj.NumeroBotoes,
                    _obj.Fabricante,
                    _obj.Procedencia,
                    _obj.Numero,
                    _obj.Seq);

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

        public Boolean DeletarNoBD(Int64 _seq)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM controle WHERE seq = {0};", _seq);

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

        public Dictionary<Int64, Controle> BuscarListaFiltrada(String _filtros)
        {
            try
            {
                Dictionary<Int64, Controle> listControles = new Dictionary<Int64, Controle>();

                string SQL = "SELECT * FROM controle WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtros, out saida))
                {
                    SQL += String.Format("seq = {0}", _filtros);
                }
                else
                {
                    SQL += String.Format("cor LIKE '%{0}%'", _filtros);
                }

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Controle c = new Controle();

                    c.Seq = data.GetInt64(0);
                    c.Cor = data.GetString(1);
                    c.Fio = data.GetString(2);
                    c.Analogico = data.GetString(3);
                    c.NumeroBotoes = data.GetInt64(4);
                    c.Fabricante = data.GetString(5);
                    c.Procedencia = data.GetString(6);
                    c.Numero = data.GetInt64(7);
                    listControles.Add(c.Seq, c);
                }

                data.Close();
                BD.FecharConexao();

                return listControles;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }

        public List<Controle> ListarControlesPorConsole(Int64 _console_numero)
        {
            List<Controle> listaControles = new List<Controle>();
            try
            {
                String SQL = String.Format("SELECT * FROM controle WHERE console_numero = {0};", _console_numero);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Controle c = new Controle();

                    c.Seq = data.GetInt64(0);
                    c.Cor = data.GetString(1);
                    c.Fio = data.GetString(2);
                    c.Analogico = data.GetString(3);
                    c.NumeroBotoes = data.GetInt64(4);
                    c.Fabricante = data.GetString(5);
                    c.Procedencia = data.GetString(6);
                    c.Numero = data.GetInt64(7);
                    listaControles.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaControles;
        }

        #endregion
    }
}

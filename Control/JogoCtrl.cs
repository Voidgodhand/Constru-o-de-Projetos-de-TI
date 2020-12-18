using Model;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class JogoCtrl
    {
        #region "Métodos de Acesso ao Banco de Dados"

        //ExecutarOperacaoBD escolhendo o tipo de comando e passando o parâmetro necessário para a operação
        public Object BD(char _c, Object _param)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.InserirNoBD((Jogo)_param);
                    case 'd':
                        return dao.DeletarNoBD((Int64)_param);
                    case 'u':
                        return dao.AlterarNoBD((Jogo)_param);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorID((Int64)_param);
                    case 'f':
                        return dao.BuscarListaFiltrada((String)_param);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}

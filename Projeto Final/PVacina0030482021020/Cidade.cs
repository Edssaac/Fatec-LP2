using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PVacina0030482021020
{
    class Cidade
    {
        ///Atríbutos:
        private int _idCidade;
        private string _nomeCidade;
        private string _ufCidade;

        ///Propriedades:
        public int idCidade
        {
            get { return _idCidade; }
            set { _idCidade = value; }
        }
        public string nomeCidade
        {
            get { return _nomeCidade; }
            set { _nomeCidade = value; }
        }
        public string ufCidade
        {
            get { return _ufCidade; }
            set { _ufCidade = value; }
        }

        ///Métodos:
        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtCidade;
        }

    }

}

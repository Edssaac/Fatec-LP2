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
    class Enfermeiro
    {
        ///Atributos:
        private int _idEnfermeiro;
        private string _nomeEnfermeiro;
        private string _corenEnfermeiro;

        ///Propriedades:
        public int idEnfermeiro
        {
            get { return _idEnfermeiro;  }
            set { _idEnfermeiro = value; }
        }
        public string nomeEnfermeiro
        {
            get { return _nomeEnfermeiro; }
            set { _nomeEnfermeiro = value; }
        }
        public string corenEnfermeiro
        {
            get { return _corenEnfermeiro; }
            set { _corenEnfermeiro = value; }
        }

        ///Métodos:
        public DataTable Listar()
        {
            SqlDataAdapter daEnfermeiro;
            DataTable dtEnfermeiro = new DataTable();

            try
            {
                daEnfermeiro = new SqlDataAdapter("SELECT * FROM ENFERMEIRO", frmPrincipal.conexao);
                daEnfermeiro.Fill(dtEnfermeiro);
                daEnfermeiro.FillSchema(dtEnfermeiro, SchemaType.Source);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return dtEnfermeiro;
        }

    }
}

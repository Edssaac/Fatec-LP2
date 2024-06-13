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
    class Vacina
    {
        //Atríbutos:
        private int _idVacina;
        private string _nomeVacina;
        private DateTime _dataNascVacina;
        private string _endVacina;
        private int _cidadeIdVacina; // vira da tabela cidade
        private string _cpfVacina;
        private string _rgVacina;
        private DateTime _dataVacina;
        private char _tipoVacina; // S ou N
        private char _comorbidadeVacina; // S ou N
        private char _grupoPrioriVacina; //S ou N
        private int _enfermeiroIdEnfermeiro; // vira da tabela enfermeiro

        ///Propriedades:
        public int idVacina
        {
            get { return _idVacina; }
            set { _idVacina = value; }
        }
        public string nomeVacina
        {
            get { return _nomeVacina; }
            set { _nomeVacina = value; }
        }
        public DateTime dataNascVacina
        {
            get { return _dataNascVacina; }
            set { _dataNascVacina = value; }
        }
        public string endVacina
        {
            get { return _endVacina; }
            set { _endVacina = value; }
        }
        public int cidadeIdVacina
        {
            get { return _cidadeIdVacina; }
            set { _cidadeIdVacina = value; }
        }
        public string cpfVacina
        {
            get { return _cpfVacina; }
            set { _cpfVacina = value; }
        }
        public string rgVacina
        {
            get { return _rgVacina; }
            set { _rgVacina = value; }
        }
        public DateTime dataVacina
        {
            get { return _dataVacina; }
            set { _dataVacina = value; }
        }
        public char tipoVacina
        {
            get { return _tipoVacina; }
            set { _tipoVacina = value; }
        }

        public char comorbidadeVacina
        {
            get { return _comorbidadeVacina; }
            set { _comorbidadeVacina = value; }
        }
        public char grupoPrioriVacina
        {
            get { return _grupoPrioriVacina; }
            set { _grupoPrioriVacina = value; }
        }
        public int enfermeiroIdEnfermeiro
        {
            get { return _enfermeiroIdEnfermeiro; }
            set { _enfermeiroIdEnfermeiro = value; }
        }

        ///Métodos:
        public DataTable Listar()
        {
            SqlDataAdapter daVacina;
            DataTable dtVacina = new DataTable();

            try
            {
                daVacina = new SqlDataAdapter("SELECT * FROM VACINA", frmPrincipal.conexao);
                daVacina.Fill(dtVacina);
                daVacina.FillSchema(dtVacina, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtVacina;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO VACINA VALUES " +
                                                              "(@nomeVacina," +
                                                              "@dataNascVacina," +
                                                              "@endVacina," +
                                                              "@cidadeIdcidade," +
                                                              "@cpfVacina," +
                                                              "@rgVacina," +
                                                              "@dataVacina," +
                                                              "@tipoVacina," +
                                                              "@comorbidadeVacina," +
                                                              "@grupoprioriVacina," +
                                                              "@enfermeiroIdenfermeiro)",
                                                               frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidadeVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoprioriVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdenfermeiro", SqlDbType.Int));


                mycommand.Parameters["@nomeVacina"].Value = nomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = dataNascVacina;
                mycommand.Parameters["@endVacina"].Value = endVacina;
                mycommand.Parameters["@cidadeIdcidade"].Value = cidadeIdVacina;
                mycommand.Parameters["@cpfVacina"].Value = cpfVacina;
                mycommand.Parameters["@rgVacina"].Value = rgVacina;
                mycommand.Parameters["@dataVacina"].Value = dataVacina;
                mycommand.Parameters["@tipoVacina"].Value = tipoVacina;
                mycommand.Parameters["@comorbidadeVacina"].Value = comorbidadeVacina;
                mycommand.Parameters["@grupoprioriVacina"].Value = grupoPrioriVacina;
                mycommand.Parameters["@enfermeiroIdenfermeiro"].Value = enfermeiroIdEnfermeiro;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE VACINA SET " +
                                                                 "nome_vacina=@nomeVacina," +
                                                                 "datanasc_vacina=@dataNascVacina," +
                                                                 "end_vacina=@endVacina," +
                                                                 "cidade_id_cidade=@cidadeIdcidade," +
                                                                 "cpf_vacina=@cpfVacina," +
                                                                 "rg_vacina=@rgVacina," +
                                                                 "data_vacina=@dataVacina," +
                                                                 "tipo_vacina=@tipoVacina," +
                                                                 "comorbidade_vacina=@comorbidadeVacina," +
                                                                 "grupopriori_vacina=@grupoprioriVacina," +
                                                                 "enfermeiro_id_enfermeiro=@enfermeiroIdenfermeiro" +
                                                                 " where id_vacina=@idVacina",
                frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidadeVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoprioriVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdenfermeiro", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));

                mycommand.Parameters["@nomeVacina"].Value = nomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = dataNascVacina;
                mycommand.Parameters["@endVacina"].Value = endVacina;
                mycommand.Parameters["@cidadeIdcidade"].Value = cidadeIdVacina;
                mycommand.Parameters["@cpfVacina"].Value = cpfVacina;
                mycommand.Parameters["@rgVacina"].Value = rgVacina;
                mycommand.Parameters["@dataVacina"].Value = dataVacina;
                mycommand.Parameters["@tipoVacina"].Value = tipoVacina;
                mycommand.Parameters["@comorbidadeVacina"].Value = comorbidadeVacina;
                mycommand.Parameters["@grupoprioriVacina"].Value = grupoPrioriVacina;
                mycommand.Parameters["@enfermeiroIdenfermeiro"].Value = enfermeiroIdEnfermeiro;
                mycommand.Parameters["@idVacina"].Value = idVacina;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Excluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM VACINA where id_vacina=@idVacina", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));
                mycommand.Parameters["@idVacina"].Value = idVacina;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

    }

}

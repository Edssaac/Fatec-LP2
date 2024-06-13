using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        //Atributos:
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa; 


        //Propriedades:
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }


        //Métodos são ações/comportamentos
        //virtual --> pode ser sobreescrito:
        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo:
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        //deve ser implementado
        //derived classes must implement this.

        public abstract double SalarioBruto();


    }
}

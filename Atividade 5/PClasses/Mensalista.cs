using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado
    {

        public double SalarioMensal { get; set; }


        //Chamando sem parâmetros:
        public Mensalista()
        {
        
        }

        //Chamando com parâmetros:
        public Mensalista(int matriculax, string nomex, double salariox, DateTime entadaEmpresax)
        {
            Matricula = matriculax;
            NomeEmpregado = nomex;
            SalarioMensal = salariox;
            DataEntradaEmpresa = entadaEmpresax;
        }

        //Sobreecreendo o método:
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }


    }
}

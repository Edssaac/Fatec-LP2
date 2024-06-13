using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Horista : Empregado
    {
        //prop = public int MyProperty { get; set; }

        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int diasFalta { get; set; }


        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora);
        }

        //override = sobreescrever:
        public override int TempoTrabalho()
        {
            //O método retorna um tipo span:
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (Convert.ToInt32(span.Days) - diasFalta);
        }


    }
}

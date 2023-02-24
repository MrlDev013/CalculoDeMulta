using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CalculoAutonomoMulta.Entities
{
    public class CalcularMulta
    {
        public double velocidade;
        public double CalcularMultaCarro()
        {
            return (velocidade - 100) * 0.15;
        }
        public double CalcularMultaMoto()
        {
            return (velocidade - 100) * 0.10;
        }
        public double CalcularMultaCaminhao()
        {
            return (velocidade - 100) * 0.20;
        }
    }
}

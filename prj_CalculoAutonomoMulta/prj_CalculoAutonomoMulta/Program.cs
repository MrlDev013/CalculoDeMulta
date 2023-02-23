using prj_CalculoAutonomoMulta.Entities;

namespace prj_CalculoAutonomoMulta
{
     class Program
    {
        static void Main(string[] args)
        {
            GerarVeiculo gr = new GerarVeiculo();
            for (int i = 0; i < 100; i++)
            {
                gr.Gerador();
            }
           
           
        }
    }
}
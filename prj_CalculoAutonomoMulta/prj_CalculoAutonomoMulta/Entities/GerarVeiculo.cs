using prj_CalculoAutonomoMulta.Entities.Enums;
using prj_CalculoAutonomoMulta.Entities.Enums.Caminhao;
using prj_CalculoAutonomoMulta.Entities.Enums.Carro;
using prj_CalculoAutonomoMulta.Entities.Enums.Moto;

namespace prj_CalculoAutonomoMulta.Entities
{
    internal class GerarVeiculo
    {
        public void Gerador()
        {
            Random randomType = new Random();
            int veiculoEnumRand = randomType.Next(0,3);       //Gera o valor da enumeração de tipo de veiculo

            TipoVeiculo tpVeiculo = (TipoVeiculo)veiculoEnumRand;       //Recebe o valor e completa como o tipo da enum

            Random randomM = new Random();
            int randomMarca = randomM.Next(0, 5);

            switch (tpVeiculo)
                {
                    case TipoVeiculo.Carro:
                        tpVeiculo = TipoVeiculo.Carro;
                        MarcaCarro _marcaCarro = new MarcaCarro();
                        string MarcaCarro = _marcaCarro.A_MarcaCarro[randomMarca];
                        Console.WriteLine(tpVeiculo + ": " + MarcaCarro);
                        break;
                    case TipoVeiculo.Moto:
                        MarcaMoto _marcaMoto = new MarcaMoto();
                        string MarcaMoto = _marcaMoto.A_marcaMoto[randomMarca];
                        Console.WriteLine(tpVeiculo + ": " + MarcaMoto);
                    break;
                    case TipoVeiculo.Caminhao:
                        tpVeiculo = TipoVeiculo.Caminhao;
                        MarcaCaminhao _marcaCaminhao = new MarcaCaminhao();
                        string MarcaCaminhao = _marcaCaminhao.A_MarcaCaminhao[randomMarca];
                        Console.WriteLine(tpVeiculo + ": " + MarcaCaminhao);
                        break;
                }
                
                
            
            
            
        }
    }
}

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
            int veiculoEnumRand = randomType.Next(1,2);       //Gera o valor da enumeração de tipo de veiculo

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
                #region GerarMotos
                case TipoVeiculo.Moto:
                        Random randomModeloMoto = new Random();
                        Random rdnVelocidade = new Random();

                        CalcularMulta calcMulta = new CalcularMulta();
                        
                        int rdnModeloM;
                        string ModeloMoto;

                        MarcaMoto _marcaMoto = new MarcaMoto();
                        ModeloMoto _modeloMoto = new ModeloMoto();
                        calcMulta.velocidade = rdnVelocidade.NextDouble() * (120.00 - 85.00) + 85.00;
                        string MarcaMoto = _marcaMoto.A_marcaMoto[randomMarca];
                        double multa;

                        

                        if (MarcaMoto == "Yamaha")
                        {
                            rdnModeloM = randomModeloMoto.Next(0,5);
                            ModeloMoto = _modeloMoto.A_modeloMoto[rdnModeloM];
                           
                            Console.WriteLine(tpVeiculo + ": " + MarcaMoto + " " + ModeloMoto + " | "
                                + "Velocidade: " + calcMulta.velocidade.ToString("F2") + "Km/h" + " | "
                                + "Multa: ");
                        }

                        else if (MarcaMoto == "Kawasaki")
                        {
                            rdnModeloM = randomModeloMoto.Next(5, 10);
                            ModeloMoto = _modeloMoto.A_modeloMoto[rdnModeloM];
                            Console.WriteLine(tpVeiculo + ": " + MarcaMoto + " " + ModeloMoto + "|"
                                + "Velocidade: " + calcMulta.velocidade.ToString("F2") + "Km/h");
                        }
                        else if (MarcaMoto == "Honda")
                        {
                        rdnModeloM = randomModeloMoto.Next(10, 15);
                        ModeloMoto = _modeloMoto.A_modeloMoto[rdnModeloM];
                        Console.WriteLine(tpVeiculo + ": " + MarcaMoto + " " + ModeloMoto + " | "
                                + "Velocidade: " + calcMulta.velocidade.ToString("F2") + "Km/h");
                        }
                        else if (MarcaMoto == "Suzuki")
                        {
                            rdnModeloM = randomModeloMoto.Next(15, 20);
                            ModeloMoto = _modeloMoto.A_modeloMoto[rdnModeloM];
                            Console.WriteLine(tpVeiculo + ": " + MarcaMoto + " " + ModeloMoto + " | "
                                + "Velocidade: " + calcMulta.velocidade.ToString("F2") + "Km/h");
                        }
                        else
                        {
                            rdnModeloM = randomModeloMoto.Next(20, 25);
                            ModeloMoto = _modeloMoto.A_modeloMoto[rdnModeloM];
                            Console.WriteLine(tpVeiculo + ": " + MarcaMoto + " " + ModeloMoto + " | "
                                + "Velocidade: " + calcMulta.velocidade.ToString("F2") + "Km/h");
                        }


                    break;
                    #endregion;
                    //case TipoVeiculo.Caminhao:
                    //    tpVeiculo = TipoVeiculo.Caminhao;
                    //    MarcaCaminhao _marcaCaminhao = new MarcaCaminhao();
                    //    string MarcaCaminhao = _marcaCaminhao.A_MarcaCaminhao[randomMarca];
                    //    Console.WriteLine(tpVeiculo + ": " + MarcaCaminhao);
                    //break;
            }





        }
    }
}

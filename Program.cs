using System;

namespace aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro x = new Passageiro();
           
            System.Console.WriteLine("Digite seu login : ");           
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha : ");           
            string senha = Console.ReadLine();


            x.Login(login, senha);

            if(x.TokenLogin != "" && x.TokenLogin != null)
            {
                System.Console.WriteLine("Login autorizado !!");
                System.Console.WriteLine(x.TokenLogin);

                System.Console.WriteLine(" digite o numero para determinada ação: 1 - solicitar motorista 2- Cadastro de cartão");
                string escolher = Console.ReadLine();

               switch (escolher){


                    case "1":
                    x.SolicitarMotorista();
                    break;

                    case "2":
                    x.CadastrodeCartao();
                    break;

               }
            }else
            {
                System.Console.WriteLine("Não é possivel utilizar o Aplicativo");


            }

           

           

            


        }

        
    }
}

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
            }else
            {
                System.Console.WriteLine("Não é possivel utilizar o Aplicativo");


            }

             System.Console.WriteLine(" digite o numero para determinada ação: 1 - Adicionar cartão 2 - Excluir cartão 3 - Solicitar motorista");
                string escolher = Console.ReadLine();

               switch (escolher){


                    case "1":
                    x.SolicitarMotorista();
                    break;

               }

            


        }

        
    }
}

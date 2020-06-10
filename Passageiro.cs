using System;

class Passageiro : Usuario
{
    public string SolicitarMotorista()
    {
        return "procurando motorista ....";
    }

    public bool Pagar(string statusCorrida)
    {
        if(statusCorrida == "finalizada")
        {
            return true;
        }

        return false;
    }

        public string numero { get; set;}
        public string titular { get; set; }
        public string cvv { get; set; }
        public string  bandeira { get; set; }
        

        public void CadastrodeCartao()
        {
        

            Console.WriteLine(" digite o nome do titular do cartão ");
            titular = Console.ReadLine();

            Console.WriteLine(" digite numero do cartão ");
            numero = Console.ReadLine();

            Console.WriteLine(" digite  o cvv do cartão");
                cvv = Console.ReadLine();

            Console.WriteLine(" digite  a bandeira do cartão");
             bandeira = Console.ReadLine();
        }

        public void ExcluirConta(){

        }

        //Corrida
        private string LocalInicio;
        



    }

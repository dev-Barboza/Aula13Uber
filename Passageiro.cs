using System;

class Passageiro : Usuario
{
    public void SolicitarMotorista()
    {
        
        System.Console.WriteLine("digite o destino");
        LocalDestino =  Console.ReadLine();

        System.Console.WriteLine("viagem aceita!");


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

       public string LocalDestino { get; set; }
       
        

        public void CadastrodeCartao()
        {
        

            Console.WriteLine(" digite o nome do titular do cartão ");
            titular = Console.ReadLine();

            Console.WriteLine(" digite numero do cartão ");
            numero = Console.ReadLine();

            Console.WriteLine(" digite  a bandeira do cartão");
             bandeira = Console.ReadLine();
            
            
            Console.WriteLine(" digite  o cvv do cartão");
                cvv = Console.ReadLine();

            
        }

        public void ExcluirConta(){

        }

        
        



    }

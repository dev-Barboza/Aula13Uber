using System;

class Motorista : Usuario
{
    public string Carro { get; set; }

    public string Placa { get; set; }


    public string AceitarPassageiro(string nome)
    {
        return "procurando passageiro";
    }

    public bool  ReceberPagamento(string StatusCorrida)
    {
        if(StatusCorrida == "finalizada")
        {
            return true;
        }

    
    }
}
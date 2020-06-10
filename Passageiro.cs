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
}
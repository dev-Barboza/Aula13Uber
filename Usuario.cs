using System;

class Usuario
{
    
    //resumida
    public string Nome { get; set; }

    //completa
    private int idade = 0 ;
    public int Idade
    {
        get { return idade; }
        set { if(idade > 0 ){
            idade = value;
        } }
    }

    public int Foto { get; set; }

    private string login = "matheusbarboza@gmail.com";

    private string senha = "123";

    public string LocalizacaoAtual { get; set; }


    public string TokenLogin { get; set; }

    public string TipodeAcesso { get; set; }


    public bool Login(string login , string senha)
    {
        if(this.login == login && this.senha == senha)
        {   TokenLogin = "duifhuewifh78493y984ewewr8hoq";
            return true;
        }

        return false;
    }

    public void Logout()
    {
        TokenLogin = ""; 
    }

    

 
}

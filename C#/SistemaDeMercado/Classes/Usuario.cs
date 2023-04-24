using System;

class Usuario
{
    private string nome;
    private string senha;

    public Usuario(string n, string s)
    {
        nome = n;
        senha = s;
    }
    public string GetNome()
    {
        return nome;
    } 
    public void SetNome(string n)
    {
        nome = n;
    }
    public string GetSenha()
    {
        return senha;
    }
    public void SetSenha(string s)
    {
        senha = s;
    } 
    //
    //Verifica user
    public bool VerificaUser(string x)
    {
        if(x == nome)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool VerificaSenha(string x)
    {
        if(x == senha)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //
}

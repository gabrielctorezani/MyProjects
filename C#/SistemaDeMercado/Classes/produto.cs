using System;

 class produto
{
    private string nome, tipo;
    private double valordecompra, quantidade, valoRevenda, txcompra;

    public override string ToString()
    {
    return "Produto:" + nome + ", Tipo:" + tipo;
    }

    public  produto (string n,string t, double v, double quant, double tx)
    {
      nome = n;
      valordecompra = v;
      quantidade = quant;
      tipo = t;
      txcompra = tx;
      valoRevenda = v+(v*(tx/100));
    }

  // get para atributo nome produtos

  public string getproduto()
  {
    return nome;
  }
  
  // set para atributo nome do produto
  public void setproduto(string n)
  {
    nome = n;
  }
  
  // get para atribuir valor do produto
  
 public double getvalor ()
 {
   return valordecompra;
 }
  //set para atributo valor produto
   public void setvalor (double v)
   {
     valordecompra = v;
   }
  
  // get para atribuir quantidade produto
  
  public double getquantidade ()
  {
    return quantidade;
  }
  //set para atributo valor produto
  public double setquantidade (double quant)
  {
    return quantidade;
  }

  public string gettipo ()
  {
    return tipo;
  }
  //set para atributo valor produto
  public string settipo (string t)
  {
    return tipo;
  }

  public double getvalorrevenda ()
  {
    return valoRevenda;
  }
  //set para atributo valor produto
  public double setvalorrevenda()
  {
    return valoRevenda;
  }

   public double gettx ()
  {
    return txcompra;
  }
  //set para atributo valor produto
  public double settx(double tx)
  {
    return txcompra;
  }
  //Retirada da quantidade
  public double retiraquant(double nn)
  {
    quantidade = quantidade - nn;
    return quantidade;
  }
}


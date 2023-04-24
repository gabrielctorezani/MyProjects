using System;
using System.Collections.Generic;

class loja
{
  private string lnome;
  private Endereco endereco;
  private Contato contato;
  private Cnpj cnpj;
  private List<Usuario> funcionarios;
  private List<produto> produtos;
  private List<Prateleira> prateleiras;
  private List<Caixa> caixas;
  private Carrinho carrinho;
  private double tamanho;

  

  public loja (string nome)
  {
    lnome = nome;
    endereco = new Endereco();
    contato = new Contato();
    cnpj = new Cnpj();
    funcionarios = new List<Usuario>();
    produtos = new List<produto>();
    prateleiras = new List<Prateleira>();
    caixas = new List<Caixa>();
    carrinho = new Carrinho();
    tamanho = 0;
  }
  
  //get para atributo nome loja
  public string getloja ()
  {
    return lnome;
  }
  //set para atributo nome loja
  public string setloja (string l)
  {
    return lnome;
  }

  public List<produto> getprodutos(){
    return produtos;
  }
  public List<produto> setprodutos(){
    return produtos;
  }

  public void addProduto(produto p){
    produtos.Add(p);
  }
}

using System;
using System.Threading;
using System.Collections.Generic;


class Interface{
  private loja c0 = new loja("Sistema de Mercado");

  public string NomeEmpresa(string nome){
    return $"{nome}";
  }
  
  public void BarraSuperior(loja l){
    string Barra1 = "";
    string Nome = NomeEmpresa(l.getloja());
    string Barra2 = "";
    while(Nome.Length < 38)
    {
      Nome = " "+Nome+" ";
    }
    Nome = "="+Nome+"=";
    while(Barra1.Length < Nome.Length)
    {
      Barra1 = "="+Barra1;
      Barra2 = "="+Barra2;
    }
    Console.WriteLine(Barra1);
    Console.WriteLine(Nome);
    Console.WriteLine(Barra2);
    
  }
  public void BarraInferior(loja l,int i){
    string Barra1 = "";
    string Nome = NomeEmpresa(l.getloja());
    string Barra2 = "";
    while(Nome.Length < 38)
    {
      Nome = " "+Nome+" ";
    }
    Nome = "="+Nome+"=";
    while(Barra1.Length < Nome.Length)
    {
      Barra1 = "-"+Barra1;
      Barra2 = "="+Barra2;
    }
    Console.WriteLine(Barra1);
    Transicao(i+1);
    Console.WriteLine(Barra2);
    
  }
  public void BarraSimples(loja l){
    string Barra1 = "";
    string Nome = NomeEmpresa(l.getloja());
    while(Nome.Length < 38)
    {
      Nome = " "+Nome+" ";
    }
    Nome = "="+Nome+"=";
    while(Barra1.Length < Nome.Length)
    {
      Barra1 = "-"+Barra1;
    }
    Console.WriteLine(Barra1);
  }
  public void BarraDupla(loja l,int i){
    string Barra1 = "";
    string Nome = NomeEmpresa(l.getloja());
    while(Nome.Length < 38)
    {
      Nome = " "+Nome+" ";
    }
    Nome = "="+Nome+"=";
    while(Barra1.Length < Nome.Length)
    {
      Barra1 = "="+Barra1;
    }
    Console.WriteLine(Barra1);
  }
  //Tela de opçoes
  public void Tela1(loja c0,int i)
  {
    BarraSuperior(c0);
    TelaUsuario();
    BarraInferior(c0,i);
  }
  //Tela de load
  public void preload(string p){
    string Barra1 = "";
    string load = $"Carregando{p}";
    string Barra2 = "";
    while(load.Length < 38)
    {
      load = " "+load+" ";
    }
    load = "="+load+"=";
    while(Barra1.Length < load.Length)
    {
      Barra1 = "="+Barra1;
      Barra2 = "="+Barra2;
    }
    Console.WriteLine(Barra1);
    Console.WriteLine(load);
    Console.WriteLine(Barra2);
  }
  //Metodo de load da tela
  public void load(int a){
    for(int x=0; x<a; x++){
      preload("   ");
      Clear(250);
      preload(".  ");
      Clear(250);
      preload(".. ");
      Clear(250);
      preload("...");
      Clear(250);
    }
  }
  //Método de limpar console
  public void Clear(int t){
    Sleep(t);
    Console.Clear();
  }
  //Método de pausar o sistema
  public void Sleep(int t){
    Thread.Sleep(t);
  }
  //opções de transição
  public int VerTrasicao()
  {
    int i = 999999;
    var a = "";
    while(a == "")
    {
      a = Console.ReadLine();
      if(a != "" && a is not null){i = int.Parse(a);}
      else{Console.WriteLine("Digite uma opcao valida!");}
    }
    int voltar = i;
    int sair = i+1;
    if(i == voltar){return -1;}
    if(i == sair){return -1;}
    else{return 0;}
  }
  public void Transicao(int i){
    Console.WriteLine($"{i} - Voltar.");
    Console.WriteLine($"{i+1} - Sair.");
  }

  //Lojas
  public void lojas(List<loja> l){
    int sair = 0;
    while(sair >= 0)
    {
      switch(l.Count){
        case 0:
          BarraSuperior(c0);
          CadastroLojas();
          BarraInferior(c0,1);
          VerTrasicao();
          break;
        case >0:
          BarraSuperior(c0);
          Console.WriteLine("Qual loja deseja entrar?");
          for(int idx= 0; idx<l.Count; idx++){
            Console.WriteLine($"{idx} - {l[idx].getloja()}");
          }
          Console.WriteLine(" ");
          BarraInferior(c0,l.Count);
          VerTrasicao();
          break;
      }
    }
  }
  //Cadastro de lojas
  public void CadastroLojas()
  {
    int i;
    Console.WriteLine("Não há lojas cadastradas!");
    Console.WriteLine("Deseja cadastrar uma nova loja?");
    BarraSimples(c0);
    Console.WriteLine("0 - Sim.");
    Console.WriteLine("1 - Não.");
    var comand = Console.ReadLine();
    if(comand is not null){i = int.Parse(comand.ToString());}
    else{i = 1;}
    switch(i)
    {
      case 0:
      Console.WriteLine("Entre com o nome da loja:");
      var n = Console.ReadLine();
      if(n is not null)
      {
        loja ln = new loja(n);
        int sair = 0;
        while(sair >= 0)
        {
          OpcoesCadastroLojas();
          comand = Console.ReadLine();
          if(comand is not null){i = int.Parse(comand.ToString());}
          else{i = 0;};
          switch(i)
          {
            case 0:
            //Opcao de i nulo
            break;
            case 1:
            //endereço
            ln.NovoEndereco();
            break;
            case 2:
            //contato
            break;
            case 3:
            //cnpj
            break;
            case 4:
            //funcionarios
            break;
            case 5:
            //produtos
            break;
            case 6:
            //prateleiras
            break;
            case 7:
            //caixas
            break;
            case 8:
            //carrinho
            break;
            case 9:
            //tamanho
            break;
          }
        }
      }
      else{break;}
      break;
    }
  }
  //Produtos
    public void produtos(loja e)
  {
    int sair = 0;
    List<produto> l = new List<produto>();
    l = e.getprodutos();
    while(sair >= 0)
    {
      switch(l.Count){
        case 0:
          BarraSuperior(e);
          CadastroProdutos();
          BarraInferior(e,1);
          VerTrasicao();
          break;
        case >0:
          BarraSuperior(e);
          for(int idx= 0; idx<l.Count; idx++){
            Console.WriteLine($"{idx} - {l[idx].getproduto()}");
            Console.WriteLine($"{idx} - {l[idx].getvalorrevenda()}");
            Console.WriteLine($"{idx} - {l[idx].gettipo()}");
            BarraSimples(e);
          }
          Console.WriteLine(" ");
          BarraInferior(e,l.Count);
          VerTrasicao();
          break;
      }
    }
  }
  
  //Menu de loja
  public void Menuloja(){
    Console.WriteLine(Logotipo());
    Console.WriteLine("0 - Produtos");
    Console.WriteLine("1 - Relatórios");
  }
}
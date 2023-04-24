using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
class Arquivo
{
    private StreamWriter W;
    private StreamReader R;
    private string Caminho;

    public Arquivo(StreamWriter w, StreamReader r, string c){
        W = w;
        R = r;
        Caminho = c;
    }
    public StreamWriter getw()
    {
        return W;
    }
    public StreamWriter setw()
    {
        return W;
    }
    public StreamReader getr()
    {
        return R;
    }
    public StreamReader setr()
    {
        return R;
    }
    public string getCaminho()
    {
        return Caminho;
    }
    public string setCaminho()
    {
        return Caminho;
    }
    //
    //Criar arquivo
    public void CriarArquivo(string c)
    {
        File.Create(c);
    }
    //Metodo de escrever em arquivo
    public void Escreve(string t, string c)
    {
        W = File.AppendText(c);
        for(int i=0;i<t.Length;i++)
        {
            W.WriteLine(t[i]);
        }
        W.Close();
    }
    //Metodo de ler arquivo
    public void Leitura()
    {
        R = File.OpenText(Caminho);
        while(R.EndOfStream != true)
        {
            string linha = R.ReadLine();
            Console.WriteLine(linha);
        }
        R.Close();
    }
    public List<string> LeituraLista(List<string> list)
    {
        R = File.OpenText(Caminho);
        while(R.EndOfStream != true)
        {
            string linha = R.ReadLine();
            list.Add(linha);
            list.Add("");
        }
        R.Close();
        return list;
    }


}
*/
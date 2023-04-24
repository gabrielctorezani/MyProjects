using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Artigo_arquivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            ////declarando a variavel do tipo StreamWriter para
            //abrir ou criar um arquivo para escrita
            StreamWriter x;
            //var a = Directory.GetCurrentDirectory();
            //StreamWriter x;

            ////Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            //string CaminhoNome = "C:\\Users\\gabri\\OneDrive - ynzws\\Languages\\ARQUIVOS\\arq1.txt";

            //utilizando o metodo para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            //File.Create(a);
            //x = File.CreateText(CaminhoNome);//Cria um arquivo
            //x = File.AppendText(CaminhoNome);//Abre um arquivo
    
            //aqui, exemplo de escrever no arquivo texto
            //como se fossemos criar um recibo de pagamento
/*
            //escrevendo o titulo
            x.WriteLine("Recibo de Pagamanto");
            //pulando linha sem escrita
            x.WriteLine();
            x.WriteLine();
            //escrevendo conteúdo do recibo
            x.WriteLine("Recebi do Sr: Nome do Pagador");
            x.WriteLine("a quantia de VALOR DO RECIBO (VALOR POR EXTENSO),");
            x.WriteLine("referente ao DESCRIÇÃO DO QUE FOI PAGO... ");
            x.WriteLine("CIDADE, DATA");
            x.WriteLine();
            x.WriteLine();
            x.WriteLine("__________________________________________________");
            x.WriteLine("Nome do pagador");
            x.WriteLine("CPF do pagador: CPF");
            x.WriteLine();

            //fechando o arquivo texto com o método .Close()
            x.Close();*/

            //Ler conteúdo de arquivo
            
            //StreamReader x;
            //string CaminhoNome = "C:\\Users\\gabri\\OneDrive - ynzws\\Languages\\ARQUIVOS\\arq1.txt";
            //x = File.OpenText(CaminhoNome);
            /*while(x.EndOfStream != true)
            {
            string linha = x.ReadLine();
            Console.WriteLine(linha);
            }
            x.Close();
            Console.ReadKey();*/
            //File.Delete(CaminhoNome);

        }
    }
}
using System;
internal class Program
{
    public static void Main(string[] args)
    {
        int valor_a_pagar = 0;
        int valor_pago = 0;
    
        Console.WriteLine("Informe o valor a pagar: ");
        valor_a_pagar = int.Parse(Console.ReadLine());
    
        Console.WriteLine("Informe o valor pago: ");
        valor_pago = int.Parse(Console.ReadLine());
    
        //Variáveis para guardar a quantidade de notas e moedas para o troco:
        int notas_50=0, notas_20=0, notas_10=0, notas_5=0, notas_2=0, moedas_1=0;


    
        // < Escreva aqui o seu código para calcular o troco e a quantidade de notas e moedas >
        
        int dif = valor_pago - valor_a_pagar;
        if (dif >= 50){
          notas_50 = dif/50;
          dif = dif-(notas_50*50);
        }
        if (dif >= 20){
          notas_20 = dif/20;
          dif = dif-(notas_20*20);
        }
        if (dif >= 10){
          notas_10 = dif/10;
          dif = dif-(notas_10*10);
        }
        if (dif >=  5){
          notas_5 = dif/5;
          dif = dif-(notas_5*5);
        }
        if (dif >= 2){
          notas_2 = dif/2;
          dif = dif-(notas_2*2);
        }
        if (dif >= 1){
          moedas_1 = dif/1;
          dif = dif-(moedas_1*1);
        }
        //Impressão do relatório detalhado do troco: 
        Console.WriteLine("Notas de R$50,00 .........: {0}",notas_50);
        Console.WriteLine("Notas de R$20,00 .........: {0}",notas_20);
        Console.WriteLine("Notas de R$10,00 .........: {0}",notas_10);
        Console.WriteLine("Notas de R$5,00 ..........: {0}",notas_5);
        Console.WriteLine("Notas de R$2,00 ..........: {0}",notas_2);
        Console.WriteLine("Moedas de R$1,00 .........: {0}",moedas_1);    
    
    }
}
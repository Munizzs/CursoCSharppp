﻿

 //------------------------------------------------------------------------------------------------------
  using Fundamentos.Commun.Models;

  Calculadora cal = new Calculadora();

  cal.Somar(10,5);
  cal.Subtrair(15,5);
  cal.Multiplicar(5,5);
  cal.Dividir(10,2);
  cal.Potencia(5,4);
  cal.Raiz(60);

 //-----------------------------------------------------------------------------------------------------------

//

Pessoa p1 = new Pessoa();

p1.Nome = "Muniz";
p1.Idade = 20;
p1.Apresentar();


 //Sintaxe C#: --------------------------------------------------------------------------------------

   //Declaração de Namespace:

      //using System;

   //Declaração de Classe propiedades e Método:

                  /*        public class MinhaClasse
                          {
                                Membros da classe (métodos, propriedades, etc.) aqui

                              public string Nome { get; set; }
                                  public void MeuMetodo()
                                      {
                                            Lógica do método aqui
                                      }  
                          }*/

//  Declaração de variavel

//   bool estaChovendo = true;

//   string nome = "João";
//   char letra = 'A';

   byte opcao = 1;
//   int idade = 25;

//   double pi = 3.14159265359;
//   float salario = 1500.50f;
//   decimal preco = 50.99m;  Referencia valores monetarios.

//    Saida no console

//   Console.WriteLine($"Nome: {nome}\nIdade {idade}");
//   Console.Write("Preço: R$"+preco);

//    Estruturas de Controle (if, else, switch, while, do-while, for):

//   if (idade >= 18)
//   {
//       Console.WriteLine("\nVocê é maior de idade.");
//   }
//   else
//   {
//       Console.WriteLine("\nVocê é menor de idade.");
//   }

   switch (opcao)
   {
     /* case 1:
          Console.WriteLine("Opção 1:"+pi);
          break;
      case 2:
          Console.WriteLine("Opção 2: R$"+salario);
          break;
      default:
          Console.WriteLine("Chuva: "+estaChovendo+" a-"+letra);
          break;
      */    
  }

  while (opcao < 10)
  {
       //Console.WriteLine(opcao);
      opcao++;
  }

  for (int i = 0; i < 5; i++)
  {
       //Console.WriteLine(i);
  }

   //Datas

  //DateTime dataAtual = DateTime.Now;

   //Conversores - cast

  //int a = Convert.ToInt32("10");  Aceita valores nulo "null".
  int b = int.Parse("5");

  //string x = a.ToString();

  int r = int.MaxValue;
  long m = r;

//   Console.WriteLine(a);
//   Console.WriteLine(b);
//   Console.WriteLine(x);

  //String tx = "12-";

  //int.TryParse(tx,out int xt);  Conversão de forma mais segura

 // Console.WriteLine(xt);

   //Entrada

//   Console.ReadLine();
//  Convert.ToInt32(Console.ReadLine());  Ler um numero inteiro

 //Array

   //using Fundamentos.Commun.Models;

   int[] numInt = new int[3];

   numInt[0] = 4;
   numInt[1] = 1;
   numInt[2] = 9;

   int[] newInt = new int[numInt.Length*2];
   // Array.Copy(numInt,newInt,numInt.Length);
   //  Array.Resize(ref numInt, numInt.Length +2);

   foreach(int show in newInt){
    //Console.WriteLine(show);
   }

 //Lista

//using Fundamentos.Commun.Models;

// List<string> estado = new List<string>();

// estado.Add("SP");
// estado.Add("BH");
// estado.Add("RJ");

// for(int i=0;i<estado.Count;i++){
   //Console.WriteLine($"{estado[i]}");
// }

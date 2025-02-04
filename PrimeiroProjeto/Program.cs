using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("você digitou:");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]); ;
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(altura);
            //Console.WriteLine(idade);
            //-------------------------------------------------------------------------------------------------------------------------------------
            //Operadores Comparativos:
            //operadore de maior > e menor <
            //int a = 10;
            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //menor ou igual a 10 = true
            //bool c5 = a <= 10;
            //maior ou igual a 10 = true
            //bool c6 = a >= 10;
            //-------------------------------------------------------------------------------------------------------------------------------------

            //// Operadores lógicos:
            //// operador && (E), ambas precisam ser verdadeiras pra dar true
            //bool c1 =!( 2 > 3) && 4 != 5; // true
            //Console.WriteLine(c1);
            ////resultado: false;

            //// operador || (OU) só uma precisa ser verdadeira para ser true
            //bool c2 = 2 < 3 || 4 != 5;
            //Console.WriteLine(c2);

            //// precedencia: ! > && > || 
            //bool c3 = 10 < 5; //false

            //bool c4 = c1 || c2 && c3; //true 
            //Console.WriteLine(c4);
            //-------------------------------------------------------------------------------------------------------------------------------------

            // estrutura condicional if-else

            //simples
            //if (condicao)
            //{
            //    comando1
            //    comando2
            //}         
            //numero par ou impar

            //Console.WriteLine("entre com um número inteiro");

            //int x = int.Parse(Console.ReadLine());
            //    //se X dividio por 2 == 0; resultado = true
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine($"seu numero {x} é par");
            //} else
            //{
            //    Console.WriteLine($"o número {x} é impar");
            //}


            //estrutura de encadeamento
            int hora = int.Parse(Console.ReadLine());
            // se < (menor) que 12 = true -> se dar false passa pra próxima e exclui a opção
            if (hora <= 12)     
                Console.WriteLine("bom dia");
                // hora for maior ou igual a 12, && E menor que 18 = true  -> se dar false passa pra próxima e exclui a opção
            else if (hora < 18)
            
                Console.WriteLine("boa tarde");
            else
            
                Console.WriteLine("boa noite");
         


        }
    }
}

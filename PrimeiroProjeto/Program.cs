using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
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


            ////estrutura de encadeamento
            //int hora = int.Parse(Console.ReadLine());
            //// se < (menor) que 12 = true -> se dar false passa pra próxima e exclui a opção
            //if (hora <= 12)     
            //    Console.WriteLine("bom dia");
            //    // hora for maior ou igual a 12, && E menor que 18 = true  -> se dar false passa pra próxima e exclui a opção
            //else if (hora < 18)

            //    Console.WriteLine("boa tarde");
            //else

            //    Console.WriteLine("boa noite");
            //-------------------------------------------------------------------------------------------------------------------------------------

            // Exercicio de IF - ELSE: 

            //Console.WriteLine("escreva um número");
            //int numero1 = int.Parse(Console.ReadLine());

            //if (numero1 >= 0)
            //{
            //    Console.WriteLine("numero positivo");

            //}else
            //{
            //    Console.WriteLine("numero negativo");
            //}
            //-------------------------------------------------------------------------------------------------------------------------------------

            //Funções :

            //Console.WriteLine("digite 3 números");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //double resultado = Maior(n1, n2, n3);

            //Console.WriteLine($"maior numero é igual a = {resultado}");

            //static int Maior(int a, int b, int c)
            //{
            //    int m;
            //    if (a > b || a > c)
            //    {
            //        m = a;
            //    }
            //    else if (b > c)
            //    {
            //        m = b;
            //    }else
            //    {
            //        m = c;
            //    }
            //    return m;
            //}
            //-------------------------------------------------------------------------------------------------------------------------------------

            // While 
            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido");
            //-------------------------------------------------------------------------------------------------------------------------------------

            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim).Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.*/



            //resolução 

            //Console.WriteLine("Você gosta mais de:" +
            //    "\n1 - alcool" +
            //    "\n2 - gasolina" +
            //    "\n3 - diesel");
            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;

            //int tipo = int.Parse(Console.ReadLine()); 

            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        alcool = alcool + 1;
            //    }
            //    else if (tipo == 2)
            //    {
            //        gasolina = gasolina + 1;

            //    }
            //    else if (tipo == 3)
            //    {
            //        diesel = diesel + 1;
            //    }

            //    tipo = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("muito obrigado");
            //Console.WriteLine($"Alcool: {alcool}");
            //Console.WriteLine($"Gasolina: {gasolina}");
            //Console.WriteLine($"Diesel: {diesel}");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //exercicio 02 

            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */

            //RESOLUÇÃO:

            //string[] valores = Console.ReadLine().Split(' ');

            //Console.WriteLine("digite a coordenada X abaixo:");
            //int x = int.Parse(Console.ReadLine());


            //Console.WriteLine("digite a coordenada X abaixo:");
            //int y = int.Parse(Console.ReadLine());

            //while ( x != 0 && y != 0 )
            //{
            //    if ( x > 0 && y > 0 )
            //    {
            //        Console.WriteLine("primeiro");
            //    }else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }else if(x < 0 && y < 0) {
            //        Console.WriteLine("terceiro");
            //    }else
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    valores = Console.ReadLine().Split(' ');
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);

            //-------------------------------------------------------------------------------------------------------------------------------------

            // estrutura FOR (PARA):

            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int N = int.Parse(Console.ReadLine());

            //int soma = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    Console.Write("Valor #{0}: ", i);

            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}

            //Console.WriteLine($"soma igual {soma}");
            //-------------------------------------------------------------------------------------------------------------------------------------

            // sem orientação a objetos
            // double xA, xB, xC, yA, yB, yC;

            // Console.WriteLine("entre com as medidas do triangulo X");
            // xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Console.WriteLine("entre com as medidas do triangulo Y");
            // yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // double p = (xA + xB + xC) / 2.0;
            // double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //-------------------------------------------------------------------------------------------------------------------------------------
            // com orientação a objetos

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("entre com as medidas do triangulo X");
            x.Lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Lado3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("entre com as medidas do triangulo Y");
            y.Lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.Lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.Lado3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}


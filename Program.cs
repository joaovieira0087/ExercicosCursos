using System.Globalization;
using System;
// estrutura sequencial

/* 
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"SOMA = {num1 + num2} "); 
*/



/* 
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double tt = 3.14159;
double area = tt * (raio * r().Split(' ')
Console.WriteLine($"A = {area.ToString("f4", CultureInfo.InvariantCulture)}");
*/

/*
int v1 = int.Parse(Console.ReadLine());
int v2 = int.Parse(Console.ReadLine());
int v3 = int.Parse(Console.ReadLine());
int v4 = int.Parse(Console.ReadLine());

int diferenca = (v1 * v2) - (v3 * v4);

Console.WriteLine($"DIFERENCA = {diferenca}");
*/

/*
int numFun = int.Parse(Console.ReadLine());
int HoTra = int.Parse(Console.ReadLine());
double ValoHor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double Sala =  HoTra * ValoHor;

Console.WriteLine($"NUMBER = {numFun}");
Console.WriteLine($"SALARY = {Sala.ToString("F2", CultureInfo.InvariantCulture)}");
*/

/*
string[] peca = Console.ReadLine().Split(' ');
string[] peca2 = Console.ReadLine().Split(' ');

int quant1 = int.Parse(peca[1]);
double valo1 = double.Parse(peca[2], CultureInfo.InvariantCulture);


int quant2 = int.Parse(peca2[1]);
double valo2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

double total = quant1 * valo1 + quant2 * valo2;

Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
*/

/*
string[] valor1 = (Console.ReadLine().Split(' '));

// area do triangulo
float A = float.Parse(valor1[0], CultureInfo.InvariantCulture);
float B = float.Parse(valor1[1], CultureInfo.InvariantCulture);
float C = float.Parse(valor1[2], CultureInfo.InvariantCulture);

double area = (A * C) / 2.0;
double circulo = 3.14159 * C * C;
double trapezio = (A + B) * (C / 2);
double quadrado = B * B;
double retangulo = A * B;


Console.WriteLine("TRIANGULO: " + area.ToString("F3" , CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circulo.ToString("F3" , CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3" , CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("F3" , CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + retangulo.ToString("F3" , CultureInfo.InvariantCulture));
*/

/*
Console.WriteLine("digite um numero");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
    {
        Console.WriteLine("par");
    }
    else
    Console.WriteLine("impar");
*/

/*
Console.WriteLine("QUAL HORARIO ATUAL");
int hora = int.Parse(Console.ReadLine());

if (hora < 12) 
    Console.WriteLine("bom dia");

 else if (hora < 18)
    Console.WriteLine("boa tarde");

else
    Console.WriteLine("boa noite");
*/


//DESCONTO
/*
double preco = double.Parse(Console.ReadLine());
double desconto = 0.0;

if (preco > 100.00){
    desconto = preco * 0.1;
}

Console.WriteLine(desconto);
*/

/* NUMERO POSITIVO NEGATIVO 
Console.Write("digite um numero: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
    {
        Console.WriteLine("POSITIVO");
    }
else
    {
        Console.WriteLine("NEGATIVO");
    }
*/

/*
Console.Write("digite um numero: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}
*/

//múltiplos 
/*
string[] vet = Console.ReadLine().Split( );

int num1 = int.Parse(vet[0]);
int num2 = int.Parse(vet[1]);

if (num1 % num2 == 0 || num2 % num1 == 0)
    Console.WriteLine("Sao Multiplos");
else
    Console.WriteLine("Nao sao Multiplos");
*/

/*
string[] vet = Console.ReadLine().Split( );

int num1 = int.Parse(vet[0]);
int num2 = int.Parse(vet[1]);
int duracao = 0;

if(num1 < num2){
     duracao = num2 - num1;
}
else duracao = 24 - num1 + num2;

Console.WriteLine($"O JOGO DUROU {duracao} HORA(s)");
*/

//namespace MeuProjetoConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("digite um numero");
//            int numero1 = int.Parse(Console.ReadLine());
//            int numero2 = int.Parse(Console.ReadLine());
//            int numero3 = int.Parse(Console.ReadLine());

//            int resultado = Maior(numero1, numero2, numero3);
//            Console.WriteLine($"MAIOR {resultado}");
//        }

//        static int Maior(int n1,int n2,int n3)
//        {
//            int m = 0;

//            if (n1 > n2 && n1 < n3)
//            {
//                m = n1;
//            }
//            else if (n2 > n3)
//            {
//                m = n2;
//            }
//            else 
//                m = n3;

//            return m;
//        }
//    }
//}

/*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            while(x >= 0.0 )
            {
                double rais = Math.Sqrt(x);
                Console.WriteLine($"RAIZ QUADRADA = {rais.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine("digite um numero");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("NUMERO NEGATIVO");

        }
    }
*/

/*
string[] vet = Console.ReadLine().Split(' ');

int Codi = int.Parse(vet[0], CultureInfo.InvariantCulture);
int Quanti = int.Parse(vet[1], CultureInfo.InvariantCulture);
double total = 0;


            if (Codi == 1) {
                total = Quanti * 4.0;
            }
            else if (Codi == 2) {
                total = Quanti * 4.5;
            }
            else if (Codi == 3) {
                total = Quanti * 5.0;
            }
            else if (Codi == 4) {
                total = Quanti * 2.0;
            }
            else {
                total = Quanti * 1.5;
            }

            Console.WriteLine($"VALOR R$: {total.ToString("f2", CultureInfo.InvariantCulture)}");
*/

/*
double Intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(Intervalo < 0.00 || Intervalo > 100.0)
    {
        Console.WriteLine("Fora de intervalo");
    }
    else if (Intervalo <= 25.0 )
    {
        Console.WriteLine("INTERVALO 0.25");
    }
    else if (Intervalo <= 50.0)
    {
        Console.WriteLine("INTERVALO 25.50");   
    }
    else if (Intervalo <= 75.0)
    {
        Console.WriteLine("INTERVALO 50,75");
    }
    else
    {
        Console.WriteLine("Intervalo (75,100]");
    }
*/

/*
string[] vet = Console.ReadLine().Split(' ');

double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

if(x == 0.0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (y == 0.0)
{
    Console.WriteLine("Eixo X");
}
else if (x == 0.0) 
{
    Console.WriteLine("Eixo Y");
}

else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}
else if (x < 0.0 && y > 0.0)
{
    Console.WriteLine("Q2");
}
else if (x < 0.0 && y < 0.0)
{
    Console.WriteLine("Q3");
}
else if (x > 0.0 && y < 0.0)
{
    Console.WriteLine("Q4");
}
*/

/* IMPOSTO DE RENDA 
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (salario <= 2000.00)
{
    Console.WriteLine("Isento");
}

else if (salario > 2000.00 && salario <= 3000.00)
{
    double desconto = salario - 2000.00;
    double total = desconto * 0.08;
    Console.WriteLine($"R${total.ToString("F2", CultureInfo.InvariantCulture)}");
}
else if (salario > 3000.00 && salario <= 4500.00)
{
    double desconto = salario - 3000.00;
    double total = 80.00 + desconto * 0.18;
    Console.WriteLine($"R${total.ToString("F2", CultureInfo.InvariantCulture)}");
} 

else
{
    double desconto = salario - 4500.00;
    double total = 350.00 + desconto * 0.28;
    Console.WriteLine($"R${total.ToString("F2", CultureInfo.InvariantCulture)}");
}

*/

// EXERCICIO DE REPETIÇÃO COM WHILE

/*
Console.WriteLine("DIGITE SUA SENHA");
int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Senha Invalida, Tente Novalmente:");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido");
*/


/*
string[] vet = Console.ReadLine().Split(' ');

int x = int.Parse(vet[0]);
int y = int.Parse(vet[1]);

while (x != 0 && y != 0) {
    if (x > 0 && y > 0) {
        Console.WriteLine("primeiro");
    }
    else if (x < 0 && y > 0) {
        Console.WriteLine("Segundo");
    }
    else if (x < 0 && y < 0) {
        Console.WriteLine("Terceiro");
    }
    else {
        Console.WriteLine("quarto");
    }

    vet = Console.ReadLine().Split(' ');
    x = int.Parse(vet[0]); 
    y = int.Parse(vet[1]);
}
*/




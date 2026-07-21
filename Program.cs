using System.Globalization;
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



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

string[] peca = Console.ReadLine().Split(' ');
string[] peca2 = Console.ReadLine().Split(' ');

int quant1 = int.Parse(peca[1]);
double valo1 = double.Parse(peca[2], CultureInfo.InvariantCulture);
double soma1 = quant1 * valo1;


int quant2 = int.Parse(peca2[1]);
double valo2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
double soma2 = quant2 * valo2;

double total = soma1 + soma2;

Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");





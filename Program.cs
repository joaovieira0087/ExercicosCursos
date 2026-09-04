using System.Globalization;

AreaTriangulo p = new AreaTriangulo();


Console.Write("Entre os dados");
Console.WriteLine();
Console.Write("Largura: ");
p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Altura: ");
p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();
double Total = p.AreaTotalTriangu();
double Perimetro = p.Perimetro();
double Diagonal = p.Diagonal();
Console.WriteLine($"AREA = {Total.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERÍMETRO = {Perimetro.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL = {Diagonal.ToString("F2", CultureInfo.InvariantCulture)}");




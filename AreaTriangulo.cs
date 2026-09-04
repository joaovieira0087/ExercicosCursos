using System;

class AreaTriangulo
{
    public double Largura;
    public double  Altura;


    public double AreaTotalTriangu() {
        double Area = Largura * Altura;
        return Area;
    }

    public double Perimetro() {
        double TotalPerimetro = Largura + Largura + Altura + Altura;
        return TotalPerimetro;
    }

    public double Diagonal() {
        double TotalDiagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        return TotalDiagonal;
    }
}


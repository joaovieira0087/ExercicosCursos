class Aluno {
    public string AlunoNome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double NotaFinalAluno() {
        return Nota1 + Nota2 + Nota3;
    }

    public string NotaAlunoDecisao(double notafinal) {
        if(notafinal >= 60) {
            return "APROVADO";
        } 
        else {
            return "REPROVADO";
        }
    }

    public double Restante(double notarestante) {
        return 60 - notarestante;
    }
}
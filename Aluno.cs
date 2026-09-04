class Aluno {
    public string AlunoNome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double NotaFinalAluno() {
        return Nota1 + Nota2 + Nota3;
    }

    public bool NotaAlunoDecisao() {
        if(NotaFinalAluno() >= 60.0) {
            return true;
        }
        else {
            return false;
        }
    }
        

    public double Restante() {
        return 60.0 - NotaFinalAluno();
    }
}
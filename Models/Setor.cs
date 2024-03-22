namespace apifuncionario.Models;

public class Setor
{
    public int SetorId {get;set;}
    public string? Nome {get;set;}
    public int FuncionarioId {get;set;}
    public virtual Setor? Funcionario {get;set;}
}

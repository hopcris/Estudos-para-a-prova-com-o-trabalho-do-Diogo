using System;

namespace APIdeGerenciamentoDeTarefas.Models;

public class Morador
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;


    public ICollection<TarefaConcluida> TarefasConcluidas { get; set; } = new List<TarefaConcluida>();
}
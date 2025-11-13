using System;

namespace APIdeGerenciamentoDeTarefas.Models;

public class Comodo
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    public ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
    public ICollection<TarefaConcluida> TarefasConcluidas { get; set; } = new List<TarefaConcluida>();
        
}

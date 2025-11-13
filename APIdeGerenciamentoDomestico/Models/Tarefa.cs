using System;

namespace APIdeGerenciamentoDeTarefas.Models;

public class Tarefa
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    public int ComodoId { get; set; }
    public Comodo Comodo { get; set; } = null!;
}

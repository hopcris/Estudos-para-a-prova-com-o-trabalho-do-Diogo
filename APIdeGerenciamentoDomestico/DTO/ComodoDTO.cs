using System;

namespace APIdeGerenciamentoDeTarefas.DTO;

public class ComodoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    public List<TarefaDTO> Tarefas { get; set; } = new();
}

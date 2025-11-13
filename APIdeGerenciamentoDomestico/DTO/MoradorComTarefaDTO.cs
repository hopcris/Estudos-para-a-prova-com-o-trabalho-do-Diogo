using System;

namespace APIdeGerenciamentoDeTarefas.DTO;

public class MoradorComTarefaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public List<TarefaConcluidaSimplesDTO> TarefasConcluidas { get; set; } = new();
}

public class TarefaConcluidaSimplesDTO
{
    public DateTime DataConclusao { get; set; }
    public string NomeTarefa { get; set; } = string.Empty; // opcional, se quiser mostrar o nome da tarefa também
}

using System;

namespace APIdeGerenciamentoDeTarefas.DTO;

public class TarefaComNomeComodoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string NomeComodo { get; set; } = string.Empty; // apenas o nome do cômodo
}

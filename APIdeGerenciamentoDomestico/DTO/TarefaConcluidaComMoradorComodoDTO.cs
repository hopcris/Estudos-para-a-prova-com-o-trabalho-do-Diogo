using System;

namespace APIdeGerenciamentoDeTarefas.DTO;

 public class TarefaConcluidaComMoradorComodoDTO
{
    public string NomeMorador { get; set; } = string.Empty;
    public string NomeComodo { get; set; } = string.Empty;
    public DateTime DataConclusao { get; set; } // opcional
}

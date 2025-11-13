using System;

namespace APIdeGerenciamentoDeTarefas.Models;

public class TarefaConcluida
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataConclusao { get; set; }
    public int MoradorId { get; set; }
    public Morador morador { get; set; } = null!;

}
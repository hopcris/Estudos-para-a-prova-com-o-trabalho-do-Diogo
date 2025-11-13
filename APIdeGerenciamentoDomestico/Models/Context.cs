using System;
using Microsoft.EntityFrameworkCore;

namespace APIdeGerenciamentoDeTarefas.Models;

public class Context : DbContext
{
    public DbSet<Morador> Moradores { get; set; }
    public DbSet<Comodo> Comodos { get; set; }
    public DbSet<Tarefa> Tarefas { get; set; }
    public DbSet<TarefaConcluida> TarefasConcluidas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=TarefasDeCasa.db");
    }
}

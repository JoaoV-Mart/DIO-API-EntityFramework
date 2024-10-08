using Microsoft.EntityFrameworkCore;
using DioProjetoAPIEntityFramework.Models;

namespace TrilhaApiDesafio.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
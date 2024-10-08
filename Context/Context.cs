using Microsoft.EntityFrameworkCore;
using DioProjetoAPIEntityFramework.Models;

namespace DioProjetoAPIEntityFramework.Context
{
    public class OrganizadorContext(DbContextOptions<OrganizadorContext> options) : DbContext(options)
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
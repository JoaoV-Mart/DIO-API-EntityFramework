using Microsoft.EntityFrameworkCore;
using DioProjetoAPIEntityFramework.Models;

namespace DioProjetoAPIEntityFramework.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
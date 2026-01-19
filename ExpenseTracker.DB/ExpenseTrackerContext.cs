using ExpenseTracker.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.DB
{
    public class ExpenseTrackerContext : DbContext
    {
        public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) : base(options)
        {
        }

        // Esta línea conecta tu clase Gasto con la tabla real en SQL
        public DbSet<Gasto> Gastos { get; set; }
    }
}
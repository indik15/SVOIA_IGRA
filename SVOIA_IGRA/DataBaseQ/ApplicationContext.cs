using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVOIA_IGRA.DataBaseQ
{
    public class ApplicationContext : DbContext
    {
        public DbSet<QuestionModelClass> QuestionsModels => Set<QuestionModelClass>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=QuestionsApp.db");
        }
    }
}

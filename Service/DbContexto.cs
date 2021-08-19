using Microsoft.EntityFrameworkCore;

namespace mvc_entity
{
    public class Dbcontexto : DbContext
    {
      public Dbcontexto(DbContextOptions<Dbcontexto> options) : base(options){}
      public DbSet<Alunos> Alunos{ set; get;}
    }
}
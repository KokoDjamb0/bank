using Microsoft.EntityFrameworkCore;
using static Participation_in_eventDB.PromotionDB.Students_PromotionsDB.PunishmentDB;

public class BankDbContext : DbContext
{
    public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Student { get; set; }

    public DbSet<grade> grade { get; set; }
    public DbSet<Education> Education { get; set; }
    public DbSet<Parents> Parents { get; set; }
    public DbSet<Composition_Family> Composition_Family { get; set; }
    public DbSet<Creativity_Activity> Creativity_Activity { get; set; }
    public DbSet<Eventss> Eventss { get; set; }
    public DbSet<Participation_in_event> Participation_in_event { get; set; }
    public DbSet<PROMPUN> PROMPUN { get; set; }
    public DbSet<Students_Promotions> Students_Promotions { get; set; }
    public DbSet<Punishment> Punishment { get; set; }
    public DbSet<Student_Punishments> Student_Punishments { get; set; }
    public DbSet<Student_Creativity> Student_Creativity { get; set; }
}

public class StudentDB : DbContext
    {
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
        }

    }
public class gradeDB : DbContext
{
    public DbSet<grade> grade { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
    }

}
public class EducationDB : DbContext
    {
        public DbSet<Education> Education { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
        }
}

    public class ParentsDB : DbContext
    {
        public DbSet<Parents> Parents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
        }
}    public class Composition_FamilyDB : DbContext
    {
        public DbSet<Composition_Family> Composition_Family { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
        }
}public class Creativity_ActivityDB : DbContext
    {
        public DbSet<Creativity_Activity> Creativity_Activity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
        }
}    public class EventssDB : DbContext
    {
        public DbSet<Eventss> Eventss { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
        }
}
public class Participation_in_eventDB : DbContext
{
    public DbSet<Participation_in_event> Participation_in_event { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
    }
public class PromotionDB : DbContext
    {
    public DbSet<PROMPUN> PROMPUN { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
         optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
     }
 public class Students_PromotionsDB : DbContext
        {
     public DbSet<Students_Promotions> Students_Promotions { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
      }
public class PunishmentDB : DbContext
       {
       public DbSet<Punishment> Punishment { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
          optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
                }
                public class Student_PunishmentsDB : DbContext
       {
        public DbSet<Student_Punishments> Student_Punishments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
         }
public class Student_CreativityDB : DbContext
         {
         public DbSet<Student_Creativity> Student_Creativity { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
             optionsBuilder.UseSqlServer("Data Source=DESKTOP-ORURL94;Initial Catalog=tpt4;Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True");
          }
         }
                }
            }
        }
    }
}

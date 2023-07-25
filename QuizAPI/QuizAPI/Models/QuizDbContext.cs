using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace QuizAPI.Models
{
    public class QuizDbContext:DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options):base(options)
        {
            
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Partipicant> Participations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)//Mapping için kullandığımız fonksiyon
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//tüm mapping sınıfları burada tanımlamış oluyoruz(GetExecutingAssembly sayesinde)
                                                                                     //Map işlemlerini burada da yapabiliriz ama map sınıfları daha clean kod yazmamızı sağlıyor

        }
    }
}

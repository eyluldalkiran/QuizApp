using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizAPI.Models;

namespace QuizAPI.Mappings
{
    public class PartipicantMap: IEntityTypeConfiguration<Partipicant>
    {
        public void Configure(EntityTypeBuilder<Partipicant> builder)
        {
            builder.HasData(
                new Partipicant
                {
                    PartipicantId="ASD",
                    Email="prtpcnt1@gmail.com",
                    Name="P1",
                    Score=3,
                    TimeTaken=500

                }


                );
        }
    }
}

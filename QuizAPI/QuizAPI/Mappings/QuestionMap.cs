using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizAPI.Models;

namespace QuizAPI.Mappings
{
    public class QuestionMap:IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
            new Question
            {
                QnId = 1,
                QnInWords="What does HTML stand for?",
                ImageName="",
                Option1="Hyper Trainer Marking Language",
                Option2="Hyper Text Marketing Language",
                Option3="Hyper Text Markup Leveler",
                Option4 = "Hyper Text Markup Language",
                Answer =2

            },
            new Question
            {
                QnId = 2,
                QnInWords = "The brain of any computer system is",
                ImageName = "",
                Option1 = "ALU",
                Option2 = "Memory",
                Option3 = "CPU",
                Option4 ="Control Unit",
                Answer = 2

            }



                );
        }
    }
}

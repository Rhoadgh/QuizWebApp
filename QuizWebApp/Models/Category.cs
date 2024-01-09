using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizWebApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CategoryName { get; set; }
        public string? CategoryImage { get; set; }

        //Relationship


        public List<Question> Questions { get; set; }


    }
}

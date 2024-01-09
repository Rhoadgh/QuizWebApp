using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuizWebApp.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string QnInWords { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? ImageName { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string Option1 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option2 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option3 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option4 { get; set; }

        public int Answer { get; set; }

        //Relationship
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }//Refrence navigation proprety
    }
}

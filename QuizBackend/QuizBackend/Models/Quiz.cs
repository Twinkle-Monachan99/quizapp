

using System.ComponentModel.DataAnnotations;

namespace QuizBackend.Models
{
    public class Quiz
    {   [Key]
        public int QuizId { get; set; }
        public string Title { get; set; }
    }
}

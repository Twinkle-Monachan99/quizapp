using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBackend.Models
{
    public class Question
    {   [Key]
        public int QuestId { get; set; }
        public string Text { get; set; }

        public string CorrectAnswer { get; set; }

        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }

        public int QId { get; set; }
    }
}

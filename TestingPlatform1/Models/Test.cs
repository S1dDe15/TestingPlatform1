using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TestingPlatform1.Controllers;

namespace TestingPlatform1.Models
{
    public class Test
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [DefaultValue(false)]
        public bool IsRepeatable { get; set; }
        public TestType Type { get; set; }

        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTimeOffset CreatedAt { get; set; }

        [Required]
        public DateTimeOffset PublishedAt { get; set; }

        [Required]
        public DateTimeOffset Deadline { get; set; }

        public int? DurationMinutes { get; set; }

        [DefaultValue(false)]
        public bool IsPublic { get; set; }
        public int? PassingScore { get; set; }

        public int? MaxAttemtps { get; set; }

        //навигация 
        public List<Question> Questions { get; set; }

        public List<Student> Students { get; set; }

        public List<Project> Projects { get; set; }



    }
}

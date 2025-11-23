using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace TestingPlatform1.Models
{
    public class Attempt
    {
        public int Id { get; set; }
       
        [DefaultValue("CURRENT_TIMESTAMP")]
        public DateTimeOffset StartedAt { get; set; } 

        public DateTimeOffset? SubmittedAt { get; set; }
        
        public int? Score { get; set; }
        [Required]
        public int TestId { get; set; } 
        
        [Required]
        public int StudfentId { get; set; } 

        public Test Test { get; set; } 
        public Student Student { get; set; } 
        public List<UserAttemptAnswer> UserAttemptAnswers { get; set; } 

    }
}

using System.ComponentModel.DataAnnotations;

namespace NoteBook.Models
{
    public class Note : IValidatableObject
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? HashTag { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DueDate < DateTime.Now)
            {
                yield return new ValidationResult(
                    "DueDate cannot be in the past.",
                    new[] { nameof(DueDate) });
            }
        }
    }
    
}

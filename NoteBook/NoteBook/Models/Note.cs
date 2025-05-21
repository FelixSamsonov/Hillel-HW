using System.ComponentModel.DataAnnotations;

namespace NoteBook.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } 
        public DateTime DueDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

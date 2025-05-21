using Microsoft.EntityFrameworkCore;
using NoteBook.Models;

namespace NoteBook.Data
{
    public class NoteBookDbContext : DbContext
    {
        public NoteBookDbContext (DbContextOptions<NoteBookDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}

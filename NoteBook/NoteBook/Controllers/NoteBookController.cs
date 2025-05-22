using Microsoft.AspNetCore.Mvc;
using NoteBook.Data;
using NoteBook.Models;

namespace NoteBook.Controllers
{
    public class NoteBookController : Controller
    {
        private readonly NoteBookDbContext _context;

        public NoteBookController(NoteBookDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Note> notes = _context.Notes;
            return View(notes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Note note)
        {
            if (ModelState.IsValid)
            {
                _context.Notes.Add(note);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var note = _context.Notes.Find(id);
            if (note == null)
            {
                return NotFound();
            }
            return View(note);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Note note)
        {
            if (ModelState.IsValid)
            {
                _context.Update(note);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(note);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var note = _context.Notes.Find(id);
            if (note == null)
                return NotFound();
            return View(note);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteNote(int? id)
        {
            var note = _context.Notes.Find(id);
            if (note == null)
            {
                return NotFound();
            }
            _context.Notes.Remove(note);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

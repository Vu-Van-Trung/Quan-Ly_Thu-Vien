// AuthorService.cs
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Models;
using LibraryManagement.Data;

namespace DEMO_GUI_QLTHUVIEN.Services
{
    public class AuthorService
    {
        private readonly LibraryContext _context;

        public AuthorService()
        {
            _context = new LibraryContext();
        }

        public List<Author> GetAll()
        {
            return _context.Authors.OrderBy(a => a.AuthorId).ToList();
        }

        public Author GetById(int id)
        {
            return _context.Authors.FirstOrDefault(a => a.AuthorId == id);
        }

        public void Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void Update(Author author)
        {
            var existing = _context.Authors.FirstOrDefault(a => a.AuthorId == author.AuthorId);
            if (existing != null)
            {
                existing.Name = author.Name;
                existing.QuocTich = author.QuocTich;
                existing.NgaySinh = author.NgaySinh;
                existing.Bio = author.Bio;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var author = _context.Authors.FirstOrDefault(a => a.AuthorId == id);
            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }
    }
}

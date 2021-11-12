using EducationApp.DataAccessLayer.AppContext;
using EducationApp.DataAccessLayer.Entities;
using EducationApp.DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace EducationApp.DataAccessLayer.Repositories.EFRepositpries
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationContext _context;
        public AuthorRepository()
        {
            _context = new ApplicationContext();
        }
        public AuthorRepository(ApplicationContext context)
        {
            _context = context; 
        }

        public void Delete(int AuthorId)
        {
            Author author = _context.Authors.Find(AuthorId);
            _context.Authors.Remove(author);
        }

        public IEnumerable<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetById(int AuthorId)
        {
            return _context.Authors.Find(AuthorId);
        }

        public void Insert(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Author author)
        {
            _context.Entry(author).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true); 
            GC.SuppressFinalize(this);
        }
    }
}

using EducationApp.DataAccessLayer.Entities;


namespace EducationApp.DataAccessLayer.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAll();
        Author GetById(int AuthorId);
        void Insert(Author author);
        void Update(Author author);
        void Delete(int AuthorId);
        void Save();
    }
}

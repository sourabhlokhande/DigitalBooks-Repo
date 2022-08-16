using ModelService.Data;
using ModelService.Model;

namespace AuthorApi.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _dbContext;

        public BookService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string AddBook(Books books)
        {
            try
            {
                _dbContext.BookTbl.Add(books);
                _dbContext.SaveChanges();
                return $"{books.Title} Added Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}

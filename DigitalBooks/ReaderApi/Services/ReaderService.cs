using ModelService.Data;
using ModelService.Model;

namespace ReaderApi.Services
{
    public class ReaderService : IReaderService
    {
        private readonly ApplicationDbContext _dbContext;

        public ReaderService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Books> GetBook()
        {
            try
            {
                return _dbContext.BookTbl.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}

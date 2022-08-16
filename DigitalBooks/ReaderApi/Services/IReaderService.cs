using ModelService.Model;

namespace ReaderApi.Services
{
    public interface IReaderService
    {
        IEnumerable<Books> GetBook();
    }
}
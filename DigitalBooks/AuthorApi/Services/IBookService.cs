using ModelService.Model;

namespace AuthorApi.Services
{
    public interface IBookService
    {
        string AddBook(Books books);
    }
}
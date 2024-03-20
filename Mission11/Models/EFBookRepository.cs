namespace Mission11.Models;

public class EFBookRepository : IBookRepository
{
    private BookstoreDatabaseContext _context;
    public EFBookRepository(BookstoreDatabaseContext temp)
    {
        _context = temp;
    }

    public IQueryable<Book> Books => _context.Books;
}
namespace Mission11.Models.ViewModels;

public class BooksListViewModel
{
    public IQueryable<Book> books { get; set; }
    public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
}
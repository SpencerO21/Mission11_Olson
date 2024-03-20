using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11.Models;
using Mission11.Models.ViewModels;

namespace Mission11.Controllers;

public class HomeController : Controller
{
    private IBookRepository _repo;

    public HomeController(IBookRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index(int pageNum)
    {
        int pageSize = 5;
        var booksListViewModel = new BooksListViewModel
        {
            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum,
                ItemsPerPage = pageSize,
                TotalItems = _repo.Books.Count()
            },

            books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
        };
        
        return View(booksListViewModel);
    }
    
}
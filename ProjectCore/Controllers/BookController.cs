using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Repository;
using ProjectCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var bookListViewModel = new BookListViewModel();

            bookListViewModel.books = _bookRepository.GetAllBooks();

            return View(bookListViewModel);
        }

        public IActionResult Details(int id)
        {

            var book = _bookRepository.GetBookId(id);
            if (book == null)
                return NotFound();

            return View(book);
        }
    }
}

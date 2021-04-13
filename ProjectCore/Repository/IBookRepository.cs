using ProjectCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Repository
{
    public interface IBookRepository
    {
       IEnumerable<Book> GetAllBooks();
       Book GetBookId(int id);
    }
}

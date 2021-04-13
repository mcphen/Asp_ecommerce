using ProjectCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.ViewModels
{
    public class BookListViewModel
    {
       public IEnumerable<Book> books { get; set; }
    }
}

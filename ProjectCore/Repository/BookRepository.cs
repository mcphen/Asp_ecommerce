﻿using Microsoft.EntityFrameworkCore;
using ProjectCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _appDbContext.Books.Include(c => c.Category);
        }

        public Book GetBookId(int id)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.BookId == id);
        }
    }
}

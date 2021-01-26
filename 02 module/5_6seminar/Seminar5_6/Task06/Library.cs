using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Library
    {
        Book[] _bookList;
        int _theAmountOfSections;

        public Library(int section)
        {
            _bookList = new Book[0];
            _theAmountOfSections = section;
        }

        public Library(Book[] books, int section)
        {
            books.CopyTo(_bookList, 0);
            _theAmountOfSections = section;
        }

        public int BooksCount
        {
            get
            {
                return _bookList.Length;
            }
        }

        public Book[] CountBooksWithTheLessAmountOfPages(int n)
        {
            int count = 0;
            for (int ii = 0; ii < _bookList.Length; ii++)
            {
                if (_bookList[ii].CountPages < n) count++;
            }
            int i = 0;
            Book[] books = new Book[count];
            for (int j = 0; j < _bookList.Length; j++)
            {
                if (_bookList[j].CountPages < n)
                {
                    books[i] = _bookList[j];
                    i++;
                }
            }

            return books;
        }

        public void AddBook(Book book)
        {
            Array.Resize<Book>(ref _bookList, _bookList.Length + 1);
            _bookList[_bookList.Length - 1] = book;
        }

        public override string ToString()
        {
            string str = "";
            for (int ii = 0; ii < _bookList.Length; ii++)
            {
                str += _bookList[ii].ToString() + "\n";
            }
            return $"TheAmountOfSections = {_theAmountOfSections}" + "\n" + str;
        }
    }
}

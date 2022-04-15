using System;
namespace Mission7.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPageCount => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage);
    }
}

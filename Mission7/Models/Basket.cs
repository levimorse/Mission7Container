using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem (Book book, int qty)
        {
            BasketLineItem line = Items
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                    {
                    Book = book,
                    Quantity = qty
                });
            }
                else
                {
                    line.Quantity += qty;
                }
        }

        public double CalculateTotal()
        {
            double sum = 0;

            System.Collections.IList list = Items;
            for (int i = 0; i < list.Count; i++)
            {
                sum += (Items[i].Book.Price * Items[i].Quantity);
            }
            return sum;
        }
    }


    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}

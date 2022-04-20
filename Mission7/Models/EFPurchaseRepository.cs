using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private BookstoreContext context;

        public EFPurchaseRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Purchase> Purchases => context.Purchases.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePurchase(Purchase p)
        {
            context.AttachRange(p.Lines.Select(x => x.Book));

            if (p.PurchaseId == 0)
            {
                context.Purchases.Add(p);
            }

            context.SaveChanges();
        }
    }
}

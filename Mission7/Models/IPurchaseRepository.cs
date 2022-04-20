using System;
using System.Linq;

namespace Mission7.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        public void SavePurchase(Purchase p);
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class SQLSupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext context;

        public SQLSupplierRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Supplier Add(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
            return supplier;
        }

        public Supplier Delete(int id)
        {
            Supplier supplier = context.Suppliers.Find(id);
            if (supplier != null)
            {
                context.Suppliers.Remove(supplier);
                context.SaveChanges();
            }
            return supplier;
        }

        public IEnumerable<Supplier> GetAllSupplier()
        {
            return context.Suppliers;
        }

        public Supplier GetSupplier(int Id)
        {
            return context.Suppliers.Find(Id);
        }

        public Supplier Update(Supplier supplierChanges)
        {
            var supplier = context.Suppliers.Attach(supplierChanges);
            supplier.State = EntityState.Modified;
            context.SaveChanges();
            return supplierChanges;
        }
    }
}

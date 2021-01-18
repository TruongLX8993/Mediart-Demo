using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.Domain;
using Domain.Repository;

namespace Infrastructure.Repository
{
    public class FakeInvoiceRepository : IInvoiceRepository
    {
        private IList<Invoice> _data;

        public FakeInvoiceRepository()
        {
            _data = new List<Invoice>();
            _data.Add(new Invoice()
            {
                Id = 1,
                ComId = 1,
                ComName = "test",
                Amount = 10000,
            });
            _data.Add(new Invoice()
            {
                Id = 2,
                ComId = 1,
                ComName = "test",
                Amount = 20000,
            });
            _data.Add(new Invoice()
            {
                Id = 3,
                ComId = 1,
                ComName = "test",
                Amount = 10000,
            });
            _data.Add(new Invoice()
            {
                Id = 4,
                ComId = 1,
                ComName = "test",
                Amount = 10000,
            });
        }

        public Invoice GetById(int id)
        {
            return _data[0];
        }

        public int Create(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> Search(Func<Invoice, bool> conditions, int page, int pageSize,
            out int total)
        {
            total = _data.Where(conditions).Count();
            return _data.Where(conditions)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
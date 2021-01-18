using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Domain;

namespace Domain.Repository
{
    public interface IInvoiceRepository
    {
        Invoice GetById(int id);

        int Create(Invoice invoice);

        IEnumerable<Invoice> Search(Func<Invoice, bool> conditions, int page, int pageSize, out int total);
    }
}
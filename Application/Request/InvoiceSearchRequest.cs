using System;
using System.Linq.Expressions;
using Application.Response;
using Domain.Domain;
using MediatR;

namespace Application.Request
{
    public class InvoiceSearchRequest : IRequest<InvoiceSearchResponse>
    {
        public int? Id;
        public int? ComId;
        public decimal? FromAmount;
        public decimal? ToAmount;
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        

        public Func<Invoice, bool> GetConditions()
        {
            return GetConditions;
        }

        public bool GetConditions(Invoice invoice)
        {
            return true;
        }
    }
}
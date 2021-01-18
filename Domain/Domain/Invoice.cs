using System.Collections;
using System.Collections.Generic;

namespace Domain.Domain
{
    public class Invoice
    {
        
        public int Id { get; set; }
        public string ComName { get; set; }
        public int ComId { get; set; }
        public string Pattern { get; set; }
        public string Serial { get; set; }
        public IList<InvoiceItem> Items { get; set; }
        public decimal Total { get; set; }
        public decimal VatAmount { get; set; }
        public decimal Amount { get; set; }
        
    }
}
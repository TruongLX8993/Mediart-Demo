using System.Collections.Generic;
using System.Linq;

namespace Application.Response
{
    public class InvoiceSearchResponse
    {
        public IEnumerable<InvoiceDto> Data { get; set; }
        public int Total;
        public int Page;
        public int PageSize;
    }
}
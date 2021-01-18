using Application.Response;
using MediatR;

namespace Application.Request
{
    public class InvoiceSearchByIdRequest : IRequest<InvoiceSearchResponse>
    {
        public int Id { get; set; }
    }
}
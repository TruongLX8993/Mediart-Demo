using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Request;
using Application.Response;
using AutoMapper;
using Domain.Domain;
using Domain.Repository;
using MediatR;

namespace Application.RequestHandler
{
    public class InvoiceSearchRequestHandler : IRequestHandler<InvoiceSearchRequest, InvoiceSearchResponse>
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceSearchRequestHandler(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<InvoiceSearchResponse> Handle(InvoiceSearchRequest request, CancellationToken cancellationToken)
        {
            var page = request.Page ?? 0;
            var pageSize = request.PageSize ?? 10;
            
            var mapperCfg = new MapperConfiguration(cfg => cfg.CreateMap<Invoice, InvoiceDto>());
            var mapper = new Mapper(mapperCfg);
            
            var invoices = _invoiceRepository.Search(request.GetConditions(), page, pageSize, out var total);
            var invoiceDtos = mapper.Map<IEnumerable<InvoiceDto>>(invoices);
            
            return new InvoiceSearchResponse()
            {
                Page =  page,
                PageSize =  pageSize,
                Data =  invoiceDtos
            };

        }
    }
}
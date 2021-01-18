using System.Collections.Generic;
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
    public class InvoiceSearchByIdRequestHandler : IRequestHandler<InvoiceSearchByIdRequest, InvoiceSearchResponse>
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceSearchByIdRequestHandler(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }


        public async Task<InvoiceSearchResponse> Handle(InvoiceSearchByIdRequest request,
            CancellationToken cancellationToken)
        {
            var invoice = _invoiceRepository.GetById(request.Id);
            var mapperCfg = new MapperConfiguration(cfg => cfg.CreateMap<Invoice, InvoiceDto>());
            var mapper = new Mapper(mapperCfg);

            var invoiceDto = mapper.Map<InvoiceDto>(invoice);

            return new InvoiceSearchResponse()
            {
                Page = 1,
                PageSize = 1,
                Data = new InvoiceDto[] {invoiceDto}
            };
        }
    }
}
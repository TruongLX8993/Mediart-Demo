using System.Threading.Tasks;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ApiController
    {
        [HttpPost]
        [Route("search")]
        public async Task<ActionResult<InvoiceSearchResponse>> Search([FromBody] InvoiceSearchRequest request)
        {
            return await this.Send(request);
        }
        
        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<InvoiceSearchResponse>> Get([FromQuery] InvoiceSearchByIdRequest request)
        {
            return await this.Send(request);
        }
        
    
    }
}
namespace WebApplication
{
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;

    [ApiController]
    [Route("[controller]")]
    public abstract class ApiController : ControllerBase
    {
        public const string PathSeparator = "/";
        public const string Id = "{id}";

        private IMediator? _mediator;

        private IMediator Mediator
            => this._mediator ??= this.HttpContext
                .RequestServices
                .GetService<IMediator>();

        protected async Task<ActionResult<TResult>> Send<TResult>(IRequest<TResult> request)
        {
            var result = await Mediator.Send(request);
            return result;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using CQRS.WebApi.Application.Features.ProductFeatures.Commands;
using CQRS.WebApi.Application.Features.ProductFeatures.Queries;
using CQRS.WebApi.Features.ProductFeatures.Queries;

namespace CQRS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand createProductCommand)
        {
            return Ok(await _mediator.Send(createProductCommand));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllProductsQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery() { Id = id }));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery() { Id = id }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }


    }


}
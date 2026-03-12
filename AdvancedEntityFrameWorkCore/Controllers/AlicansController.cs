using Liberyus.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace AdvancedEntityFrameWorkCore.Controllers;

[AllowAnonymous]
public class AlicansController : ApiController
{
    public AlicansController(IMediator mediator) : base(mediator)
    {
    }
}

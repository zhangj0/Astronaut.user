using Astronaut.user.applicantion.Query.UserDtetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Astronaut.user.api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _iMediator;

        public UserController(
            ILogger<WeatherForecastController> logger,
            IMediator iMediator)
        {
            _logger = logger;
            _iMediator = iMediator;
        }
        [HttpGet("GetUserDetail")]
        public QueryUserDetailDto Get(QueryUserDetailRequest request)
        {
            var userDetail = _iMediator.Send(request);
            return new QueryUserDetailDto();
        }

    }
}

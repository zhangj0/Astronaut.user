using Astronaut.user.applicantion.User.Query;
using Astronaut.user.applicantion.UserDetail.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Astronaut.user.api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _iMediator;

        public UserController(
            //ILogger<WeatherForecastController> logger,
            IMediator iMediator)
        {
            //_logger = logger;
            _iMediator = iMediator;
        }
        [HttpPost("GetUserDetail")]
        public Task<QueryUserDetailDto> Get(int userId)
        {
            var userDetail = _iMediator.Send(new QueryUserDetailRequest { UserId = userId });
            return userDetail;
        }
    }
}

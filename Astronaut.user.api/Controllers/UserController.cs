using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Astronaut.user.applicantion.UserDetail.Query;
using Astronaut.user.applicantion.User.Query;

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
        public async Task<QueryUserDetailDto> Get(int userId)
        {
            var userDetail = await _iMediator.Send(new QueryUserDetailRequest { UserId = userId });
            return userDetail;
        }
    }
}

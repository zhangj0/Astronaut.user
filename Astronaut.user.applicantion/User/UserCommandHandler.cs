using Astronaut.user.applicantion.User.Query;
using Astronaut.user.applicantion.UserDetail.Query;
using MediatR;

namespace Astronaut.user.applicantion.UserDetail
{
    public class UserCommandHandler
        : IRequestHandler<QueryUserDetailRequest, QueryUserDetailDto>
    {
        public UserCommandHandler()
        {

        }
        public async Task<QueryUserDetailDto> Handle(QueryUserDetailRequest request, CancellationToken cancellationToken)
        {
            var data=  new QueryUserDetailDto() { EmployeeEmail = "jay.jianzhang@outlook.com", EmployeeId = 1, EmployeeName = "zhangj" };
            return data;
        }
    }
}

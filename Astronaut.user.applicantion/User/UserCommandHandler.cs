using Astronaut.user.applicantion.User.Query;
using Astronaut.user.applicantion.UserDetail.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronaut.user.applicantion.UserDetail
{
    public class UserCommandHandler 
        :IRequestHandler<QueryUserDetailRequest,QueryUserDetailDto>
        //: 
        //i***<QueryUserDetailDto, QueryUserDetailRequest>
        //, i***<bool,UpdateUserByUserIdRequest>
    {
        public async Task<QueryUserDetailDto> Handle(QueryUserDetailRequest request, CancellationToken cancellationToken)
        {
            return new QueryUserDetailDto() { UserEmail = "jay.jianzhang@outlook.com", UserId = 1, UserName = "" };
        }
    }
}

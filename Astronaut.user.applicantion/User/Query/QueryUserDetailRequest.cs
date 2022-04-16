using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astronaut.user.applicantion.UserDetail.Query;
using MediatR;

namespace Astronaut.user.applicantion.User.Query
{
    public class QueryUserDetailRequest:IRequest<QueryUserDetailDto>
    {
        public int UserId { get; set; }
        public int MyProperty { get; set; }
    }
}

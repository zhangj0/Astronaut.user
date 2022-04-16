namespace Astronaut.user.applicantion.UserDetail.Query
{
    public class QueryUserDetailDto
    {
   
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

        public string? RealName { get; set; }

        public string? EmployeeEmail { get; set; }

        public bool IsEnable { get; set; }

        public string? CreatedDate { get; set; }
    }
}

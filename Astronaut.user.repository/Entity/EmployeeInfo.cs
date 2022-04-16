namespace Astronaut.user.repository.Entity
{
    partial class EmployeeInfo
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 员工Id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 员工名称
        /// </summary>
        public string? EmployeeName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string? RealName { get; set; }

        /// <summary>
        /// 员工邮箱地址
        /// </summary>
        public string? EmployeeEmail { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string? CreatedDate { get; set; }
    }
}

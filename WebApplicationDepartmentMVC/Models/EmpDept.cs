using System.ComponentModel;

namespace WebApplicationDepartmentMVC.Models
{
    public class EmpDept
    {
        [DisplayName("Department ID")]
        public int DeptId { get; set; }
        [DisplayName("Employee ID")]
        public int EmpId { get; set; }
    }
}

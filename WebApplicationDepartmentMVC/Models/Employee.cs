using System.ComponentModel;

namespace WebApplicationDepartmentMVC.Models
{
    public class Employee
    {
        [DisplayName("Employee ID")]
        public int EmpId { get; set; }
        [DisplayName("Employee Name")]
        public string EmpName { get; set; }
        [DisplayName("Employee Salary")]
        public int Salary { get; set; }
        [DisplayName("Department ID")]
        public int DeptId { get; set; }
        [DisplayName("Library ID")]
        public int? LibId { get; set; }
    }
}

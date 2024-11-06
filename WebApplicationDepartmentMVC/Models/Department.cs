using System.ComponentModel;

namespace WebApplicationDepartmentMVC.Models
{
    public class Department
    {
        [DisplayName("Department ID")]
        public int DeptId { get; set; }
        [DisplayName("Department Name")]
        public string DeptName { get; set; } = null!;
        [DisplayName("Department Location")]
        public string Location { get; set; } = null!;
    }
}

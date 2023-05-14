using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyDepartments.Models
{
    public class Department
    {

        public int Id { get; set; }

        public int IdParent { get; set; }

        public string Name { get; set; }

        public int EmployeeCount { get; set; }

    }
}

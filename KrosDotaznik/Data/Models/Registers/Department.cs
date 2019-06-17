using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Registers
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public int? ParentId { get; set; }
    }
}

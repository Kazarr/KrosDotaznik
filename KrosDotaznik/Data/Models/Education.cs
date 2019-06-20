using Data.Models.Registers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string School { get; set; }
        public string Major { get; set; }
        public int EndYear { get; set; }

        public EducationLevel EducationLevel { get; set; }
    }
}

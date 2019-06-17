using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Registers
{
    public class WorkExpiration
    {
        public int Id { get; set; }
        /// <summary>
        /// Unlimited, or will expire
        /// </summary>
        public string JobExipre { get; set; }
    }
}

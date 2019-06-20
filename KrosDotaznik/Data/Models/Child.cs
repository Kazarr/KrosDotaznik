using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Child
    {
        private DateTime _birthDate= DateTime.Now;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        /// <summary>
        /// Apllying tax bonus on child
        /// </summary>
        public bool Bonus { get; set; }

        public int IdEmployeeData { get; set; }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Credentials
    {
        public int Id { get; set; }
        public byte[] PaycheckPassword { get; set; }
        public byte[] PinAlarm { get; set; }
    }
}

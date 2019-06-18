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
        public List<byte[]> PaycheckPassword { get; set; }
        public List<byte[]> PinAlarm { get; set; }
    }
}

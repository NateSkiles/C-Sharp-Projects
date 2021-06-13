using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class ExceptionEntity
    {
        public int Id { get; set; }
        public string ExceptionTime { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ExceptionType { get; internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Field
    {
        public int Id { get; set; }
        public string dataType { get; set; }
        public string valueData { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}

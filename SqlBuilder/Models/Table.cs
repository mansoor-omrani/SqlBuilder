using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public int Name { get; set; }
        public Schema Schema { get; set; }
        public List<Column> Columns { get; set; }
    }
}

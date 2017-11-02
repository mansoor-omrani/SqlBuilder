using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Models
{
    public class Column
    {
        public int ColumnId { get; set; }
        public string Name { get; set; }
        public DataType Type { get; set; }
        public byte Precision { get; set; }
        public byte Scale { get; set; }
        public bool IsNullable { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsRowGuid { get; set; }
        public bool IsComputed { get; set; }
        public bool IsFileStream { get; set; }
        public bool IsXml { get; set; }

    }
}

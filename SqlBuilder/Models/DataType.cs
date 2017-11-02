using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Models
{
    public class DataType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public byte Precision { get; set; }
        public byte Scale { get; set; }
        public bool IsNullable { get; set; }
        public bool IsUserDefined { get; set; }
        public bool IsTableType { get; set; }
        public bool IsAssemblyType { get; set; }
    }
}

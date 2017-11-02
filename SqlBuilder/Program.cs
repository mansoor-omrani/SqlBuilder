using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
select
	t.name as [table_name],
	c.name as [column_name],
	c.max_length,
	c.precision,
	c.scale,
	c.is_nullable,
	c.is_identity,
	c.is_rowguidcol,
	c.is_computed,
	c.is_filestream,
	c.is_xml_document,
	c.system_type_id as [column_system_type_id],
	st.name as [column_sys_type_name],
	st.is_user_defined,
	st.is_table_type,
	st.is_assembly_type,
	d.name as [default_constraint_name],
	sd.name as [default_constraint_schema],
	d.[definition] as [default_constraint_definition],
	s.name as [schema_name]
from			sys.tables				t
	inner join	sys.schemas				s	on t.schema_id = s.schema_id
	inner join	sys.columns				c	on t.object_id = c.object_id
	inner join	sys.types				st	on c.system_type_id = st.system_type_id and c.user_type_id = st.user_type_id
	left  join	sys.default_constraints	d	on c.default_object_id = d.object_id
	left  join	sys.schemas				sd	on d.schema_id = sd.schema_id
order by t.name, c.column_id
             * */
        }
    }
}

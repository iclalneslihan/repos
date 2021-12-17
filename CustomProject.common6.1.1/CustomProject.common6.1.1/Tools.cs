using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace CustomProject.Common
{
    public static class Tools
    {
        private static SqlConnection  _connection;

        public static SqlConnection Connection
        {
            get
            { 
              if(_connection == null)
               {
                   _connection =new SqlConnection($"Server=.; DatabaseNorthwind; user=sa;pwd=1234;")
               }
                return _connection;
            }
            set { _connection = value; }
        }
        public static List<ET> ToList<ET>(this DataTable dt) where ET : class, new()
        {
            Type type = typeof(ET);
            List<ET> list = new List<ET>();
            PropertyInfo[] properties = type.GetProperties();
            foreach(DataRow dr in dt.Rows)
            {
                ET tip = new ET();
                foreach(PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name];
                    if (value != null)
                        pi.SetValue(tip, value);
                }
                list.Add(tip);
            }
            return list;
        }

    }
}

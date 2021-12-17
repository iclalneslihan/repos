using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomProject.Common;

namespace CustomProject.ORM
{
    public class ORMBase<ET>:IORM<ET> where ET: class,new()
    {
        public bool Delete(ET entity)
        {
            throw new NotImplementedException();
        }
        public bool Insert(ET entity)
        {
            throw new NotImplementedException();
        }
         public List<ET> Select()
                {
                    Type type = typeof(ET);
                    String query = "Select *from ";
                    var attributes = type.GetCustomAttributes(typeof(Table), false);
                    if (attributes != null && attributes.Any())
                    {
                        Table tb1 = (Table)attributes[0];
                        query += tb1.TableName + ";";
                    }
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = new SqlCommand();
                    adp.SelectCommand.CommandText = query;
                    adp.SelectCommand.Connection = Tools.Connection;
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt.ToList<ET>();
                }
        public bool Update(ET entity)
        {
            throw new NotImplementedException();
        }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ParameterUtils
    {
        public static SqlParameter[] BuildParameters(Dictionary<string, object> paramsDictionary)
        {
            SqlParameter[] parameters = new SqlParameter[paramsDictionary.Count];
            
            int index = 0;
            foreach (var param in paramsDictionary)
            {
                parameters[index] = new SqlParameter(param.Key, param.Value ?? DBNull.Value);
                index++;
            }
            
            return parameters;
        }
    }
}

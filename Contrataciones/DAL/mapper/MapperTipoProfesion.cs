using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.mapper
{
    internal class MapperTipoProfesion
    {
        private readonly Connection connection = new Connection();

        public List<Profesion> GetAll()
        {
            List<Profesion> profesiones = new List<Profesion>();
            DataTable dataTable = connection.Read("", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Profesion profesion = new Profesion
                {
                };

                profesiones.Add(profesion);
            }

            return profesiones;
        }

        public int Insert(Profesion profesion)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
            };

            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }

        public int Update(Profesion profesion)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
            };

            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }

        public int Delete(Profesion profesion)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
            };

            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }
    }
}

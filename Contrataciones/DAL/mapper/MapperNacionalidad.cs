using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL.mapper
{
    internal class MapperNacionalidad
    {
        private readonly Connection connection = new Connection();

        public List<Nacionalidad> GetAll()
        {
            List<Nacionalidad> nacionalidades = new List<Nacionalidad>();
            DataTable dataTable = connection.Read("", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Nacionalidad nacionalidad = new Nacionalidad
                {
                };

                nacionalidades.Add(nacionalidad);
            }

            return nacionalidades;
        }

        public int Insert(Nacionalidad nacionalidad)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
            };

            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }

        public int Update(Nacionalidad nacionalidad)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
            };

            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }

        public int Delete(Nacionalidad nacionalidad)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
            };

            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }
    }
}

using BE;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL.mapper
{
    public class MapperPersona
    {
        private readonly Connection connection = new Connection();

        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            //TODO: Replace "" with the actual stored procedure name
            DataTable dataTable = connection.Read("", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Persona persona = new Persona
                {
                    //TODO: Map DataRow to Persona object
                };

                personas.Add(persona);
            }

            return personas;
        }

        public Persona FindById(Persona persona) => GetAll().FirstOrDefault(p => p.NumeroPersona == persona.NumeroPersona);

        public int Insert(Persona persona)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                //TODO: Add parameters here
            };
            //TODO: Replace "" with the actual stored procedure name
            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }

        public int Update(Persona persona)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                //TODO: Add parameters here
            };
            //TODO: Replace "" with the actual stored procedure name
            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }

        public int Delete(Persona persona)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                //TODO: Add parameters here
            };
            //TODO: Replace "" with the actual stored procedure name
            return connection.Write("", ParameterUtils.BuildParameters(parameters));
        }
    }
}

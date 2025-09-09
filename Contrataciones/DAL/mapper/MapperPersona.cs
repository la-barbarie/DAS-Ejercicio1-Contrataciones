using BE;
using BE.dto;
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
            DataTable dataTable = connection.Read("sp_getAllPersonas", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Persona persona = new Persona
                {
                    NumeroPersona = (int)row["Numero_Persona"],
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Edad = (int)row["Edad"],
                    Sexo = (bool)row["Sexo"],
                    Nacionalidad = (int)row["Nacionalidad"],
                    Profesion = (int)row["Profesion"]
                };

                personas.Add(persona);
            }

            return personas;
        }

        public Persona FindById(int id)
        {
            Persona persona = null;
            DataTable dataTable = connection.Read("sp_getPersonaById", null);

            DataRow dataRow = dataTable.AsEnumerable().FirstOrDefault(r => (int)r["NumeroPersona"] == id);

            if (dataRow != null)
            {
                persona = new Persona
                {
                    NumeroPersona = (int)dataRow["NumeroPersona"],
                    Nombre = dataRow["Nombre"].ToString(),
                    Apellido = dataRow["Apellido"].ToString(),
                    Edad = (int)dataRow["Edad"],
                    Sexo = (bool)dataRow["Sexo"],
                    Nacionalidad = (int)dataRow["Nacionalidad"],
                    Profesion = (int)dataRow["Profesion"]
                };
            }

            return persona;
        }

        public int Insert(Persona persona)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nombre", persona.Nombre },
                { "@apellido", persona.Apellido },
                { "@edad", persona.Edad },
                { "@sexo", persona.Sexo },
                { "@nacionalidad", persona.Nacionalidad },
                { "@profesion", persona.Profesion }
            };
            return connection.Write("sp_insertPersona", ParameterUtils.BuildParameters(parameters));
        }

        public int Update(Persona persona)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@numero_persona", persona.NumeroPersona },
                { "@nombre", persona.Nombre },
                { "@apellido", persona.Apellido },
                { "@edad", persona.Edad },
                { "@sexo", persona.Sexo },
                { "@nacionalidad", persona.Nacionalidad },
                { "@profesion", persona.Profesion }
            };
            return connection.Write("sp_updatePersona", ParameterUtils.BuildParameters(parameters));
        }

        public int Delete(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@numero_persona", id }
            };
            return connection.Write("sp_deletePersona", ParameterUtils.BuildParameters(parameters));
        }

        public int GetPromedioEdad() => (int)connection.Scalar("sp_calculateAvergaeAge", null);

        public int GetMinOrMaxAge(int orden)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@orden", orden }
            };

            return (int)connection.Scalar("sp_calculateMinMaxAge", ParameterUtils.BuildParameters(parameters));
        }

        public int GetCantidadPersonas() => (int)connection.Scalar("sp_getCantidadPersonas", null);

        public List<PersonasNacionalidadDTO> GetCantidadPersonasPorNacionalidad()
        {
            List<PersonasNacionalidadDTO> personasAgrupadas = new List<PersonasNacionalidadDTO>();
            DataTable dataTable = connection.Read("sp_getPersonasAgrupadasPorNacionalidad", null);

            foreach (DataRow row in dataTable.Rows)
            {
                PersonasNacionalidadDTO dto = new PersonasNacionalidadDTO
                {
                    Nacionalidad = (Nacionalidad)row["Nacionalidad"],
                    CantidadPersonas = (int)row["CantidadPersonas"]
                };
                personasAgrupadas.Add(dto);
            }

            return personasAgrupadas;
        }

        public List<PromedioEdadNacionalidadDTO> GetPromedioEdadPorNacionalidad()
        {
            List<PromedioEdadNacionalidadDTO> promedios = new List<PromedioEdadNacionalidadDTO>();
            DataTable dataTable = connection.Read("sp_getPromedioEdadPorNacionalidad", null);

            foreach (DataRow row in dataTable.Rows)
            {
                PromedioEdadNacionalidadDTO dto = new PromedioEdadNacionalidadDTO
                {
                    Nacionalidad = (Nacionalidad)row["Nacionalidad"],
                    PromedioEdad = (int)row["PromedioEdad"]
                };
                promedios.Add(dto);
            }

            return promedios;
        }
    }
}

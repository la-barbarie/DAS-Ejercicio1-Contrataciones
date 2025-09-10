using BE;
using BE.dto;
using System;
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
                    NumeroPersona = (int)row["numero_persona"],
                    Nombre = row["nombre"].ToString(),
                    Apellido = row["apellido"].ToString(),
                    Edad = (int)row["edad"],
                    Sexo = (bool)row["sexo"],
                    Nacionalidad = (int)row["nacionalidad"],
                    Profesion = (int)row["profesion"]
                };

                personas.Add(persona);
            }

            return personas;
        }

        public Persona FindById(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@numero_persona", id }
            };

            DataTable dataTable = connection.Read("sp_getPersonaById", ParameterUtils.BuildParameters(parameters));
            DataRow dataRow = dataTable.Rows.Cast<DataRow>().FirstOrDefault() ?? throw new Exception("No se encontró la persona con el ID proporcionado.");

            return new Persona
            {
                NumeroPersona = (int)dataRow["numero_persona"],
                Nombre = dataRow["nombre"].ToString(),
                Apellido = dataRow["apellido"].ToString(),
                Edad = (int)dataRow["edad"],
                Sexo = (bool)dataRow["sexo"],
                Nacionalidad = (int)dataRow["nacionalidad"],
                Profesion = (int)dataRow["profesion"]
            };
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

        /// <summary>
        /// Se busca el mínimo o máximo de edad de todas las personas
        /// </summary>
        /// <param name="orden">EOrden.MAX para mayor cantidad, EOrden.MIN para menor cantidad.</param>
        /// <returns>Entero</returns>
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
                Nacionalidad nacionalidad = new Nacionalidad
                {
                    IdNacionalidad = (int)row["id_nacionalidad"],
                    Nombre = row["nombre_nacionalidad"].ToString()
                };

                PersonasNacionalidadDTO dto = new PersonasNacionalidadDTO
                {
                    Nacionalidad = nacionalidad,
                    CantidadPersonas = (int)row["cantidad_personas"]
                };
                personasAgrupadas.Add(dto);
            }

            return personasAgrupadas;
        }

        public List<PersonasNacionalidadDTO> GetCantidadPersonasPorNacionalidad(int idNacionalidad)
        {
            List<PersonasNacionalidadDTO> personasAgrupadas = new List<PersonasNacionalidadDTO>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_nacionalidad", idNacionalidad }
            };
            DataTable dataTable = connection.Read("sp_getPersonasAgrupadasPorNacionalidad", ParameterUtils.BuildParameters(parameters));

            foreach (DataRow row in dataTable.Rows)
            {
                Nacionalidad nacionalidad = new Nacionalidad
                {
                    IdNacionalidad = (int)row["id_nacionalidad"],
                    Nombre = row["nombre_nacionalidad"].ToString()
                };

                PersonasNacionalidadDTO dto = new PersonasNacionalidadDTO
                {
                    Nacionalidad = nacionalidad,
                    CantidadPersonas = (int)row["cantidad_personas"]
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
                Nacionalidad nacionalidad = new Nacionalidad
                {
                    IdNacionalidad = (int)row["id_nacionalidad"],
                    Nombre = row["nombre_nacionalidad"].ToString()
                };

                PromedioEdadNacionalidadDTO dto = new PromedioEdadNacionalidadDTO
                {
                    Nacionalidad = nacionalidad,
                    PromedioEdad = (int)row["promedio_edad"]
                };
                promedios.Add(dto);
            }

            return promedios;
        }

        public List<PromedioEdadNacionalidadDTO> GetPromedioEdadPorNacionalidad(int idNacionalidad)
        {
            List<PromedioEdadNacionalidadDTO> promedios = new List<PromedioEdadNacionalidadDTO>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_nacionalidad", idNacionalidad }
            };
            DataTable dataTable = connection.Read("sp_getPromedioEdadPorNacionalidad", ParameterUtils.BuildParameters(parameters));

            foreach (DataRow row in dataTable.Rows)
            {
                Nacionalidad nacionalidad = new Nacionalidad
                {
                    IdNacionalidad = (int)row["id_nacionalidad"],
                    Nombre = row["nombre_nacionalidad"].ToString()
                };

                PromedioEdadNacionalidadDTO dto = new PromedioEdadNacionalidadDTO
                {
                    Nacionalidad = nacionalidad,
                    PromedioEdad = (int)row["promedio_edad"]
                };
                promedios.Add(dto);
            }

            return promedios;
        }

        public List<PersonaFiltrada> GetPersonasFiltradas(FiltrosDTO filtros)
        {
            List<PersonaFiltrada> promedios = new List<PersonaFiltrada>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nombre", filtros.Nombre },
                { "@apellido", filtros.Apellido },
                { "@edad_minima", filtros.EdadMinima },
                { "@edad_maxima", filtros.EdadMaxima },
                { "@sexo", filtros.Sexo },
                { "@nacionalidad", filtros.Nacionalidad },
                { "@profesion", filtros.Profesion }
            };
            DataTable dataTable = connection.Read("sp_getPersonasFiltradas", ParameterUtils.BuildParameters(parameters));

            foreach (DataRow row in dataTable.Rows)
            {
                PersonaFiltrada personaFiltrada = new PersonaFiltrada
                {
                    NumeroPersona = (int)row["numero_persona"],
                    Nombre = row["nombre"].ToString(),
                    Apellido = row["apellido"].ToString(),
                    Edad = (int)row["edad"],
                    Sexo = (bool)row["sexo"],
                    Nacionalidad = row["nacionalidad"].ToString(),
                    Profesion = row["profesion"].ToString()
                };

                promedios.Add(personaFiltrada);
            }

            return promedios;
        }
    }
}

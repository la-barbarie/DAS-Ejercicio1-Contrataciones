using BE;
using BE.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL.mapper
{
    public class MapperNacionalidad
    {
        private readonly Connection connection = new Connection();

        public List<Nacionalidad> GetAll()
        {
            List<Nacionalidad> nacionalidades = new List<Nacionalidad>();
            DataTable dataTable = connection.Read("sp_getAllNacionalidades", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Nacionalidad nacionalidad = new Nacionalidad
                {
                    IdNacionalidad = Convert.ToInt32(row["id_nacionalidad"]),
                    Nombre = row["nombre"].ToString()
                };

                nacionalidades.Add(nacionalidad);
            }

            return nacionalidades;
        }

        public Nacionalidad FindById(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_nacionalidad", id }
            };

            DataTable dataTable = connection.Read("sp_getNacionalidadById", ParameterUtils.BuildParameters(parameters));
            DataRow dataRow = dataTable.Rows.Cast<DataRow>().FirstOrDefault() ?? throw new Exception("No se encontró la nacionalidad con el ID proporcionado.");

            return new Nacionalidad()
            {
                IdNacionalidad = Convert.ToInt32(dataRow["id_nacionalidad"]),
                Nombre = dataRow["nombre"].ToString()
            };
        }

        public int Insert(Nacionalidad nacionalidad)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nombre", nacionalidad.Nombre }
            };

            return connection.Write("sp_insertNacionalidad", ParameterUtils.BuildParameters(parameters));
        }

        public int Update(Nacionalidad nacionalidad)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_nacionalidad", nacionalidad.IdNacionalidad },
                { "@nombre", nacionalidad.Nombre }
            };

            return connection.Write("sp_updateNacionalidad", ParameterUtils.BuildParameters(parameters));
        }

        public int Delete(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_nacionalidad", id}
            };

            return connection.Write("sp_deleteNacionalidad", ParameterUtils.BuildParameters(parameters));
        }

        public PersonasNacionalidadDTO GetNacionalidadConMasOMenosPersonas(int orden)
        {
            PersonasNacionalidadDTO result = null;
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@orden", orden }
            };

            DataTable dataTable = connection.Read("sp_obtenerNacionalidadConMasOMenosPersonas", ParameterUtils.BuildParameters(parameters));
            DataRow dataRow = dataTable.Rows.Cast<DataRow>().FirstOrDefault();

            if (dataRow != null)
            {
                result = new PersonasNacionalidadDTO
                {
                    Nacionalidad = new Nacionalidad
                    {
                        IdNacionalidad = Convert.ToInt32(dataRow["id_nacionalidad"]),
                        Nombre = dataRow["nombre"].ToString()
                    },
                    CantidadPersonas = Convert.ToInt32(dataRow["cantidad_personas"]),
                };
            }

            return result;
        }
    }
}

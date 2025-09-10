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
            Nacionalidad nacionalidad = null;
            DataTable dataTable = connection.Read("sp_getNacionalidadById", null);

            DataRow row = dataTable.AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["id_nacionalidad"]) == id);

            if (row != null)
            {
                nacionalidad = new Nacionalidad
                {
                    IdNacionalidad = Convert.ToInt32(row["id_nacionalidad"]),
                    Nombre = row["nombre"].ToString()
                };
            }

            return nacionalidad;
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

        /// <summary>
        ///  Se buscan la nacionalidad con mayor o menor cantidad de personas asociadas.
        /// </summary>
        /// <param name="orden">EOrden.MAX para mayor cantidad, EOrden.MIN para menor cantidad.</param>
        /// <returns>Objeto de tipo PersonasNacionalidadDTO con la nacionalidad y la cantidad de personas asociadas.</returns>
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

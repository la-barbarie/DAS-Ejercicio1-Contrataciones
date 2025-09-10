using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.mapper
{
    public class MapperTipoProfesion
    {
        private readonly Connection connection = new Connection();

        public List<Profesion> GetAll()
        {
            List<Profesion> profesiones = new List<Profesion>();
            DataTable dataTable = connection.Read("sp_getAllProfesiones", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Profesion profesion = new Profesion
                {
                    IdProfesion = Convert.ToInt32(row["id_profesion"]),
                    Nombre = row["nombre"].ToString()
                };

                profesiones.Add(profesion);
            }

            return profesiones;
        }

        public Profesion FindById(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_profesion", id }
            };

            DataTable dataTable = connection.Read("sp_getProfesionById", ParameterUtils.BuildParameters(parameters));
            DataRow row = dataTable.Rows.Cast<DataRow>().FirstOrDefault() ?? throw new Exception("No se encontró la profesión con el ID proporcionado.");

            return new Profesion
            {
                IdProfesion = Convert.ToInt32(row["id_profesion"]),
                Nombre = row["nombre"].ToString()
            };
        }

        public int Insert(Profesion profesion)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nombre", profesion.Nombre }
            };

            return connection.Write("sp_insertProfesion", ParameterUtils.BuildParameters(parameters));
        }

        public int Update(Profesion profesion)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_profesion", profesion.IdProfesion },
                { "@nombre", profesion.Nombre }
            };

            return connection.Write("sp_updateProfesion", ParameterUtils.BuildParameters(parameters));
        }

        public int Delete(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_profesion", id },
            };

            return connection.Write("sp_deleteProfesion", ParameterUtils.BuildParameters(parameters));
        }
    }
}

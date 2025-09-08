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
            Profesion profesion = null;
            DataTable dataTable = connection.Read("sp_getProfesionById", null);

            DataRow row = dataTable.AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["id_profesion"]) == id);

            if (row != null)
            {
                profesion = new Profesion
                {
                    IdProfesion = Convert.ToInt32(row["id_profesion"]),
                    Nombre = row["nombre"].ToString()
                };
            }

            return profesion;
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

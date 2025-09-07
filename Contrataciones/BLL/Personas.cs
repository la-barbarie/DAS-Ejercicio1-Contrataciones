using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Personas
    {
        public int insertarPersona(string nombre, string apellido, int edad, bool sexo, BE.Nacionalidad nacionalidad, BE.Profesion profesion)
        {
            try
            {

                DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
                //primero consigo una ID libre

                BE.Persona p = new BE.Persona();

                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception();
                else p.Nombre = nombre;

                if (string.IsNullOrWhiteSpace(apellido)) throw new Exception();
                else p.Apellido = apellido;

                p.Edad = Math.Abs(edad); //evitamos edades negativas
                //p.Sexo = sexo; //SEXO ES UN BOOL 
                //0 - Mujer (pq son falsas y mentirosas)
                //1 - Hombre (pq somos superiores y siempre verdaderos)

                //p.Nacionalidad = nacionalidad.IdNacionalidad;
                //p.Profesion = profesion.IdProfesion;
                //ARREGLA ESTO FRANCOOOOOOOOOOOOOOOOOOOOOO

                mp.Insert(p);

                return 1;
            }
            catch (Exception e) { return -1; }

        }

        public int removerPersona(int id)
        {

        }

        public List<BE.Persona> listarPersonas()
        {
            DAL.mapper.MapperPersona mp = new DAL.mapper.MapperPersona();
            return mp.GetAll();
        }

    }
}

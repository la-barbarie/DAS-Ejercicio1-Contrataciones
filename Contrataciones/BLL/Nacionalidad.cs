using BE.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Nacionalidad
    {
        public int InsertarNacionalidad(string nombre)
        {
            try
            {

                DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();

                BE.Nacionalidad n = new BE.Nacionalidad();

                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else n.Nombre = nombre;

                return mp.Insert(n);

            }
            catch (Exception e) { throw e; }

        }

        public int RemoverProfesion(int numero)
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.Delete(numero);
        }

        public int EditarPersona(int id, string nombre)
        {
            try
            {

                DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();

                BE.Nacionalidad n = new BE.Nacionalidad();

                n.IdNacionalidad = id;

                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es invalido");
                else n.Nombre = nombre;

                return mp.Update(n);

            }
            catch (Exception e) { throw e; }
        }

        public BE.Nacionalidad GetById(int id)
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.FindById(id);
        }

        public List<BE.Nacionalidad> ListarPersonas()
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.GetAll();
        }

        public BE.dto.PersonasNacionalidadDTO GetMinPersonasRegistradas()
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.GetNacionalidadConMasOMenosPersonas(((int)EOrden.MIN));
        }

        public BE.dto.PersonasNacionalidadDTO GetMaxPersonasRegistradas()
        {
            DAL.mapper.MapperNacionalidad mp = new DAL.mapper.MapperNacionalidad();
            return mp.GetNacionalidadConMasOMenosPersonas((int)EOrden.MAX);
        }

    }
}


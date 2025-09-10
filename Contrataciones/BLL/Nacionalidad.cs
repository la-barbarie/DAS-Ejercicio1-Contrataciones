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
        public int EditarNacionalidad(int id, string nombre)
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
        public int RemoverNacionalidad(int numero) => new DAL.mapper.MapperNacionalidad().Delete(numero);
        public BE.Nacionalidad GetById(int id) => new DAL.mapper.MapperNacionalidad().FindById(id);
        public List<BE.Nacionalidad> ListarNacionalidades() => new DAL.mapper.MapperNacionalidad().GetAll();
        public BE.dto.PersonasNacionalidadDTO GetMinPersonasRegistradas() => new DAL.mapper.MapperNacionalidad().GetNacionalidadConMasOMenosPersonas((int)EOrden.MIN);
        public BE.dto.PersonasNacionalidadDTO GetMaxPersonasRegistradas() => new DAL.mapper.MapperNacionalidad().GetNacionalidadConMasOMenosPersonas((int)EOrden.MAX);
    }
}


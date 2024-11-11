using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PartidoBusiness
    {
        private PartidoData partidoData = new PartidoData();
        public void savePartido(Partido partido)
        {
            try
            {
                if (partido.EquipoLocal.Length < 5 || partido.EquipoVisitante.Length < 5 )
                {
                    throw new Exception("Debe ingresar equipos validos, con caracteres mayores a 5");
                }
                if (partido.EquipoLocal == null || partido.EquipoVisitante == null)
                {
                    throw new Exception("No se ha cargado correctamente a los equipos");
                }                
                if(partido.IdDeporte.ToString() == null)
                {
                    throw new Exception("Debe seleccionar un deporte");
                }
                if(partido.FechaPartido.Date < DateTime.Today)
                {
                    throw new Exception("La fecha del partido no puede ser menor a la fecha actual");
                }
                partido.FechaRegistro = DateTime.Now;
                partido.MarcadorLocal = 0;                
                partido.MarcadorVisitante = 0;
                partidoData.agregarPartido(partido);

            }
            catch (Exception ex)
            {
                throw;
            }

        }
       
        public void modificarPartido(int id, DateTime fechaPartido, int local, int visitante)
        {
            try
            {
                if (fechaPartido.Date != DateTime.Today)
                {
                    throw new Exception("Solo se pueden modificar partidos del dia de hoy");
                }
                if (local.ToString() == null && visitante.ToString() == null)
                {
                    throw new Exception("Los marcadores ingresados son invalidos");
                }
                partidoData.modificarPartido(id, local, visitante);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarPartido(int id)
        {
            try
            {
                partidoData.borrarPartido(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Partido> obtenerPartidos()
        {
            try
            {
                return partidoData.obtenerPartidos();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}

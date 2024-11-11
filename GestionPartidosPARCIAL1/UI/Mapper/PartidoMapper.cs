using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class PartidoMapper
    {
        public static Partido Map(SqlDataReader reader, Deporte deporte)
        {
            Partido partido = new Partido();
            partido.IdPartido = Convert.ToInt32(reader["ID_PARTIDO"].ToString());
            partido.EquipoLocal = reader["equipo_local"].ToString();
            partido.EquipoVisitante = reader["equipo_visitante"].ToString();
            partido.FechaRegistro = Convert.ToDateTime(reader["fecha_registro"].ToString());
            partido.FechaPartido = Convert.ToDateTime(reader["fecha_partido"].ToString());
            partido.MarcadorLocal = Convert.ToInt32(reader["marcador_local"].ToString());
            partido.MarcadorVisitante = Convert.ToInt32(reader["marcador_visitante"].ToString()); 
            partido.Deporte = deporte;
            return partido;
        }
    }
}

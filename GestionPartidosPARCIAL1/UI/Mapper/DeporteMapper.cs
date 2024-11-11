using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class DeporteMapper
    {
        public static Deporte Map(SqlDataReader reader)
        {
            Deporte deporte = new Deporte();
            deporte.IdDeporte = reader.GetInt32(0);
            deporte.Descripcion = reader.GetString(1);            
            return deporte;
        }
    }
}

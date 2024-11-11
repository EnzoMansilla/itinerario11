using ENTITY;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeporteData
    {
        public List<Deporte> obtenerDeportes()
        {
            try
            {
                List<Deporte> deportes = new List<Deporte>();                
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString))
                {
                    con.Open();
                    string query = "SELECT ID_DEPORTE, DESCRIPCION FROM DEPORTE";
                    using (SqlCommand sqlCommand = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Deporte p = new Deporte
                                {
                                    IdDeporte = reader.GetInt32(0),
                                    Descripcion = reader.GetString(1)
                                };
                                deportes.Add(p);
                            }
                        }
                    }
                }
                return deportes;
            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}

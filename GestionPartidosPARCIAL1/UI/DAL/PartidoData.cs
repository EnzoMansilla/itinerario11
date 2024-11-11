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
    public class PartidoData
    {
      

        public void modificarPartido(int id, int local, int visitante)
        {            

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString))
                {
                    con.Open();
                    string query = "UPDATE PARTIDO SET marcador_local = @mlocal , marcador_visitante = @mvisitante WHERE ID_PARTIDO = @idPartido";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@idPartido", id);
                        command.Parameters.AddWithValue("@mlocal", local);
                        command.Parameters.AddWithValue("@mvisitante", visitante);
                        command.ExecuteNonQuery();
                    }
                }
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
                List<Partido> listPartidos = new List<Partido>();                
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT ID_PARTIDO,ID_DEPORTE,equipo_local,equipo_visitante,fecha_registro,fecha_partido,marcador_local,marcador_visitante FROM PARTIDO";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Partido p = new Partido
                                {
                                    IdPartido = Convert.ToInt32(reader["ID_PARTIDO"].ToString()),
                                    IdDeporte = Convert.ToInt32(reader["ID_DEPORTE"].ToString()),
                                    EquipoLocal = reader["equipo_local"].ToString(),
                                    EquipoVisitante = reader["equipo_visitante"].ToString(),
                                    FechaRegistro = Convert.ToDateTime(reader["fecha_registro"].ToString()),
                                    FechaPartido = Convert.ToDateTime(reader["fecha_partido"].ToString()),
                                    MarcadorLocal = Convert.ToInt32(reader["marcador_local"].ToString()),
                                    MarcadorVisitante = Convert.ToInt32(reader["marcador_visitante"].ToString()),
                                };
                                listPartidos.Add(p);
                            }
                        }
                    }
                }
                return listPartidos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void borrarPartido(int id)
        {            
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString))
                {
                    con.Open();
                    string query = "DELETE FROM PARTIDO WHERE ID_PARTIDO = @idPartido";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@idPartido", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void agregarPartido(Partido partido)
        {            
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString))
                {
                    connection.Open();
                    string insert = "INSERT INTO PARTIDO (ID_DEPORTE, equipo_local, equipo_visitante,fecha_registro,fecha_partido,marcador_local,marcador_visitante) " +
                        " VALUES(@idDeporte, @equipoLocal, @equipoVisitante, @fecha_reg, @fecha_partido,@marcadorLocal,@marcadorVisitante )";
                    using (SqlCommand command = new SqlCommand(insert, connection))
                    {
                        command.Parameters.AddWithValue("@idDeporte", partido.IdDeporte);
                        command.Parameters.AddWithValue("@equipoLocal", partido.EquipoLocal);
                        command.Parameters.AddWithValue("@equipoVisitante", partido.EquipoVisitante);
                        command.Parameters.AddWithValue("@fecha_reg", partido.FechaRegistro);
                        command.Parameters.AddWithValue("@fecha_partido", partido.FechaPartido);
                        command.Parameters.AddWithValue("@marcadorLocal", partido.MarcadorLocal);
                        command.Parameters.AddWithValue("@marcadorVisitante", partido.MarcadorVisitante);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

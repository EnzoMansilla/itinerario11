using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeporteBusiness
    {
        private DeporteData deporteData = new DeporteData();

        public List<Deporte> obtenerDeportes()
        {
            return deporteData.obtenerDeportes();
        }

    }
}

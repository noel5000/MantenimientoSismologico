using MantenimientoEstaciones.Web.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MantenimientoEstaciones.Web.Service
{
    public class Dataservice
        
    {
        IWebHostEnvironment hostEnvironment;
        public Dataservice(IWebHostEnvironment webHost) 
        {
            this.hostEnvironment = webHost;
        }

        public List<Estacion> ObtenerEstaciones() 
        {
            List<Estacion> resultado = new List<Estacion>();

            return resultado;
        }

        public Estacion ObtenerEstacionPorId( string id)
        {
           Estacion resultado = new Estacion();

            return resultado;
        }

        public List<Mantenimiento> ObtenerMantenimientosDeEstacion(string id)
        {
            List<Mantenimiento> resultado = new List<Mantenimiento>();

            return resultado;
        }

        public Estacion GuardarEstacion(Estacion estacion) 
        {
            Estacion resultado = new Estacion();

            return resultado;
        }

        public Mantenimiento GuardarMantenimiento(Mantenimiento mantenimiento)
        {
            Mantenimiento resultado = new Mantenimiento();

            return resultado;
        }

        public Estacion ActualizarEstacion(Estacion estacion)
        {
            Estacion resultado = new Estacion();

            return resultado;
        }

        public Mantenimiento ActualizarMantenimiento(Mantenimiento mantenimiento)
        {
            Mantenimiento resultado = new Mantenimiento();

            return resultado;
        }

        public long BorrarMantenimiento(Mantenimiento mantenimiento) 
        {
            
            return -1;
        }

        public long BorrarEstacion(Estacion estacion)
        {

            return -1;
        }
    }
}

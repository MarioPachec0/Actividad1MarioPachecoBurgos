﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDAL
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from tipoprod";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "insert into TipoProd values('" + tipoProd.Nombre + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}

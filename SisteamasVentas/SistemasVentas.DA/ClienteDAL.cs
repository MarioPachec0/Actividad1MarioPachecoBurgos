﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into Cliente values('"+ cliente.IdCliente +"','" + cliente.TipoCliente + "','" + cliente.CodigoCliente + "'," +"'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}

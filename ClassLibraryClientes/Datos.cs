﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClientes
{
    public class Datos
    {
        public SqlConnection conexion = new SqlConnection("Data Source=200.36.208.13;Initial Catalog=pooipvg;User ID=ipvg;Password=ipvg");

        public void Conectar()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
        }

        public void Desconectar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

        public DataSet listado(string query)
        {
            Conectar();
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            adapter.Fill(data);
            Desconectar();
            return data;
        }

    }
}

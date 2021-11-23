using ClassLibraryClientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationClientes.Models;

namespace WebApplicationClientes.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("api/v1/clientes")]
        public List<clientes> listar() {
            List<clientes> listado = new List<clientes>();
            clienteEntity clienteData = new clienteEntity();
            DataSet data = clienteData.listadoClientes();
            
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                clientes item = new clientes();
                item.rut =  data.Tables[0].Rows[i].ItemArray[0].ToString();
                item.nombre = data.Tables[0].Rows[i].ItemArray[1].ToString();
                item.apellido = data.Tables[0].Rows[i].ItemArray[2].ToString();
                item.telefono = data.Tables[0].Rows[i].ItemArray[3].ToString();
                listado.Add(item);
            }

            return listado;
        }

        [HttpGet]
        [Route("api/v1/clientes")]
        public List<clientes> listar(string rut)
        {
            List<clientes> listado = new List<clientes>();
            clienteEntity clienteData = new clienteEntity();
            DataSet data = clienteData.listadoClientes(rut);

            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                clientes item = new clientes();
                item.rut = data.Tables[0].Rows[i].ItemArray[0].ToString();
                item.nombre = data.Tables[0].Rows[i].ItemArray[1].ToString();
                item.apellido = data.Tables[0].Rows[i].ItemArray[2].ToString();
                item.telefono = data.Tables[0].Rows[i].ItemArray[3].ToString();
                listado.Add(item);
            }

            return listado;
        }
    }
}

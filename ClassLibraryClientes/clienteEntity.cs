using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClientes
{
    public class clienteEntity
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string telefono;

        Datos data = new Datos();

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
     
        public clienteEntity()
        {

        }
        public clienteEntity(string rut, string nombre, string apellido, string telefono)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }


        public DataSet listadoClientes() {         
            return data.listado("SELECT * FROM CLIENTES");
        }

        public DataSet listadoClientes(string rut)
        {
            //return data.listado("SELECT * FROM CLIENTES WHERE RUT = '"+ rut +"'");
            List<claseParametro> lst = new List<claseParametro>();
            lst.Add(new claseParametro("@RUT", rut));
            return data.listado("SP_BUSCAR_CLIENTE", lst);
           
        }

        public DataSet buscarNombre(string rut, string nombre)
        {
            List<claseParametro> lst = new List<claseParametro>();
            lst.Add(new claseParametro("@RUT", rut));
            lst.Add(new claseParametro("@NOMBRE", nombre));
            return data.listado("SP_BUSCAR_CLIENTE_NOMBRE", lst);

        }


        public int guardar(clienteEntity cliente)
        {
            return data.ejecutar("Insert into CLIENTES(rut, nombre, apellido, telefono) values('" + cliente.Rut + "','" + cliente.Nombre + "','" + cliente.Apellido + "','" + cliente.Telefono + "')");
        }
        public int guardar()
        {
            return data.ejecutar("Insert into CLIENTES(rut, nombre, apellido, telefono) values('" + this.rut + "','" + this.nombre + "','" + this.apellido + "','" + this.telefono + "')");
        }
        public int eliminar()
        {
            return data.ejecutar("DELETE FROM CLIENTES WHERE RUT= '" + this.rut + "'");
        }
    }
}

using ClassLibraryClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientes
{
    public partial class Form1 : Form
    {

        clienteEntity cliente = new clienteEntity();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Rut = txt_rut.Text;
            cliente.Nombre = txt_nombre.Text;
            cliente.Apellido = txt_apellido.Text;
            cliente.Telefono = txt_telefono.Text;
            int x = cliente.guardar(cliente);

            if (x == 1)
            {
                MessageBox.Show("Cliente Guardado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Error en Guardado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

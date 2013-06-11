using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Controlador;

namespace Ferreteria
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

            ControladorCLIENTE c = new ControladorCLIENTE();
            c.listarCLIENTE(listViewClientes);
        
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ControladorCLIENTE c = new ControladorCLIENTE();
            c.nuevoCliente(txtNombreCliente.Text, txtApellidoCliente.Text, Convert.ToInt32(txtDni.Text), Convert.ToDateTime(dtFechaNac.Text), txtTelefono.Text, Convert.ToInt32(txtSaldo.Text)); 
            MessageBox.Show("Guardado con Exito!", "Informacion");
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreCliente.Text = listViewClientes.FocusedItem.SubItems[1].Text;
            txtApellidoCliente.Text = listViewClientes.FocusedItem.SubItems[2].Text;
            txtDni.Text = listViewClientes.FocusedItem.SubItems[3].Text;
            txtTelefono.Text = listViewClientes.FocusedItem.SubItems[4].Text;
            dtFechaNac.Text = listViewClientes.FocusedItem.SubItems[5].Text;
            txtSaldo.Text = listViewClientes.FocusedItem.SubItems[6].Text;
 
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ControladorCLIENTE c = new ControladorCLIENTE();
            c.buscarCLIENTE(listViewClientes, txtBuscar.Text);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
           
        }
    }
}

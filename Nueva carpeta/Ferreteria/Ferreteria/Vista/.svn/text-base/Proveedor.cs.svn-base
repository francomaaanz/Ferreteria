using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Controlador;

namespace Ferreteria.Vista
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            ControladorProveedor n = new ControladorProveedor();
            n.listarProveedorE(listViewProveedor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            ControladorProveedor n = new ControladorProveedor();
            n.nuevoProveedor(
            txtRazonSocial.Text, 
            txtCUIT.Text,    
            txtDireccion.Text,
            txtCiudadProvincia.Text,
            txtTelefono.Text, 
            txtCodigoPostal.Text,
            txtNumCta1.Text,
            txtNumCta2.Text,
            txtCBU.Text);
            MessageBox.Show("Guardado con Exito!", "Informacion");
            n.listarProveedorE(listViewProveedor);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ControladorProveedor n = new ControladorProveedor();
            n.buscarProveedor(listViewProveedor, txtBuscar.Text);
        }

        private void listViewProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRazonSocial.Text = listViewProveedor.FocusedItem.SubItems[1].Text;
            txtCUIT.Text = listViewProveedor.FocusedItem.SubItems[2].Text;
            txtDireccion.Text = listViewProveedor.FocusedItem.SubItems[3].Text;
            txtCodigoPostal.Text = listViewProveedor.FocusedItem.SubItems[4].Text;
            txtTelefono.Text = listViewProveedor.FocusedItem.SubItems[5].Text;
            txtCiudadProvincia.Text = listViewProveedor.FocusedItem.SubItems[6].Text;
            txtNumCta1.Text = listViewProveedor.FocusedItem.SubItems[7].Text;
            txtNumCta2.Text = listViewProveedor.FocusedItem.SubItems[8].Text;
            txtCBU.Text = listViewProveedor.FocusedItem.SubItems[9].Text;

        }
    }
}

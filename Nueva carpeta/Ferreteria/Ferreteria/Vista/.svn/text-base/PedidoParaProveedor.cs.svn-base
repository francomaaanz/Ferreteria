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
    public partial class PedidoParaProveedor : Form
    {

        private int IDProv;

        public PedidoParaProveedor()
        {
            

            InitializeComponent();


            ControladorProveedor cp = new ControladorProveedor();
            cp.cargarCboProveedor(comboBoxProvRoto);


            ClontroladorPedidoParaProveedor crd = new ClontroladorPedidoParaProveedor();
            crd.listarPedidoParaProveedor(listViewPedidoProveedor);
        }




        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ClontroladorPedidoParaProveedor defe = new ClontroladorPedidoParaProveedor();
            defe.nuevoPedidoParaProveedor(IDProv,Convert.ToDateTime(dateTimePickerFechaHechoPedido.Text), Convert.ToDateTime(dateTimePickerFechaLlegadaPedido.Text),comboBoxEstado.Text);
            MessageBox.Show("Guardado con Exito!", "Informacion");
        }




        private void comboBoxProvRoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControladorProveedor cp = new ControladorProveedor();
            IDProv = cp.obtenerIDProveedor(comboBoxProvRoto.Text);
        }
    }
}

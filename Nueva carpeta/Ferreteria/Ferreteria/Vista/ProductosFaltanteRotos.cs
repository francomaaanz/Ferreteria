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
    public partial class ProductosFaltanteRotos : Form
    {
        private int IDProducto;
        private int IDProv;
        
        public ProductosFaltanteRotos()
        {
            InitializeComponent();
            ControladorProveedor cp = new ControladorProveedor();
            cp.cargarCboProveedor(comboBoxProvRoto);

            ControladorRotoDefectuoso crd = new ControladorRotoDefectuoso();
            crd.listarRotoDefectuoso(listViewProductoFaltantesRotos);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(txtNomProdRoto.Text);
            p.ShowDialog();
            if (p.DialogResult == DialogResult.OK) {
                IDProducto = p.IDProducto;
                txtNomProdRoto.Text = p.ProductoNom;
                
            }
        }

        private void listViewProductoFaltantesRotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDetalleProdRoto.Text = listViewProductoFaltantesRotos.FocusedItem.SubItems[1].Text;
            comboBoxProvRoto.Text = listViewProductoFaltantesRotos.FocusedItem.SubItems[2].Text;
            txtDetalleProdRoto.Text = listViewProductoFaltantesRotos.FocusedItem.SubItems[3].Text;

        }

        private void comboBoxProvRoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControladorProveedor cp = new ControladorProveedor();
            IDProv = cp.obtenerIDProveedor(comboBoxProvRoto.Text);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //ControladorProducto n = new ControladorProducto();
            //n.nuevoProducto(txtDetalleProducto.Text, txtCantidad.Text, Convert.ToDecimal(txtPrecioNeto.Text), Convert.ToDecimal(txtPrecioIva.Text));
            //MessageBox.Show("Guardado con Exito!", "Informacion");
          
            ControladorRotoDefectuoso defe = new ControladorRotoDefectuoso();
            defe.nuevoRotoDefectuoso(IDProducto, IDProv, txtDetalleProdRoto.Text);
            MessageBox.Show("Guardado con Exito!", "Informacion");



        }

         
    }
}

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
    public partial class Producto : Form
    {

        public int IDProducto;
        public String ProductoNom;
        
        public Producto(String producto)
        {
            InitializeComponent();
           
            ControladorProducto n = new ControladorProducto();

            if (producto == "") { 
                n.listarProducto(listViewProducto); }
            else {
                n.buscarProducto(listViewProducto, producto);
                panel1.Visible = false;
            }
        }








        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ControladorProducto n = new ControladorProducto();
            n.nuevoProducto(txtDetalleProducto.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDecimal(txtPrecioNeto.Text), Convert.ToDecimal(txtPrecioIva.Text), Convert.ToInt32(txtStockMinimo.Text));
            MessageBox.Show("Guardado con Exito!", "Informacion");
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDetalleProducto.Text = listViewProducto.FocusedItem.SubItems[1].Text;
            txtCantidad.Text = listViewProducto.FocusedItem.SubItems[2].Text;
            txtPrecioIva.Text = listViewProducto.FocusedItem.SubItems[3].Text;
            txtPrecioNeto.Text = listViewProducto.FocusedItem.SubItems[4].Text;
            txtStockMinimo.Text = listViewProducto.FocusedItem.SubItems[5].Text;

            ProductoNom = listViewProducto.FocusedItem.SubItems[1].Text;
            IDProducto = Convert.ToInt32(listViewProducto.FocusedItem.SubItems[0].Text);
            this.DialogResult = DialogResult.OK;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ControladorProducto c = new ControladorProducto();
            c.buscarProducto(listViewProducto, txtBuscar.Text);
        
            // ControladorCLIENTE c = new ControladorCLIENTE();
           // c.buscarCLIENTE(listViewClientes, txtBuscar.Text);
        }

       
    }
}

    //foreach (ListViewItem i in listViewStockAlimentos.Items)
    //        {

    //            if (Convert.ToInt32((i.SubItems[3].Text.Trim())) < 60)
    //            {

    //                i.ForeColor = Color.OrangeRed;
    //            }
    //            else if (Convert.ToInt32((i.SubItems[3].Text.Trim())) > 60 && Convert.ToInt32((i.SubItems[3].Text.Trim())) < 120)
    //            {

    //                i.ForeColor = Color.Goldenrod;
    //            }
    //            else if (Convert.ToInt32((i.SubItems[3].Text.Trim())) > 120)
    //            {

    //                i.ForeColor = Color.Green;
    //            }


    //        }
    //    }
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
    public partial class VentarPorDia : Form
    {
        public VentarPorDia()
        {
            InitializeComponent();
            ControladorVentasPorDia cvpd = new ControladorVentasPorDia();
            cvpd.listarVentaPorDia(listViewVentasPorDia);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ControladorVentasPorDia n = new ControladorVentasPorDia();
            n.nuevoVentaPorDia(Convert.ToDateTime(dateTimePickerFechaMontoDelDia.Text), Convert.ToDecimal(txtMontoDelDia.Text));
            MessageBox.Show("Guardado con Exito!", "Informacion");
        }

        private void listViewVentasPorDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePickerFechaMontoDelDia.Text = listViewVentasPorDia.FocusedItem.SubItems[1].Text;
            txtMontoDelDia.Text = listViewVentasPorDia.FocusedItem.SubItems[2].Text;
           
        }
    }
}

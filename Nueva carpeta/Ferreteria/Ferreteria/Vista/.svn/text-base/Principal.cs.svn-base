using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Ferreteria;
using System.Windows.Forms;


namespace Ferreteria.Vista
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
             
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
          //  c.MaximumSize = this.on;
            
            c.Show();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto p = new Producto("");
      
            p.MdiParent = this;
            p.WindowState = FormWindowState.Maximized;
            //  c.MaximumSize = this.on;

            p.Show();
        }

        private void borrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.MdiParent = this;
            //  c.MaximumSize = this.on;

            c.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            prov.MdiParent = this;
            //  c.MaximumSize = this.on;

            prov.Show();
        }

        private void rotoDefectuosoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosFaltanteRotos pp = new ProductosFaltanteRotos();
            pp.MdiParent = this;
            pp.Show();
        }

        private void pedidosAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoParaProveedor p = new PedidoParaProveedor();
            p.MdiParent = this;
            p.Show();
        }

       
    }
}

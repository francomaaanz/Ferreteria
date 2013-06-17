using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Modelo;

namespace Ferreteria.Controlador
{
    class ClontroladorPedidoParaProveedor
    {

        //LISTAR PEDIDO PARA EL PROVEEDOR
        public void listarPedidoParaProveedor(ListView listView)
        {
            // ControladorProveedor cc = new ControladorProveedor();
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {

                    var resultado = from m in db.PEDIDO_PROVEEDOR
                                    join p in db.Estado_Pedido on m.Estado equals p.Estado
                                    join prov in db.PROVEEDOR on m.IDproveedor equals prov.IDproveedor
                                    select new { m, p, prov };

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.m.ID_PEDIDO_PROVEEDOR.ToString());
                        i.SubItems.Add(r.prov.RazonSocial.ToString());
                        i.SubItems.Add(r.m.FechaPedido.ToString());
                        i.SubItems.Add(r.m.FechaLLegada.ToString());
                        i.SubItems.Add(r.p.Estado.ToString());

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }


        //MODIFICAR PEDIDO PARA EL PROVEEDOR
        public void buscarPedidoParaProveedor(ListView listView, String Buscado)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {

                     var resultado = from m in db.PEDIDO_PROVEEDOR
                                     join p in db.Estado_Pedido on m.Estado equals p.Estado
                                     join prov in db.PROVEEDOR on m.IDproveedor equals prov.IDproveedor
                                     where prov.RazonSocial.Contains(Buscado) 
                                     select new { m, p, prov };

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.m.ID_PEDIDO_PROVEEDOR.ToString());
                        i.SubItems.Add(r.prov.RazonSocial.ToString());
                        i.SubItems.Add(r.m.FechaPedido.ToString());
                        i.SubItems.Add(r.m.FechaLLegada.ToString());
                        i.SubItems.Add(r.p.Estado.ToString());

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }





        // MODIFICAR PEDIDO PARA EL PROVEEDOR
        public void modificarPedidoParaProveedor(int IDPedidoProveedor, int nombreProveedor, DateTime fechaHechoPedido, DateTime fechaLlegadaPedido, string estado)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    db.PEDIDO_PROVEEDOR.Find(IDPedidoProveedor).IDproveedor = nombreProveedor;
                    db.PEDIDO_PROVEEDOR.Find(IDPedidoProveedor).FechaPedido = fechaHechoPedido;
                    db.PEDIDO_PROVEEDOR.Find(IDPedidoProveedor).FechaLLegada = fechaLlegadaPedido;
                    db.PEDIDO_PROVEEDOR.Find(IDPedidoProveedor).Estado = estado;

                    db.SaveChanges();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }



        //NUEVO PEDIDO PARA PROVEEDOR
        public void nuevoPedidoParaProveedor( int nombreProveedor, DateTime fechaHechoPedido, DateTime fechaLlegadaPedido, string estado)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    PEDIDO_PROVEEDOR m = new PEDIDO_PROVEEDOR();
                    
                    m.IDproveedor = nombreProveedor;
                    m.FechaPedido = fechaHechoPedido;
                    m.FechaLLegada = fechaLlegadaPedido;
                    m.Estado = estado;

                    db.PEDIDO_PROVEEDOR.Add(m);
                    db.SaveChanges();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }
    }
}

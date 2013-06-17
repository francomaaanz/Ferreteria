using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Modelo;

namespace Ferreteria.Controlador
{
    class ControladorRotoDefectuoso
    {

        public void listarRotoDefectuoso(ListView listView)
        {
           // ControladorProveedor cc = new ControladorProveedor();
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.PRODUCTO_FALTANTE_ROTO 
                                    join p in db.PRODUCTO on m.IDproducto equals p.IDproducto
                                    join prov in db.PROVEEDOR on m.IDproveedor equals prov.IDproveedor
                                    select new  {m, p, prov};

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.m.Id_prodFaltaRo.ToString());
                        i.SubItems.Add(r.p.DetalleProducto.ToString());
                        i.SubItems.Add(r.prov.RazonSocial.ToString());
                        i.SubItems.Add(r.m.Detalle);
                        
                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }
      

        public void buscarRotoDefectuoso(ListView listView, String Buscado)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.PRODUCTO_FALTANTE_ROTO
                                    join p in db.PRODUCTO on m.IDproducto equals p.IDproducto
                                    join prov in db.PROVEEDOR on m.IDproveedor equals prov.IDproveedor
                                    where p.DetalleProducto.Contains(Buscado)
                                    select new { m, p, prov };

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.m.Id_prodFaltaRo.ToString());
                        i.SubItems.Add(r.p.DetalleProducto.ToString());
                        i.SubItems.Add(r.prov.RazonSocial.ToString());
                        i.SubItems.Add(r.m.Detalle.ToString());

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

       // MODIFICAR  PRODUCTO ROTO O DEFECTUOSO
        public void modificarRotoDefectuoso(int IDProductoRotoDefectuoso, int nombreProducto, int nombreProveedor, string detalle)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    db.PRODUCTO_FALTANTE_ROTO.Find(IDProductoRotoDefectuoso).IDproducto = nombreProducto;
                    db.PRODUCTO_FALTANTE_ROTO.Find(IDProductoRotoDefectuoso).IDproveedor = nombreProveedor;
                    db.PRODUCTO_FALTANTE_ROTO.Find(IDProductoRotoDefectuoso).Detalle = detalle;
                   
                    db.SaveChanges();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }



        //NUEVO PRODUCTO ROTO O DEFECTUOSO
        public void nuevoRotoDefectuoso(int nombreProducto, int nombreProveedor, string detalle)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    PRODUCTO_FALTANTE_ROTO m = new PRODUCTO_FALTANTE_ROTO();
                    m.IDproducto = nombreProducto;
                    m.IDproveedor = nombreProveedor;
                    m.Detalle = detalle;

                    db.PRODUCTO_FALTANTE_ROTO.Add(m);
                    db.SaveChanges();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }
    }
}

//using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ferreteria.Controlador;
using Ferreteria.Modelo;
using System;

namespace Ferreteria.Controlador
{
    class ControladorProducto
    {

        //LISTAR PRODUCTO
        public void listarProducto(ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.PRODUCTO select m;

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.IDproducto.ToString());
                        i.SubItems.Add(r.Rubro.ToString());
                        i.SubItems.Add(r.DetalleProducto.ToString());
                        i.SubItems.Add(r.Cantidad.ToString());
                        i.SubItems.Add(r.PrecioNeto.ToString());
                        i.SubItems.Add(r.PrecioIva.ToString());
                        i.SubItems.Add(r.StockMinimo.ToString());                    
                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

        // BSUCAR PRODUCTO
        public void buscarProducto(ListView listView, String Buscado)
        {
            try
            {
                listView.Items.Clear();
                using (var db = new FERRETERIAEntities())
                {
                    var resultado = from m in db.PRODUCTO where m.DetalleProducto.Contains(Buscado) select m;

                    foreach (var r in resultado)
                    {
                        ListViewItem i = new ListViewItem(r.IDproducto.ToString());
                        i.SubItems.Add(r.Rubro.ToString());
                        i.SubItems.Add(r.DetalleProducto.ToString());
                        i.SubItems.Add(r.Cantidad.ToString());
                        i.SubItems.Add(r.PrecioNeto.ToString());
                        i.SubItems.Add(r.PrecioIva.ToString());
                        i.SubItems.Add(r.StockMinimo.ToString()); 

                        listView.Items.Add(i);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }

        //MODIFICAR producto
        public void modificarProducto(String rubro, String DetalleProducto, int cantidad, Decimal PrecioNeto, Decimal PrecioIva, int IDproducto, int stockMinimo)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    db.PRODUCTO.Find(IDproducto).Rubro = rubro;
                    db.PRODUCTO.Find(IDproducto).DetalleProducto = DetalleProducto;
                    db.PRODUCTO.Find(IDproducto).Cantidad = cantidad; 
                    db.PRODUCTO.Find(IDproducto).PrecioNeto = PrecioNeto;
                    db.PRODUCTO.Find(IDproducto).PrecioIva = PrecioIva;
                    db.PRODUCTO.Find(IDproducto).StockMinimo = stockMinimo;
               
                    db.SaveChanges();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }



        //NUEVO CLIENTE
        public void nuevoProducto(String rubro, String DetalleProducto, int cantidad, Decimal PrecioNeto, Decimal PrecioIva, int stockMinimo)
        {
            try
            {

                using (var db = new FERRETERIAEntities())
                {
                    PRODUCTO p = new PRODUCTO();
                    p.Rubro = rubro;
                    p.DetalleProducto = DetalleProducto;
                    p.Cantidad= cantidad;
                    p.PrecioNeto= PrecioNeto;
                    p.PrecioIva= PrecioIva;
                    p.StockMinimo = stockMinimo;

                    db.PRODUCTO.Add(p);

                    db.SaveChanges();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { }
        }



    }
}

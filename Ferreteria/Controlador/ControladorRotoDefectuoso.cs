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
      

        //public void buscarRotoDefectuoso(ListView listView, String Buscado)
        //{
        //    try
        //    {
        //        listView.Items.Clear();
        //        using (var db = new FERRETERIAEntities())
        //        {
        //            var resultado = from m in db.PRODUCTO_FALTANTE_ROTO where m..Contains(Buscado) select m;

        //            foreach (var r in resultado)
        //            {
        //                ListViewItem i = new ListViewItem(r.Id_prodFaltaRo.ToString());
        //                i.SubItems.Add(r.IDproducto.ToString());
        //                i.SubItems.Add(r.IDproveedor.ToString());
        //                i.SubItems.Add(r.Detalle.ToString());

        //                listView.Items.Add(i);
        //            }
        //        }

        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        //    finally { }
        //}

        //MODIFICAR CLIENTE
       
        
        
        
        
        
        //public void modificarRotoDefectuoso(int idCliente, String nombre, String apellido, int dni, DateTime fechaNacimiento, String telefono, String saldo, String monto)
        //{
        //    try
        //    {

        //        using (var db = new FERRETERIAEntities())
        //        {
        //            db.CLIENTE.Find(idCliente).Nombre = nombre;
        //            db.CLIENTE.Find(idCliente).Apellido = apellido;
        //            db.CLIENTE.Find(idCliente).Dni = dni;
        //            db.CLIENTE.Find(idCliente).FechaNacimiento = fechaNacimiento;

        //            db.SaveChanges();
        //        }

        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        //    finally { }
        //}



        //NUEVO CLIENTE
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
